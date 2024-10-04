using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Capybara.CommentView.Ext;
using Capybara.CommentView.Models;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.Desktop.IntegrationApi.Interfaces;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

namespace Capybara.CommentView
{
    public partial class FilesCommentViewPartControl : UserControl, IUIControl
    {
        private string _initialDirectory;

        private static readonly XSSFFont InlineRegularFont = new XSSFFont();

        private static readonly XSSFFont InlineCommentFont = new XSSFFont();
        private SortableBindingList<CommentEntry> _commentEntries = new SortableBindingList<CommentEntry>();
        private SortableBindingList<ProjectFileEntry> _fileEntries = new SortableBindingList<ProjectFileEntry>();

        private static readonly Dictionary<string, Color> BackColors = new Dictionary<string, Color>
        {
            {"Low", ColorTranslator.FromHtml("0xEEE8AA")},
            {"Medium", ColorTranslator.FromHtml("0xFFDEAD")},
            {"High", ColorTranslator.FromHtml("0xE9967A")}
        };

        private static readonly string DateTimeFormat = "MM/dd/yyyy HH:mm:ss";

        private ExportOptions _exportOptions = new ExportOptions();

        private static readonly Dictionary<string, bool> CommentsSheetColumns = new Dictionary<string, bool>
        {
            {
                "File",
                true
            },
            {
                "Segment ID",
                true
            },
            {
                "Comment",
                true
            },
            {
                "Author",
                true
            },
            {
                "Date",
                true
            },
            {
                "Severity",
                true
            },
            {
                "Version",
                true
            },
            {
                "Source",
                true
            },
            {
                "Target",
                true
            }
        };

        private static readonly Dictionary<string, bool> FilesSheetColumns = new Dictionary<string, bool>
        {
            {
                "Comments",
                true
            },
            {
                "File",
                true
            }
        };

        public FilesCommentViewPartControl()
        {
            InitializeComponent();
            _initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            InlineRegularFont.FontName = "Segoe UI";
            InlineCommentFont.IsBold = true;
            InlineCommentFont.FontName = "Segoe UI";
            InlineCommentFont.SetColor(new XSSFColor(Color.Blue));
            sourceRTB.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            targetRTB.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            commentEntryBindingSource.DataSource = _commentEntries;
            fileEntryBindingSource.DataSource = _fileEntries;
            loadingProgressBar.Visible = false;
            //GetFilesController().SelectedFilesChanged += CommentViewPartControl_SelectedFilesChanged;
        }

        public void ShowLoadingProgressBar(bool visible)
        {
            loadingProgressBar.Visible = visible;
            if (visible)
            {
                loadingProgressBar.Style = ProgressBarStyle.Marquee;
                loadingProgressBar.MarqueeAnimationSpeed = 50;
            }
            else
            {
                loadingProgressBar.Style = ProgressBarStyle.Blocks;
            }
        }

        public void SetContent(IEnumerable<ProjectFileEntry> entries)
        {
            entries = entries.ToList();
            var commentIndices =
                commentsDGV.SelectedRows.OfType<DataGridViewRow>()
                    .Select(row => row.Index)
                    .Where(i => i >= 0)
                    .ToList();
            var fileIndices =
                filesDGV.SelectedRows.OfType<DataGridViewRow>().Select(row => row.Index).Where(i => i >= 0)
                    .ToList();

            sourceRTB.Clear();
            targetRTB.Clear();
            _commentEntries.Clear();
            _fileEntries.Clear();
            
            _commentEntries.AddRange(entries.SelectMany(x => x.Comments));
            _fileEntries.AddRange(entries);

            if (commentIndices.Count > 0)
            {
                commentsDGV.ClearSelection();
                foreach (var index in commentIndices)
                {
                    if (commentsDGV.Rows.Count > index)
                    {
                        commentsDGV.CurrentCell = commentsDGV.Rows[index].Cells[0];
                        commentsDGV.Rows[index].Selected = true;
                    }
                }
            }

            if (fileIndices.Count > 0)
            {
                filesDGV.ClearSelection();
            }

            foreach (var index in fileIndices)
            {
                if (filesDGV.Rows.Count > index)
                {
                    filesDGV.CurrentCell = filesDGV.Rows[index].Cells[0];
                    filesDGV.Rows[index].Selected = true;
                }
            }

        }

