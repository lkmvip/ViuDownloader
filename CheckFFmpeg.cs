using System;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Threading.Tasks;

namespace ViuDownloader
{
    class CheckFFmpeg
    {
        public static bool BinariesExists()
        {
            return File.Exists("ffmpeg.exe");
        }

        public static void UnzipDownloadedFile()
        {
            try
            {
                if(Directory.Exists("ffmpeg-latest-win64-static"))
                    Directory.Delete("ffmpeg-latest-win64-static", true);
                ZipFile.ExtractToDirectory("ffmpeg.zip", Environment.CurrentDirectory);
                File.Move("ffmpeg-latest-win64-static\\bin\\ffmpeg.exe", "ffmpeg.exe");
                Directory.Delete("ffmpeg-latest-win64-static", true);
                File.Delete("ffmpeg.zip");
            } 
            catch (Exception e)
            {
                ConsoleOutput.WriteLine($"Error unzipping file.\n{e.Message}");
            }
        }

        public static async Task<bool> UpdateBinary() // return whether the update has succeed.
        {
            if (File.Exists("ffmpeg.zip"))
            {
                UnzipDownloadedFile();
                return true;
            }

            var zipUrl = "https://ffmpeg.zeranoe.com/builds/win64/static/ffmpeg-latest-win64-static.zip";
            try
            {
                ConsoleOutput.WriteLine("FFmpeg binary not found!");
                ConsoleOutput.WriteLine($"Downloading 'ffmpeg.zip' from '{zipUrl}'");
                using (WebClient client = new WebClient())
                {
                    await client.DownloadFileTaskAsync(new Uri(zipUrl), $"ffmpeg.zip");
                    ConsoleOutput.WriteLine($"ffmpeg.zip downloaded successfully.");
                }
                UnzipDownloadedFile();
                ConsoleOutput.WriteLine($"ffmpeg.zip unzipped and deleted.");
                return true;
            }
            catch (Exception e)
            {
                ConsoleOutput.WriteLine($"Error Downloading ffmpeg.zip. Please download the it manually. Save the file as 'ffmpeg.zip' into this folder.\n{e.Message}");
            }
            return false;
        }
    }
}