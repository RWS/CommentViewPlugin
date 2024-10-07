namespace Capybara.CommentView
{
    partial class ExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.targetCheckBox = new System.Windows.Forms.CheckBox();
            this.sourceCheckBox = new System.Windows.Forms.CheckBox();
            this.versionCheckBox = new System.Windows.Forms.CheckBox();
            this.severityCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.authorCheckBox = new System.Windows.Forms.CheckBox();
            this.commentCheckBox = new System.Windows.Forms.CheckBox();
            this.segmentIDCheckBox = new System.Windows.Forms.CheckBox();
            this.fileCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.file2CheckBox = new System.Windows.Forms.CheckBox();
            this.commentsCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.exportOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportOptionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.targetCheckBox);
            this.groupBox1.Controls.Add(this.sourceCheckBox);
            this.groupBox1.Controls.Add(this.versionCheckBox);
            this.groupBox1.Controls.Add(this.severityCheckBox);
            this.groupBox1.Controls.Add(this.dateCheckBox);
            this.groupBox1.Controls.Add(this.authorCheckBox);
            this.groupBox1.Controls.Add(this.commentCheckBox);
            this.groupBox1.Controls.Add(this.segmentIDCheckBox);
            this.groupBox1.Controls.Add(this.fileCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Columns to Export (Comments Tab)";
            // 
            // targetCheckBox
            // 
            this.targetCheckBox.AutoSize = true;
            this.targetCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "Target", true));
            this.targetCheckBox.Location = new System.Drawing.Point(236, 69);
            this.targetCheckBox.Name = "targetCheckBox";
            this.targetCheckBox.Size = new System.Drawing.Size(59, 19);
            this.targetCheckBox.TabIndex = 0;
            this.targetCheckBox.Text = "Target";
            this.targetCheckBox.UseVisualStyleBackColor = true;
            // 
            // sourceCheckBox
            // 
            this.sourceCheckBox.AutoSize = true;
            this.sourceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "Source", true));
            this.sourceCheckBox.Location = new System.Drawing.Point(108, 69);
            this.sourceCheckBox.Name = "sourceCheckBox";
            this.sourceCheckBox.Size = new System.Drawing.Size(62, 19);
            this.sourceCheckBox.TabIndex = 0;
            this.sourceCheckBox.Text = "Source";
            this.sourceCheckBox.UseVisualStyleBackColor = true;
            // 
            // versionCheckBox
            // 
            this.versionCheckBox.AutoSize = true;
            this.versionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "Version", true));
            this.versionCheckBox.Location = new System.Drawing.Point(31, 69);
            this.versionCheckBox.Name = "versionCheckBox";
            this.versionCheckBox.Size = new System.Drawing.Size(64, 19);
            this.versionCheckBox.TabIndex = 0;
            this.versionCheckBox.Text = "Version";
            this.versionCheckBox.UseVisualStyleBackColor = true;
            // 
            // severityCheckBox
            // 
            this.severityCheckBox.AutoSize = true;
            this.severityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "Severity", true));
            this.severityCheckBox.Location = new System.Drawing.Point(532, 33);
            this.severityCheckBox.Name = "severityCheckBox";
            this.severityCheckBox.Size = new System.Drawing.Size(67, 19);
            this.severityCheckBox.TabIndex = 0;
            this.severityCheckBox.Text = "Severity";
            this.severityCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "Date", true));
            this.dateCheckBox.Location = new System.Drawing.Point(447, 33);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(50, 19);
            this.dateCheckBox.TabIndex = 0;
            this.dateCheckBox.Text = "Date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // authorCheckBox
            // 
            this.authorCheckBox.AutoSize = true;
            this.authorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "Author", true));
            this.authorCheckBox.Location = new System.Drawing.Point(351, 33);
            this.authorCheckBox.Name = "authorCheckBox";
            this.authorCheckBox.Size = new System.Drawing.Size(63, 19);
            this.authorCheckBox.TabIndex = 0;
            this.authorCheckBox.Text = "Author";
            this.authorCheckBox.UseVisualStyleBackColor = true;
            // 
            // commentCheckBox
            // 
            this.commentCheckBox.AutoSize = true;
            this.commentCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "Comment", true));
            this.commentCheckBox.Location = new System.Drawing.Point(236, 33);
            this.commentCheckBox.Name = "commentCheckBox";
            this.commentCheckBox.Size = new System.Drawing.Size(80, 19);
            this.commentCheckBox.TabIndex = 0;
            this.commentCheckBox.Text = "Comment";
            this.commentCheckBox.UseVisualStyleBackColor = true;
            // 
            // segmentIDCheckBox
            // 
            this.segmentIDCheckBox.AutoSize = true;
            this.segmentIDCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "SegmentId", true));
            this.segmentIDCheckBox.Location = new System.Drawing.Point(108, 33);
            this.segmentIDCheckBox.Name = "segmentIDCheckBox";
            this.segmentIDCheckBox.Size = new System.Drawing.Size(87, 19);
            this.segmentIDCheckBox.TabIndex = 0;
            this.segmentIDCheckBox.Text = "Segment ID";
            this.segmentIDCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileCheckBox
            // 
            this.fileCheckBox.AutoSize = true;
            this.fileCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "File", true));
            this.fileCheckBox.Location = new System.Drawing.Point(31, 33);
            this.fileCheckBox.Name = "fileCheckBox";
            this.fileCheckBox.Size = new System.Drawing.Size(44, 19);
            this.fileCheckBox.TabIndex = 0;
            this.fileCheckBox.Text = "File";
            this.fileCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.file2CheckBox);
            this.groupBox2.Controls.Add(this.commentsCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns to Export (Files Tab)";
            // 
            // file2CheckBox
            // 
            this.file2CheckBox.AutoSize = true;
            this.file2CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "File2", true));
            this.file2CheckBox.Location = new System.Drawing.Point(159, 31);
            this.file2CheckBox.Name = "file2CheckBox";
            this.file2CheckBox.Size = new System.Drawing.Size(44, 19);
            this.file2CheckBox.TabIndex = 1;
            this.file2CheckBox.Text = "File";
            this.file2CheckBox.UseVisualStyleBackColor = true;
            // 
            // commentsCheckBox
            // 
            this.commentsCheckBox.AutoSize = true;
            this.commentsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.exportOptionsBindingSource, "Comments", true));
            this.commentsCheckBox.Location = new System.Drawing.Point(31, 31);
            this.commentsCheckBox.Name = "commentsCheckBox";
            this.commentsCheckBox.Size = new System.Drawing.Size(85, 19);
            this.commentsCheckBox.TabIndex = 0;
            this.commentsCheckBox.Text = "Comments";
            this.commentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 231);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.exportButton.Location = new System.Drawing.Point(577, 231);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // exportOptionsBindingSource
            // 
            this.exportOptionsBindingSource.DataSource = typeof(Capybara.CommentView.Interfaces.ExportOptions);
            // 
            // ExportForm
            // 
            this.AcceptButton = this.exportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(664, 272);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportOptionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox targetCheckBox;
        private System.Windows.Forms.CheckBox sourceCheckBox;
        private System.Windows.Forms.CheckBox versionCheckBox;
        private System.Windows.Forms.CheckBox severityCheckBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.CheckBox authorCheckBox;
        private System.Windows.Forms.CheckBox commentCheckBox;
        private System.Windows.Forms.CheckBox segmentIDCheckBox;
        private System.Windows.Forms.CheckBox fileCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox file2CheckBox;
        private System.Windows.Forms.CheckBox commentsCheckBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.BindingSource exportOptionsBindingSource;
    }
}