        private FilesController GetFilesController()
        {
            return SdlTradosStudio.Application.GetController<FilesController>();
        }

        private EditorController GetEditorController()
        {
            return SdlTradosStudio.Application.GetController<EditorController>();
        }

        private void commentsDGV_SelectionChanged(object sender, EventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null)
            {
                return;
            }

            var row = dgv.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();
            if (row == null)
            {
                return;
            }

            var entry = row.DataBoundItem as CommentEntry;
            if (entry == null)
            {
                return;
            }

            sourceRTB.Clear();
            targetRTB.Clear();
            if (entry.SourceSegment != null)
            {
                PaintSegmentText(entry.SourceText, entry.SourceSegment, sourceRTB, BackColors[entry.Severity]);
            }

            if (entry.TargetSegment != null)
            {
                PaintSegmentText(entry.TargetText, entry.TargetSegment, targetRTB, BackColors[entry.Severity]);
            }
        }

        private void PaintSegmentText(string segmentText, List<ISegmentElement> segmentElements, RichTextBox rtb,
            Color backColor)
        {
            rtb.Text = segmentText.Replace("\r\n", "\n").Replace("\r", "\n");
            var index = 0;
            foreach (var element in segmentElements)
            {
                var value = element.Value.Replace("\r\n", "\n").Replace("\r", "\n");
                if (element is CommentElement)
                {
                    rtb.Select(index, value.Length);
                    rtb.SelectionBackColor = backColor;
                }

                index += value.Length;
            }

            rtb.SelectionLength = 0;
        }

