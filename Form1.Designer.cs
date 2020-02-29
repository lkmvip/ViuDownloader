namespace ViuDownloader
{
    partial class MainWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.outDirTextBox = new System.Windows.Forms.TextBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.fileDialogButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.radioFHD = new System.Windows.Forms.RadioButton();
            this.radioHD = new System.Windows.Forms.RadioButton();
            this.radioSD = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioShitQuality = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save to:";
            // 
            // outDirTextBox
            // 
            this.outDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outDirTextBox.BackColor = System.Drawing.Color.White;
            this.outDirTextBox.Location = new System.Drawing.Point(117, 13);
            this.outDirTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.outDirTextBox.Name = "outDirTextBox";
            this.outDirTextBox.ReadOnly = true;
            this.outDirTextBox.Size = new System.Drawing.Size(899, 31);
            this.outDirTextBox.TabIndex = 0;
            this.outDirTextBox.TabStop = false;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBtn.BackColor = System.Drawing.Color.White;
            this.downloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.downloadBtn.FlatAppearance.BorderSize = 0;
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBtn.Image = global::ViuDownloader.Properties.Resources.download_icon;
            this.downloadBtn.Location = new System.Drawing.Point(1080, 6);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(5);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(186, 148);
            this.downloadBtn.TabIndex = 0;
            this.downloadBtn.TabStop = false;
            this.downloadBtn.Text = "s";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadProgressBar.BackColor = System.Drawing.Color.White;
            this.downloadProgressBar.ForeColor = System.Drawing.Color.YellowGreen;
            this.downloadProgressBar.Location = new System.Drawing.Point(18, 211);
            this.downloadProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.downloadProgressBar.Maximum = 600;
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(1248, 36);
            this.downloadProgressBar.Step = 1;
            this.downloadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.downloadProgressBar.TabIndex = 0;
            // 
            // consoleOutput
            // 
            this.consoleOutput.BackColor = System.Drawing.Color.Black;
            this.consoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consoleOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleOutput.ForeColor = System.Drawing.Color.Lime;
            this.consoleOutput.HideSelection = false;
            this.consoleOutput.Location = new System.Drawing.Point(0, 257);
            this.consoleOutput.Margin = new System.Windows.Forms.Padding(5);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleOutput.Size = new System.Drawing.Size(1280, 463);
            this.consoleOutput.TabIndex = 0;
            this.consoleOutput.TabStop = false;
            this.consoleOutput.Text = "";
            // 
            // fileDialogButton
            // 
            this.fileDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileDialogButton.Location = new System.Drawing.Point(1026, 6);
            this.fileDialogButton.Margin = new System.Windows.Forms.Padding(5);
            this.fileDialogButton.Name = "fileDialogButton";
            this.fileDialogButton.Size = new System.Drawing.Size(44, 44);
            this.fileDialogButton.TabIndex = 0;
            this.fileDialogButton.TabStop = false;
            this.fileDialogButton.Text = "...";
            this.fileDialogButton.UseVisualStyleBackColor = true;
            this.fileDialogButton.Click += new System.EventHandler(this.FileDialogButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\wongy\\Videos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quality:";
            // 
            // radioFHD
            // 
            this.radioFHD.AutoSize = true;
            this.radioFHD.Checked = true;
            this.radioFHD.Location = new System.Drawing.Point(101, 121);
            this.radioFHD.Name = "radioFHD";
            this.radioFHD.Size = new System.Drawing.Size(84, 29);
            this.radioFHD.TabIndex = 0;
            this.radioFHD.TabStop = true;
            this.radioFHD.Text = "1080p";
            this.radioFHD.UseVisualStyleBackColor = true;
            // 
            // radioHD
            // 
            this.radioHD.AutoSize = true;
            this.radioHD.Location = new System.Drawing.Point(191, 121);
            this.radioHD.Name = "radioHD";
            this.radioHD.Size = new System.Drawing.Size(74, 29);
            this.radioHD.TabIndex = 0;
            this.radioHD.Text = "720p";
            this.radioHD.UseVisualStyleBackColor = true;
            // 
            // radioSD
            // 
            this.radioSD.AutoSize = true;
            this.radioSD.Location = new System.Drawing.Point(271, 121);
            this.radioSD.Name = "radioSD";
            this.radioSD.Size = new System.Drawing.Size(74, 29);
            this.radioSD.TabIndex = 0;
            this.radioSD.Text = "480p";
            this.radioSD.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(117, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(899, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "{SERIES_TITLE} 第{EPISODE_NUM}集 - {EPISODE_TITLE}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "FIle name:";
            // 
            // radioShitQuality
            // 
            this.radioShitQuality.AutoSize = true;
            this.radioShitQuality.Location = new System.Drawing.Point(351, 121);
            this.radioShitQuality.Name = "radioShitQuality";
            this.radioShitQuality.Size = new System.Drawing.Size(74, 29);
            this.radioShitQuality.TabIndex = 6;
            this.radioShitQuality.Text = "280p";
            this.radioShitQuality.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.radioShitQuality);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioSD);
            this.Controls.Add(this.radioHD);
            this.Controls.Add(this.radioFHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileDialogButton);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.outDirTextBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Viu Downloader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outDirTextBox;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.Button fileDialogButton;
        public System.Windows.Forms.RichTextBox consoleOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioFHD;
        private System.Windows.Forms.RadioButton radioHD;
        private System.Windows.Forms.RadioButton radioSD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioShitQuality;
    }
}

