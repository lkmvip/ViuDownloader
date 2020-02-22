using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViuDownloader
{
    public partial class Form1 : Form
    {
        public static Process ffmpegProcess = new Process();
        public static Thread downloadThread;
        public static bool downloading = false;

        public Form1()
        {
            CEFInit.InitCEF();
            InitializeComponent();
            ConsoleOutput.SetOut(ref consoleOutput);
        }

        private void FileDialogButton_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
                return;
            outDirTextBox.Text = folderBrowserDialog1.SelectedPath;

        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if(downloading)
            {
                downloadThread.Abort();
                (new Process { StartInfo = new ProcessStartInfo() { FileName = "taskkill.exe", Arguments = "/im ffmpeg.exe /F", CreateNoWindow = true, UseShellExecute = false }}).Start();
                ConsoleOutput.Clear();
                downloading = false;
            }

            downloadProgressBar.Value = 0;

            if(!CheckFFmpeg.BinariesExists())  // download ffmpeg binaryies if not avaliable
            {
                downloadBtn.Enabled = false;
                var update = new Action(async () => {
                    var success = await CheckFFmpeg.UpdateBinary();
                    if(success)
                        downloadBtn.Invoke(new Action(() => downloadBtn.Enabled = true));
                });
                new Thread(new ThreadStart(update)).Start();
                return;
            }

            if (outDirTextBox.Text == string.Empty)
                return;

            if (ResourceRequestHandlerExt.m3u8Url == null)
            {
                ConsoleOutput.WriteLine("Error finding the url of m3u8 file.");
                return;
            }

            if (ResourceRequestHandlerExt.subtitleUrl == null)
            {
                ConsoleOutput.WriteLine("Error finding the url of subtitle file.");
                return;
            }

            if (ResourceRequestHandlerExt.seriesName == null)
            {
                ConsoleOutput.WriteLine("Error finding the series name of this drama.");
                return;
            }

            if(Directory.CreateDirectory(outDirTextBox.Text = outDirTextBox.Text.Trim()) == null)
            {
                ConsoleOutput.WriteLine($"Failed to create directory '{outDirTextBox.Text}'.");
                return;
            }

            ConsoleOutput.WriteLine($"m3u8 URL: '{ResourceRequestHandlerExt.m3u8Url}'");
            ConsoleOutput.WriteLine($"Subtitle URL: '{ResourceRequestHandlerExt.subtitleUrl}'");
            ConsoleOutput.WriteLine($"File name: '{ResourceRequestHandlerExt.FileName}'");

            downloading = true;

            // Argument: ffmpeg -y -i [url] -c copy [outputDir].[fileType]"
            // -y skip prompt to overwrite any existence
            ffmpegProcess = new Process
            {
                StartInfo = new ProcessStartInfo("ffmpeg", $@"-y -i ""{ResourceRequestHandlerExt.m3u8Url}"" -c copy ""{outDirTextBox.Text}\\{ResourceRequestHandlerExt.FileName}.mp4""")
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            ConsoleOutput.WriteLine($@">>> ffmpeg -y -i ""{ResourceRequestHandlerExt.m3u8Url}"" -c copy ""{outDirTextBox.Text}\\{ResourceRequestHandlerExt.FileName}.mp4""");

            downloadThread = new Thread(new ThreadStart(() => 
            {
                ffmpegProcess.Start();
                ffmpegProcess.BeginErrorReadLine();
                ffmpegProcess.BeginOutputReadLine();
                ffmpegProcess.WaitForExit();
                downloadProgressBar.BeginInvoke(new Action(() => downloadProgressBar.Value = downloadProgressBar.Maximum));
                consoleOutput.BeginInvoke(new Action(() => ConsoleOutput.WriteLine($"ffmpeg.exe exited with ({ffmpegProcess.ExitCode})")));
                if(ffmpegProcess.ExitCode == 0)
                    consoleOutput.BeginInvoke(new Action(() => ConsoleOutput.WriteLine($"{ResourceRequestHandlerExt.FileName}.mp4 downloaded successfully")));
                downloading = false;
            }));
            ffmpegProcess.OutputDataReceived += FfmpegProcess_OutputDataReceived;
            ffmpegProcess.ErrorDataReceived += FfmpegProcess_ErrorDataReceived;
            downloadThread.Start();

            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(ResourceRequestHandlerExt.subtitleUrl, $"{outDirTextBox.Text}\\{ResourceRequestHandlerExt.FileName}.srt");
                    ConsoleOutput.WriteLine($"{outDirTextBox.Text}\\{ResourceRequestHandlerExt.FileName}.srt finished downloading");
                }
            } 
            catch
            {
                ConsoleOutput.WriteLine($"No subtitle found.");
            }
        }

        /* redirect shits to console */
        private void FfmpegProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            consoleOutput.BeginInvoke(new Action(() => ConsoleOutput.WriteLine(e.Data)));
            downloadProgressBar.BeginInvoke(new Action(() => downloadProgressBar.PerformStep()));
        }

        private void FfmpegProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            consoleOutput.BeginInvoke(new Action(() => ConsoleOutput.WriteLine(e.Data)));
            downloadProgressBar.BeginInvoke(new Action(() => downloadProgressBar.PerformStep()));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (downloading)
            {
                downloadThread.Abort();
                (new Process { StartInfo = new ProcessStartInfo() { FileName = "taskkill.exe", Arguments = "/im ffmpeg.exe /F", CreateNoWindow = true, UseShellExecute = false } }).Start();
            }
        }
    }
}
