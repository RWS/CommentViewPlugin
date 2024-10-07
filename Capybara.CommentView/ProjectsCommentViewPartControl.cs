using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Capybara.CommentView.Ext;
using Capybara.CommentView.Interfaces;
using Sdl.Desktop.IntegrationApi.Interfaces;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Events;
using Subro.Controls;

namespace Capybara.CommentView
{
    public partial class ProjectsCommentViewPartControl : UserControl, IUIControl
    {
        private SortableBindingList<TargetLanguageBasedProjectEntry> _projectEntries = new SortableBindingList<TargetLanguageBasedProjectEntry>();

        public ProjectsCommentViewPartControl()
        {
            InitializeComponent();
            loadingProgressBar.Visible = false;
            targetLanguageBasedProjectEntryBindingSource.DataSource = _projectEntries;
            var grouper = new Subro.Controls.DataGridViewGrouper(projectsDGV);
            grouper.SetGroupOn<TargetLanguageBasedProjectEntry>(x => x.ProjectName);
            grouper.Options.ShowCount = false;
            grouper.Options.ShowGroupName = false;
            grouper.DisplayGroup += GrouperOnDisplayGroup;
        }

        private void GrouperOnDisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.Summary = $"({e.Group.OfType<TargetLanguageBasedProjectEntry>().Sum(x => x.CommentsCount)})";
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

        public void SetContent(IEnumerable<TargetLanguageBasedProjectEntry> entries)
        {
            _projectEntries.Clear();
            _projectEntries.AddRange(entries);
        }

        private void projectsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (e.RowIndex < 0 || dgv == null)
            {
                return;
            }

            var entry = dgv.Rows[e.RowIndex].DataBoundItem as TargetLanguageBasedProjectEntry;
            OpenProject(entry);
        }

        private ProjectsController GetProjectsController()
        {
            return SdlTradosStudio.Application.GetController<ProjectsController>();
        }

        private IStudioEventAggregator GetEventAggregator()
        {
            return SdlTradosStudio.Application.GetService<IStudioEventAggregator>();
        }

        private void OpenProject(TargetLanguageBasedProjectEntry entry)
        {
            if (entry == null)
            {
                return;
            }
            try
            {
                GetEventAggregator().Publish(new OpenProjectForSelectedLanguageEvent(entry.Project, entry.TargetLanguage));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot open the project: \n{ex.Message}");
            }

        }

        private void projectsDGV_KeyDown(object sender, KeyEventArgs e)
        {

            var dgv = sender as DataGridView;
            if (dgv == null || e.KeyCode != Keys.Enter)
            {
                return;
            }
            var row =
                dgv.SelectedRows.OfType<DataGridViewRow>()
                    .Select(r => r.DataBoundItem as TargetLanguageBasedProjectEntry)
                    .FirstOrDefault();

            OpenProject(row);

            e.Handled = true;
        }

        private void projectsDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 4 && e.Value != null)
            {
                var val = (int) e.Value;
                if (val > 0)
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
            }
        }
    }
}
