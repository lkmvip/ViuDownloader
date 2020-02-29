using CefSharp.WinForms;
using System.Drawing;
using System.Windows.Forms;
using ViuDownloader.Properties;

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
                Dock = DockStyle.Fill
            };

            loginDialog = new Form()
            {
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                StartPosition = FormStartPosition.WindowsDefaultLocation,
                AutoScaleMode = AutoScaleMode.Dpi,
                ImeMode = ImeMode.Off,
                ClientSize = new Size(1280, 720),
                ShowIcon = false,
                Text = Resources.title,
                TopMost = true
            };
            loginDialog.FormClosing += LoginDialog_FormClosing;
            loginDialog.Controls.Add(browser);
            loginDialog.Show();
        }

        private static void LoginDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
