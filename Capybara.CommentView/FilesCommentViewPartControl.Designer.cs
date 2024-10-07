namespace Capybara.CommentView
{
    partial class FilesCommentViewPartControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.commentsDGV = new System.Windows.Forms.DataGridView();
            this.fileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paragraphIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.commentsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sourceRTB = new System.Windows.Forms.RichTextBox();
            this.targetRTB = new System.Windows.Forms.RichTextBox();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.filesDGV = new System.Windows.Forms.DataGridView();
            this.CommentsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rootTable = new System.Windows.Forms.TableLayoutPanel();
            this.showExportFormButton = new System.Windows.Forms.Button();
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentEntryBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.commentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.filesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileEntryBindingSource)).BeginInit();
            this.rootTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentsDGV
            // 
            this.commentsDGV.AllowUserToAddRows = false;
            this.commentsDGV.AllowUserToDeleteRows = false;
            this.commentsDGV.AllowUserToOrderColumns = true;
            this.commentsDGV.AllowUserToResizeRows = false;
            this.commentsDGV.AutoGenerateColumns = false;
            this.commentsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.commentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.paragraphIdDataGridViewTextBoxColumn,
            this.segmentIdDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.sourceTextDataGridViewTextBoxColumn,
            this.targetTextDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.severityDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn});
            this.commentsDGV.DataSource = this.commentEntryBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commentsDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.commentsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.commentsDGV.Location = new System.Drawing.Point(0, 0);
            this.commentsDGV.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.commentsDGV.Name = "commentsDGV";
            this.commentsDGV.RowHeadersVisible = false;
            this.commentsDGV.RowTemplate.Height = 21;
            this.commentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commentsDGV.Size = new System.Drawing.Size(637, 304);
            this.commentsDGV.TabIndex = 0;
            this.commentsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commentsDGV_CellDoubleClick);
            this.commentsDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.commentsDGV_CellFormatting);
            this.commentsDGV.SelectionChanged += new System.EventHandler(this.commentsDGV_SelectionChanged);
            this.commentsDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commentsDGV_KeyDown);
            // 
            // fileDataGridViewTextBoxColumn
            // 
            this.fileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fileDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileDataGridViewTextBoxColumn.HeaderText = "File";
            this.fileDataGridViewTextBoxColumn.Name = "fileDataGridViewTextBoxColumn";
            this.fileDataGridViewTextBoxColumn.Width = 56;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 20;
            // 
            // paragraphIdDataGridViewTextBoxColumn
            // 
            this.paragraphIdDataGridViewTextBoxColumn.DataPropertyName = "ParagraphId";
            this.paragraphIdDataGridViewTextBoxColumn.HeaderText = "ParagraphId";
            this.paragraphIdDataGridViewTextBoxColumn.Name = "paragraphIdDataGridViewTextBoxColumn";
            this.paragraphIdDataGridViewTextBoxColumn.Visible = false;
            this.paragraphIdDataGridViewTextBoxColumn.Width = 71;
            // 
            // segmentIdDataGridViewTextBoxColumn
            // 
            this.segmentIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.segmentIdDataGridViewTextBoxColumn.DataPropertyName = "SegmentId";
            dataGridViewCellStyle1.NullValue = "N/A";
            this.segmentIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.segmentIdDataGridViewTextBoxColumn.HeaderText = "Segment ID";
            this.segmentIdDataGridViewTextBoxColumn.Name = "segmentIdDataGridViewTextBoxColumn";
            this.segmentIdDataGridViewTextBoxColumn.Width = 99;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.textDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.textDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // sourceTextDataGridViewTextBoxColumn
            // 
            this.sourceTextDataGridViewTextBoxColumn.DataPropertyName = "SourceText";
            this.sourceTextDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceTextDataGridViewTextBoxColumn.Name = "sourceTextDataGridViewTextBoxColumn";
            this.sourceTextDataGridViewTextBoxColumn.Visible = false;
            this.sourceTextDataGridViewTextBoxColumn.Width = 250;
            // 
            // targetTextDataGridViewTextBoxColumn
            // 
            this.targetTextDataGridViewTextBoxColumn.DataPropertyName = "TargetText";
            this.targetTextDataGridViewTextBoxColumn.HeaderText = "Target";
            this.targetTextDataGridViewTextBoxColumn.Name = "targetTextDataGridViewTextBoxColumn";
            this.targetTextDataGridViewTextBoxColumn.Visible = false;
            this.targetTextDataGridViewTextBoxColumn.Width = 250;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 75;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle3.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 62;
            // 
            // severityDataGridViewTextBoxColumn
            // 
            this.severityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.severityDataGridViewTextBoxColumn.DataPropertyName = "Severity";
            this.severityDataGridViewTextBoxColumn.HeaderText = "Severity";
            this.severityDataGridViewTextBoxColumn.Name = "severityDataGridViewTextBoxColumn";
            this.severityDataGridViewTextBoxColumn.Width = 79;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.Width = 76;
            // 
            // commentEntryBindingSource
            // 
            this.commentEntryBindingSource.DataSource = typeof(Capybara.CommentView.Interfaces.CommentEntry);
            // 
            // mainTabControl
            // 
            this.rootTable.SetColumnSpan(this.mainTabControl, 2);
            this.mainTabControl.Controls.Add(this.commentsTab);
            this.mainTabControl.Controls.Add(this.filesTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(865, 332);
            this.mainTabControl.TabIndex = 1;
            // 
            // commentsTab
            // 
            this.commentsTab.Controls.Add(this.splitContainer1);
            this.commentsTab.Location = new System.Drawing.Point(4, 24);
            this.commentsTab.Margin = new System.Windows.Forms.Padding(0);
            this.commentsTab.Name = "commentsTab";
            this.commentsTab.Size = new System.Drawing.Size(857, 304);
            this.commentsTab.TabIndex = 0;
            this.commentsTab.Text = "Comments";
            this.commentsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.commentsDGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(857, 304);
            this.splitContainer1.SplitterDistance = 637;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sourceRTB);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.targetRTB);
            this.splitContainer2.Size = new System.Drawing.Size(215, 304);
            this.splitContainer2.SplitterDistance = 145;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // sourceRTB
            // 
            this.sourceRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sourceRTB.Location = new System.Drawing.Point(0, 0);
            this.sourceRTB.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.sourceRTB.Name = "sourceRTB";
            this.sourceRTB.ReadOnly = true;
            this.sourceRTB.Size = new System.Drawing.Size(215, 145);
            this.sourceRTB.TabIndex = 0;
            this.sourceRTB.Text = "";
            // 
            // targetRTB
            // 
            this.targetRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.targetRTB.Location = new System.Drawing.Point(0, 0);
            this.targetRTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.targetRTB.Name = "targetRTB";
            this.targetRTB.ReadOnly = true;
            this.targetRTB.Size = new System.Drawing.Size(215, 154);
            this.targetRTB.TabIndex = 0;
            this.targetRTB.Text = "";
            // 
            // filesTab
            // 
            this.filesTab.Controls.Add(this.filesDGV);
            this.filesTab.Location = new System.Drawing.Point(4, 24);
            this.filesTab.Margin = new System.Windows.Forms.Padding(0);
            this.filesTab.Name = "filesTab";
            this.filesTab.Size = new System.Drawing.Size(857, 304);
            this.filesTab.TabIndex = 1;
            this.filesTab.Text = "Files";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // filesDGV
            // 
            this.filesDGV.AllowUserToAddRows = false;
            this.filesDGV.AllowUserToDeleteRows = false;
            this.filesDGV.AllowUserToOrderColumns = true;
            this.filesDGV.AllowUserToResizeRows = false;
            this.filesDGV.AutoGenerateColumns = false;
            this.filesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.filesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentsCountColumn,
            this.fileNameColumn});
            this.filesDGV.DataSource = this.fileEntryBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.filesDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.filesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.filesDGV.Location = new System.Drawing.Point(0, 0);
            this.filesDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filesDGV.Name = "filesDGV";
            this.filesDGV.RowHeadersVisible = false;
            this.filesDGV.RowTemplate.Height = 21;
            this.filesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filesDGV.Size = new System.Drawing.Size(857, 304);
            this.filesDGV.TabIndex = 0;
            this.filesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filesDGV_CellDoubleClick);
            this.filesDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.filesDGV_CellFormatting);
            this.filesDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filesDGV_KeyDown);
            // 
            // CommentsCountColumn
            // 
            this.CommentsCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CommentsCountColumn.DataPropertyName = "CommentsCount";
            this.CommentsCountColumn.HeaderText = "Comments";
            this.CommentsCountColumn.Name = "CommentsCountColumn";
            this.CommentsCountColumn.ReadOnly = true;
            this.CommentsCountColumn.Width = 97;
            // 
            // fileNameColumn
            // 
            this.fileNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileNameColumn.DataPropertyName = "FileName";
            this.fileNameColumn.HeaderText = "File";
            this.fileNameColumn.Name = "fileNameColumn";
            this.fileNameColumn.ReadOnly = true;
            // 
            // fileEntryBindingSource
            // 
            this.fileEntryBindingSource.DataSource = typeof(Capybara.CommentView.Interfaces.ProjectFileEntry);
            // 
            // rootTable
            // 
            this.rootTable.ColumnCount = 2;
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.Controls.Add(this.mainTabControl, 0, 0);
            this.rootTable.Controls.Add(this.showExportFormButton, 0, 1);
            this.rootTable.Controls.Add(this.loadingProgressBar, 1, 1);
            this.rootTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTable.Location = new System.Drawing.Point(0, 0);
            this.rootTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rootTable.Name = "rootTable";
            this.rootTable.RowCount = 2;
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootTable.Size = new System.Drawing.Size(865, 363);
            this.rootTable.TabIndex = 2;
            // 
            // showExportFormButton
            // 
            this.showExportFormButton.AutoSize = true;
            this.showExportFormButton.Location = new System.Drawing.Point(0, 332);
            this.showExportFormButton.Margin = new System.Windows.Forms.Padding(0);
            this.showExportFormButton.Name = "showExportFormButton";
            this.showExportFormButton.Size = new System.Drawing.Size(131, 29);
            this.showExportFormButton.TabIndex = 2;
            this.showExportFormButton.Text = "Export Comments...";
            this.showExportFormButton.UseVisualStyleBackColor = true;
            this.showExportFormButton.Click += new System.EventHandler(this.showExportFormButton_Click);
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingProgressBar.Location = new System.Drawing.Point(131, 332);
            this.loadingProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.Size = new System.Drawing.Size(734, 31);
            this.loadingProgressBar.TabIndex = 3;
            // 
            // FilesCommentViewPartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rootTable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FilesCommentViewPartControl";
            this.Size = new System.Drawing.Size(865, 363);
            ((System.ComponentModel.ISupportInitialize)(this.commentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentEntryBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.commentsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.filesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileEntryBindingSource)).EndInit();
            this.rootTable.ResumeLayout(false);
            this.rootTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView commentsDGV;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage commentsTab;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.DataGridView filesDGV;
        private System.Windows.Forms.BindingSource fileEntryBindingSource;
        private System.Windows.Forms.BindingSource commentEntryBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox sourceRTB;
        private System.Windows.Forms.RichTextBox targetRTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel rootTable;
        private System.Windows.Forms.Button showExportFormButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paragraphIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn severityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentsCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameColumn;
        private System.Windows.Forms.ProgressBar loadingProgressBar;
    }
}