        private void commentsDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.Value != null)
            {
                DateTime dateTime;
                if (DateTime.TryParse(e.Value as string, out dateTime))
                {
                    e.Value = dateTime.ToString(DateTimeFormat);
                    e.FormattingApplied = true;
                }
            }
        }

        private void commentsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (e.RowIndex < 0 || dgv == null)
            {
                return;
            }

            var row = dgv.Rows[e.RowIndex].DataBoundItem as CommentEntry;
            if (row == null)
            {
                return;
            }

            try
            {
                var document = GetEditorController().Open(row.ProjectFile, EditingMode.Translation);
                if (row.ParagraphId != null && row.SegmentId != null)
                {
                    document.SetActiveSegmentPair(row.ParagraphId, row.SegmentId, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot open the file: \n{0}", ex.Message));
            }
        }

        private void filesDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                var val = (int) e.Value;
                if (val > 0)
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void filesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (e.RowIndex < 0 || dgv == null)
            {
                return;
            }

            var row = dgv.Rows[e.RowIndex].DataBoundItem as ProjectFileEntry;
            if (row == null)
            {
                return;
            }

            try
            {
                GetEditorController().Open(row.ProjectFile, EditingMode.Translation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot open the file: \n{0}", ex.Message));
            }
        }

        private void filesDGV_KeyDown(object sender, KeyEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null || e.KeyCode != Keys.Enter)
            {
                return;
            }

            try
            {
                var selectedFiles =
                    dgv.SelectedRows.OfType<DataGridViewRow>()
                        .Select(r => (r.DataBoundItem as ProjectFileEntry).ProjectFile)
                        .ToList();

                if (selectedFiles.Count == 0)
                {
                    return;
                }

                GetEditorController().Open(selectedFiles, EditingMode.Translation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot open the files: \n{0}", ex.Message));
            }

            e.Handled = true;
        }

        private void commentsDGV_KeyDown(object sender, KeyEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null || e.KeyCode != Keys.Enter)
            {
                return;
            }

            try
            {
                var row =
                    dgv.SelectedRows.OfType<DataGridViewRow>()
                        .Select(r => r.DataBoundItem as CommentEntry)
                        .FirstOrDefault();

                if (row == null)
                {
                    return;
                }

                var document = GetEditorController().Open(row.ProjectFile, EditingMode.Translation);
                if (row.ParagraphId != null && row.SegmentId != null)
                {
                    document.SetActiveSegmentPair(row.ParagraphId, row.SegmentId, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot open the files: \n{0}", ex.Message));
            }

            e.Handled = true;
        }

        private void showExportFormButton_Click(object sender, EventArgs e)
        {
            using (ExportForm exportForm = new ExportForm(_exportOptions))
            {
                if (exportForm.ShowDialog(this) == DialogResult.OK)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.InitialDirectory = _initialDirectory;
                        saveFileDialog.RestoreDirectory = true;
                        saveFileDialog.FileName = GetFilesController().CurrentProject.GetProjectInfo().Name +
                                                  "_comments.xlsx";
                        saveFileDialog.Title = "Export Comments to Xlsx";
                        saveFileDialog.Filter = "Excel File(*.xlsx)|*.xlsx";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                XSSFWorkbook xSSFWorkbook = new XSSFWorkbook();
                                ICellStyle cellStyle = xSSFWorkbook.CreateCellStyle();
                                cellStyle.WrapText = true;
                                IFont font = xSSFWorkbook.CreateFont();
                                font.FontName = "Arial Unicode MS";
                                cellStyle.SetFont(font);
                                IFont font2 = xSSFWorkbook.CreateFont();
                                font2.FontName = "Arial Unicode MS";
                                font2.IsBold = true;
                                font2.Color = IndexedColors.Blue.Index;
                                ISheet commentsSheet = xSSFWorkbook.CreateSheet("Comments");
                                CreateCommentsSheet(commentsSheet, cellStyle);
                                ISheet filesSheet = xSSFWorkbook.CreateSheet("Files");
                                CreateFilesSheet(filesSheet, cellStyle);
                                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create,
                                    FileAccess.Write))
                                {
                                    xSSFWorkbook.Write(fileStream);
                                }

                                _initialDirectory = Path.GetDirectoryName(saveFileDialog.FileName);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void CreateFilesSheet(ISheet filesSheet, ICellStyle style)
        {
            int num = 0;
            FilesSheetColumns["Comments"] = _exportOptions.Comments;
            FilesSheetColumns["File"] = _exportOptions.File2;
            string[] array = (from c in FilesSheetColumns
                where c.Value
                select c.Key).ToArray<string>();
            CreateRow(filesSheet, num, style, array);
            foreach (ProjectFileEntry current in _fileEntries)
            {
                num++;
                List<string> list = new List<string>();
                if (array.Contains("Comments"))
                {
                    list.Add(current.Comments.ToString());
                }

                if (array.Contains("File"))
                {
                    list.Add(current.FileName);
                }

                CreateRow(filesSheet, num, style, list.ToArray());
            }

            for (int i = 0; i < array.Length; i++)
            {
                filesSheet.AutoSizeColumn(i);
            }
        }

        private void CreateCommentsSheet(ISheet commentsSheet, ICellStyle cellStyle)
        {
            int num = 0;
            CommentsSheetColumns["File"] = _exportOptions.File;
            CommentsSheetColumns["Segment ID"] = _exportOptions.SegmentId;
            CommentsSheetColumns["Comment"] = _exportOptions.Comment;
            CommentsSheetColumns["Author"] = _exportOptions.Author;
            CommentsSheetColumns["Date"] = _exportOptions.Date;
            CommentsSheetColumns["Severity"] = _exportOptions.Severity;
            CommentsSheetColumns["Version"] = _exportOptions.Version;
            CommentsSheetColumns["Source"] = _exportOptions.Source;
            CommentsSheetColumns["Target"] = _exportOptions.Target;
            string[] array = (from c in CommentsSheetColumns
                where c.Value
                select c.Key).ToArray<string>();
            CreateRow(commentsSheet, num, cellStyle, array);
            foreach (CommentEntry current in _commentEntries)
            {
                num++;
                XSSFFont inlineCommentFont = InlineCommentFont;
                List<string> list = new List<string>();
                if (array.Contains("File"))
                {
                    list.Add(current.FileName);
                }

                if (array.Contains("Segment ID"))
                {
                    list.Add(current.SegmentId);
                }

                if (array.Contains("Comment"))
                {
                    list.Add(current.Text);
                }

                if (array.Contains("Author"))
                {
                    list.Add(current.Author);
                }

                if (array.Contains("Date"))
                {
                    string item = current.Date;
                    DateTime dateTime;
                    if (DateTime.TryParse(current.Date, out dateTime))
                    {
                        item = dateTime.ToString(DateTimeFormat);
                    }

                    list.Add(item);
                }

                if (array.Contains("Severity"))
                {
                    list.Add(current.Severity);
                }

                if (array.Contains("Version"))
                {
                    list.Add(current.Version);
                }

                List<ISegmentElement> sourceSegment = array.Contains("Source") ? current.SourceSegment : null;
                List<ISegmentElement> targetSegment = array.Contains("Target") ? current.TargetSegment : null;
                CreateRow(commentsSheet, num, cellStyle, inlineCommentFont, sourceSegment, targetSegment,
                    list.ToArray());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "Comment" || array[i] == "Source" || array[i] == "Target")
                {
                    commentsSheet.SetColumnWidth(i, 12500);
                }
                else
                {
                    commentsSheet.AutoSizeColumn(i);
                }
            }
        }

        private void CreateRow(ISheet sheet, int rowNum, ICellStyle style, params string[] values)
        {
            IRow row = sheet.CreateRow(rowNum);
            for (int i = 0; i < values.Length; i++)
            {
                ICell cell = row.CreateCell(i);
                cell.SetCellValue(values[i] ?? string.Empty);
                cell.CellStyle = style;
            }
        }

        private void CreateRow(ISheet sheet, int rowNum, ICellStyle cellStyle, XSSFFont commentFont,
            List<ISegmentElement> sourceSegment, List<ISegmentElement> targetSegment, params string[] values)
        {
            IRow row = sheet.CreateRow(rowNum);
            int i;
            for (i = 0; i < values.Length; i++)
            {
                ICell cell = row.CreateCell(i);
                cell.SetCellValue(values[i] ?? string.Empty);
                cell.CellStyle = cellStyle;
            }

            if (sourceSegment != null)
            {
                ICell cell2 = row.CreateCell(i);
                cell2.CellStyle = cellStyle;
                XSSFRichTextString xSSFRichTextString = new XSSFRichTextString("");
                foreach (ISegmentElement current in sourceSegment)
                {
                    if (current is CommentElement)
                    {
                        xSSFRichTextString.Append(current.Value, commentFont);
                    }
                    else
                    {
                        xSSFRichTextString.Append(current.Value, InlineRegularFont);
                    }
                }

                cell2.SetCellValue(xSSFRichTextString);
                i++;
            }

            if (targetSegment != null)
            {
                ICell cell3 = row.CreateCell(i);
                cell3.CellStyle = cellStyle;
                XSSFRichTextString xSSFRichTextString2 = new XSSFRichTextString("");
                foreach (ISegmentElement current2 in targetSegment)
                {
                    if (current2 is CommentElement)
                    {
                        xSSFRichTextString2.Append(current2.Value, commentFont);
                    }
                    else
                    {
                        xSSFRichTextString2.Append(current2.Value, InlineRegularFont);
                    }
                }

                cell3.SetCellValue(xSSFRichTextString2);
            }
        }
    }
}