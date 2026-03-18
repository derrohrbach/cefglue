namespace Xilium.CefGlue.WindowsForms
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Text;

    internal sealed class CefWebLifeSpanHandler : CefLifeSpanHandler
    {
        private readonly CefWebBrowser _core;

        public CefWebLifeSpanHandler(CefWebBrowser core)
        {
            _core = core;
        }

        protected override void OnAfterCreated(CefBrowser browser)
        {
            base.OnAfterCreated(browser);

            // Only handle the initial browser creation. DevTools popups (Chrome
            // style) reuse the source browser's client/handlers, so OnAfterCreated
            // fires again for the DevTools browser. We must not overwrite _browser
            // and _browserWindowHandle, otherwise OnResize will target the wrong
            // window and the main browser stops resizing.
            if (_core.Browser == null)
            {
                _core.InvokeIfRequired(() => _core.OnBrowserAfterCreated(browser));
            }
        }

        protected override bool DoClose(CefBrowser browser)
        {
            // Ignore DevTools browser close
            if (!IsMainBrowser(browser))
                return false;

            // TODO: ... dispose core
            return false;
        }

        protected override void OnBeforeClose(CefBrowser browser)
        {
            // Ignore DevTools browser close - must not clear _browserWindowHandle
            if (!IsMainBrowser(browser))
                return;

            if (_core.InvokeRequired)
                _core.BeginInvoke((Action)_core.OnBeforeClose);
            else
                _core.OnBeforeClose();
        }

        private bool IsMainBrowser(CefBrowser browser)
        {
            var coreBrowser = _core.Browser;
            return coreBrowser != null && browser.IsSame(coreBrowser);
        }

        protected override bool OnBeforePopup(CefBrowser browser, CefFrame frame, int popupId, string targetUrl, string targetFrameName, CefWindowOpenDisposition targetDisposition, bool userGesture, CefPopupFeatures popupFeatures, CefWindowInfo windowInfo, ref CefClient client, CefBrowserSettings settings, ref CefDictionaryValue extraInfo, ref bool noJavascriptAccess)
        {
            var e = new BeforePopupEventArgs(frame, targetUrl, targetFrameName, popupFeatures, windowInfo, client, settings,
                                 noJavascriptAccess);

            // Must call directly on CEF thread - cannot use Invoke (deadlock)
            // or BeginInvoke (need synchronous return values).
            _core.OnBeforePopup(e);

            client = e.Client;
            noJavascriptAccess = e.NoJavascriptAccess;

            return e.Handled;
        }
    }
}
