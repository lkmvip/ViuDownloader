namespace ViuDownloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.outDirTextBox = new System.Windows.Forms.TextBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.fileDialogButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            this.outDirTextBox.Location = new System.Drawing.Point(101, 16);
            this.outDirTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.outDirTextBox.Name = "outDirTextBox";
            this.outDirTextBox.ReadOnly = true;
            this.outDirTextBox.Size = new System.Drawing.Size(1197, 31);
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
            this.downloadBtn.Image = ((System.Drawing.Image)(resources.GetObject("downloadBtn.Image")));
            this.downloadBtn.Location = new System.Drawing.Point(1362, 6);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(5);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(184, 151);
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
            this.downloadProgressBar.Location = new System.Drawing.Point(18, 167);
            this.downloadProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.downloadProgressBar.Maximum = 600;
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(1530, 36);
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
            this.consoleOutput.Location = new System.Drawing.Point(0, 213);
            this.consoleOutput.Margin = new System.Windows.Forms.Padding(5);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleOutput.Size = new System.Drawing.Size(1562, 463);
            this.consoleOutput.TabIndex = 0;
            this.consoleOutput.TabStop = false;
            this.consoleOutput.Text = "";
            // 
            // fileDialogButton
            // 
            this.fileDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileDialogButton.Location = new System.Drawing.Point(1308, 6);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1562, 676);
            this.Controls.Add(this.fileDialogButton);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.outDirTextBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Viu Downloader";
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
    }
}

