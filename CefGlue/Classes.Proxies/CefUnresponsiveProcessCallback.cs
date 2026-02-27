namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// Callback class for asynchronous handling of an unresponsive process.
    /// </summary>
    public sealed unsafe partial class CefUnresponsiveProcessCallback
    {
        /// <summary>
        /// Reset the timeout for the unresponsive process.
        /// </summary>
        public void Wait()
        {
            cef_unresponsive_process_callback_t.wait(_self);
        }

        /// <summary>
        /// Terminate the unresponsive process.
        /// </summary>
        public void Terminate()
        {
            cef_unresponsive_process_callback_t.terminate(_self);
        }
    }
}
