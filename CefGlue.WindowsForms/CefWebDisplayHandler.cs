namespace Xilium.CefGlue.WindowsForms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    internal sealed class CefWebDisplayHandler : CefDisplayHandler
    {
        private readonly CefWebBrowser _core;

        public CefWebDisplayHandler(CefWebBrowser core)
        {
            _core = core;
        }

        private bool IsMainBrowser(CefBrowser browser)
        {
            var coreBrowser = _core.Browser;
            return coreBrowser != null && browser.IsSame(coreBrowser);
        }

        protected override void  OnTitleChange(CefBrowser browser, string title)
        {
            if (!IsMainBrowser(browser)) return;
            _core.InvokeIfRequired(() => _core.OnTitleChanged(new TitleChangedEventArgs(title)));
        }

        protected override void OnAddressChange(CefBrowser browser, CefFrame frame, string url)
        {
            if (!IsMainBrowser(browser)) return;
            if (frame.IsMain)
            {
               _core.InvokeIfRequired(() => _core.OnAddressChanged(new AddressChangedEventArgs(frame, url)));
            }
        }

        protected override void OnStatusMessage(CefBrowser browser, string value)
        {
            if (!IsMainBrowser(browser)) return;
            _core.InvokeIfRequired(() => _core.OnStatusMessage(new StatusMessageEventArgs(value)));
        }

		protected override bool OnConsoleMessage(CefBrowser browser, CefLogSeverity level, string message, string source, int line)
		{
			if (!IsMainBrowser(browser)) return false;
			var e = new ConsoleMessageEventArgs(level, message, source, line);
			_core.InvokeIfRequired(() => _core.OnConsoleMessage(e));

			return e.Handled;
		}

		protected override bool OnTooltip(CefBrowser browser, string text)
		{
			if (!IsMainBrowser(browser)) return false;
			var e = new TooltipEventArgs(text);
			_core.InvokeIfRequired(()=> _core.OnTooltip(e));
			return e.Handled;
		}
    }
}
