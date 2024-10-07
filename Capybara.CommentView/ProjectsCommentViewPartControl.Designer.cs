namespace Capybara.CommentView
{
    partial class ProjectsCommentViewPartControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.projectsDGV = new System.Windows.Forms.DataGridView();
            this.projectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetLanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetLanguageCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetLanguageBasedProjectEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rootTable = new System.Windows.Forms.TableLayoutPanel();
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetLanguageBasedProjectEntryBindingSource)).BeginInit();
            this.rootTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectsDGV
            // 
            this.projectsDGV.AllowUserToAddRows = false;
            this.projectsDGV.AllowUserToDeleteRows = false;
            this.projectsDGV.AutoGenerateColumns = false;
            this.projectsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.projectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectColumn,
            this.projectNameColumn,
            this.targetLanguageColumn,
            this.targetLanguageCodeColumn,
            this.commentsCountColumn});
            this.projectsDGV.DataSource = this.targetLanguageBasedProjectEntryBindingSource;
            this.projectsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsDGV.Location = new System.Drawing.Point(3, 3);
            this.projectsDGV.Name = "projectsDGV";
            this.projectsDGV.RowTemplate.Height = 21;
            this.projectsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectsDGV.Size = new System.Drawing.Size(911, 291);
            this.projectsDGV.TabIndex = 0;
            this.projectsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsDGV_CellDoubleClick);
            this.projectsDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.projectsDGV_CellFormatting);
            this.projectsDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.projectsDGV_KeyDown);
            // 
            // projectColumn
            // 
            this.projectColumn.DataPropertyName = "Project";
            this.projectColumn.HeaderText = "Project";
            this.projectColumn.Name = "projectColumn";
            this.projectColumn.ReadOnly = true;
            this.projectColumn.Visible = false;
            // 
            // projectNameColumn
            // 
            this.projectNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projectNameColumn.DataPropertyName = "ProjectName";
            this.projectNameColumn.HeaderText = "Name";
            this.projectNameColumn.Name = "projectNameColumn";
            this.projectNameColumn.ReadOnly = true;
            // 
            // targetLanguageColumn
            // 
            this.targetLanguageColumn.DataPropertyName = "TargetLanguage";
            this.targetLanguageColumn.HeaderText = "TargetLanguage";
            this.targetLanguageColumn.Name = "targetLanguageColumn";
            this.targetLanguageColumn.ReadOnly = true;
            this.targetLanguageColumn.Visible = false;
            // 
            // targetLanguageCodeColumn
            // 
            this.targetLanguageCodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.targetLanguageCodeColumn.DataPropertyName = "TargetLanguageCode";
            this.targetLanguageCodeColumn.HeaderText = "Target Language";
            this.targetLanguageCodeColumn.Name = "targetLanguageCodeColumn";
            this.targetLanguageCodeColumn.ReadOnly = true;
            this.targetLanguageCodeColumn.Width = 109;
            // 
            // commentsCountColumn
            // 
            this.commentsCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.commentsCountColumn.DataPropertyName = "CommentsCount";
            this.commentsCountColumn.HeaderText = "Comments";
            this.commentsCountColumn.Name = "commentsCountColumn";
            this.commentsCountColumn.ReadOnly = true;
            this.commentsCountColumn.Width = 91;
            // 
            // targetLanguageBasedProjectEntryBindingSource
            // 
            this.targetLanguageBasedProjectEntryBindingSource.DataSource = typeof(Capybara.CommentView.Interfaces.TargetLanguageBasedProjectEntry);
            // 
            // rootTable
            // 
            this.rootTable.ColumnCount = 1;
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.Controls.Add(this.projectsDGV, 0, 0);
            this.rootTable.Controls.Add(this.loadingProgressBar, 0, 1);
            this.rootTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTable.Location = new System.Drawing.Point(0, 0);
            this.rootTable.Name = "rootTable";
            this.rootTable.RowCount = 2;
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rootTable.Size = new System.Drawing.Size(917, 320);
            this.rootTable.TabIndex = 1;
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingProgressBar.Location = new System.Drawing.Point(0, 297);
            this.loadingProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.Size = new System.Drawing.Size(917, 23);
            this.loadingProgressBar.TabIndex = 1;
            // 
            // ProjectsCommentViewPartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rootTable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProjectsCommentViewPartControl";
            this.Size = new System.Drawing.Size(917, 320);
            ((System.ComponentModel.ISupportInitialize)(this.projectsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetLanguageBasedProjectEntryBindingSource)).EndInit();
            this.rootTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projectsDGV;
        private System.Windows.Forms.TableLayoutPanel rootTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetLanguageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetLanguageCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsCountColumn;
        private System.Windows.Forms.BindingSource targetLanguageBasedProjectEntryBindingSource;
        private System.Windows.Forms.ProgressBar loadingProgressBar;
    }
}
