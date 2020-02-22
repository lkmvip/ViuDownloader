using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ViuDownloader
{
    class CEFInit
    {
        public static ChromiumWebBrowser browser;
        private static Form loginDialog;

        public static void InitCEF()
        {

            browser = new ChromiumWebBrowser("https://www.viu.com/")
            {
                RequestHandler = new MyRequestHandler(),
            };

            loginDialog = new Form()
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                AutoScaleMode = AutoScaleMode.Dpi,
                ImeMode = ImeMode.Off,
                ClientSize = new Size(1280, 720),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowIcon = false,
                Text = "Viu"
            };
            loginDialog.Controls.Add(browser);
            loginDialog.Show();
        }
    }
}
