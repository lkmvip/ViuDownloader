using CefSharp.WinForms;
using System.Drawing;
using System.Windows.Forms;
using ViuTVDownloader.Properties;

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
                StartPosition = FormStartPosition.WindowsDefaultLocation,
                AutoScaleMode = AutoScaleMode.Dpi,
                ImeMode = ImeMode.Off,
                ClientSize = new Size(1280, 720),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowIcon = false,
                Text = Resources.title
            };
            loginDialog.FormClosed += LoginDialog_FormClosed;
            loginDialog.Controls.Add(browser);
            loginDialog.Show();
        }

        private static void LoginDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            (sender as Form).Show();
        }
    }
}
