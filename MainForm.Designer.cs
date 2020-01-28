namespace ImageConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderPeeker = new System.Windows.Forms.FolderBrowserDialog();
            this.lPath = new System.Windows.Forms.Label();
            this.btChangeFolder = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.cbFormats = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConvert = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.cbRewriteFiles = new System.Windows.Forms.CheckBox();
            this.cbIgnoreErrors = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lPath
            // 
            this.lPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lPath.Location = new System.Drawing.Point(13, 43);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(553, 35);
            this.lPath.TabIndex = 0;
            this.lPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btChangeFolder
            // 
            this.btChangeFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btChangeFolder.Location = new System.Drawing.Point(573, 43);
            this.btChangeFolder.Name = "btChangeFolder";
            this.btChangeFolder.Size = new System.Drawing.Size(189, 35);
            this.btChangeFolder.TabIndex = 1;
            this.btChangeFolder.Text = "Folder...";
            this.btChangeFolder.UseVisualStyleBackColor = true;
            this.btChangeFolder.Click += new System.EventHandler(this.btChangeFolder_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(13, 144);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(749, 23);
            this.pBar.TabIndex = 3;
            this.pBar.Visible = false;
            // 
            // cbFormats
            // 
            this.cbFormats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFormats.FormattingEnabled = true;
            this.cbFormats.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbFormats.Location = new System.Drawing.Point(478, 94);
            this.cbFormats.Name = "cbFormats";
            this.cbFormats.Size = new System.Drawing.Size(284, 28);
            this.cbFormats.TabIndex = 4;
            this.cbFormats.SelectionChangeCommitted += new System.EventHandler(this.cbFormats_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(370, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Convert to ...";
            // 
            // btConvert
            // 
            this.btConvert.Enabled = false;
            this.btConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btConvert.Location = new System.Drawing.Point(573, 188);
            this.btConvert.Name = "btConvert";
            this.btConvert.Size = new System.Drawing.Size(189, 47);
            this.btConvert.TabIndex = 6;
            this.btConvert.Text = "Convert";
            this.btConvert.UseVisualStyleBackColor = true;
            this.btConvert.Click += new System.EventHandler(this.btConvert_Click);
            // 
            // lStatus
            // 
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lStatus.Location = new System.Drawing.Point(12, 170);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(211, 29);
            this.lStatus.TabIndex = 7;
            this.lStatus.Visible = false;
            // 
            // cbRewriteFiles
            // 
            this.cbRewriteFiles.AutoSize = true;
            this.cbRewriteFiles.Checked = true;
            this.cbRewriteFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRewriteFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbRewriteFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbRewriteFiles.Location = new System.Drawing.Point(13, 81);
            this.cbRewriteFiles.Name = "cbRewriteFiles";
            this.cbRewriteFiles.Size = new System.Drawing.Size(262, 23);
            this.cbRewriteFiles.TabIndex = 8;
            this.cbRewriteFiles.Text = "Overwrite files with the same name";
            this.cbRewriteFiles.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreErrors
            // 
            this.cbIgnoreErrors.AutoSize = true;
            this.cbIgnoreErrors.Checked = true;
            this.cbIgnoreErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreErrors.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbIgnoreErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbIgnoreErrors.Location = new System.Drawing.Point(13, 110);
            this.cbIgnoreErrors.Name = "cbIgnoreErrors";
            this.cbIgnoreErrors.Size = new System.Drawing.Size(203, 23);
            this.cbIgnoreErrors.TabIndex = 9;
            this.cbIgnoreErrors.Text = "Ignore convertation errors";
            this.cbIgnoreErrors.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 246);
            this.Controls.Add(this.cbIgnoreErrors);
            this.Controls.Add(this.cbRewriteFiles);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.btConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFormats);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.btChangeFolder);
            this.Controls.Add(this.lPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Image Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderPeeker;
        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.Button btChangeFolder;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.ComboBox cbFormats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConvert;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.CheckBox cbRewriteFiles;
        private System.Windows.Forms.CheckBox cbIgnoreErrors;
    }
}

