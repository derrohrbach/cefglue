using System;
using System.Windows.Forms;
using Xilium.CefGlue;
using Xilium.CefGlue.WindowsForms;

namespace Xilium.CefGlue.WindowsForms.Demo
{
    public sealed class MainForm : Form
    {
        private readonly CefWebBrowser _browser;
        private readonly ToolStrip _toolbar;
        private readonly ToolStripTextBox _urlBox;

        public MainForm()
        {
            Text = "CefGlue.WindowsForms Demo";
            Width = 1200;
            Height = 800;

            // Toolbar
            _toolbar = new ToolStrip();
            _urlBox = new ToolStripTextBox { Width = 600, Text = "https://www.google.com" };
            _urlBox.KeyDown += UrlBox_KeyDown;

            var goButton = new ToolStripButton("Go") { DisplayStyle = ToolStripItemDisplayStyle.Text };
            goButton.Click += (s, e) => Navigate(_urlBox.Text);

            var devToolsButton = new ToolStripButton("DevTools") { DisplayStyle = ToolStripItemDisplayStyle.Text };
            devToolsButton.Click += DevToolsButton_Click;

            _toolbar.Items.Add(new ToolStripLabel("URL: "));
            _toolbar.Items.Add(_urlBox);
            _toolbar.Items.Add(goButton);
            _toolbar.Items.Add(new ToolStripSeparator());
            _toolbar.Items.Add(devToolsButton);

            // Browser control
            _browser = new CefWebBrowser
            {
                StartUrl = "https://www.google.com",
                Dock = DockStyle.Fill,
            };
            _browser.TitleChanged += (s, e) => Text = e.Title + " - CefGlue.WindowsForms Demo";
            _browser.AddressChanged += (s, e) => { if (_urlBox != null) _urlBox.Text = e.Address; };
            _browser.BrowserCreated += (s, e) => _toolbar.Enabled = true;
            _toolbar.Enabled = false;

            Controls.Add(_browser);
            Controls.Add(_toolbar);
        }

        private void UrlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(_urlBox.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void Navigate(string url)
        {
            if (_browser.Browser == null) return;
            if (!url.StartsWith("http://") && !url.StartsWith("https://") && !url.StartsWith("about:"))
                url = "https://" + url;
            _browser.Browser.GetMainFrame().LoadUrl(url);
        }

        private void DevToolsButton_Click(object sender, EventArgs e)
        {
            if (_browser.Browser == null) return;
            var host = _browser.Browser.GetHost();
            var wi = CefWindowInfo.Create();
            wi.SetAsPopup(IntPtr.Zero, "DevTools");
            host.ShowDevTools(wi, new DevToolsClient(), new CefBrowserSettings(), new CefPoint(0, 0));
        }

        // Minimal CefClient for DevTools - no handlers needed
        private sealed class DevToolsClient : CefClient { }
    }
}
