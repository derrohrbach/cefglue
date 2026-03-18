using System;
using System.Windows.Forms;
using Xilium.CefGlue;

namespace Xilium.CefGlue.WindowsForms.Demo
{
    internal static class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            // Handle CEF sub-processes (renderer, gpu, etc.) before touching WinForms
            CefRuntime.Load();
            var mainArgs = new CefMainArgs(args);
            var app = new DemoCefApp();
            int exitCode = CefRuntime.ExecuteProcess(mainArgs, app, IntPtr.Zero);
            if (exitCode >= 0)
                return exitCode; // This is a sub-process, exit immediately

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settings = new CefSettings
            {
                MultiThreadedMessageLoop = true,
                LogSeverity = CefLogSeverity.Warning,
                NoSandbox = true,
                ResourcesDirPath = AppDomain.CurrentDomain.BaseDirectory,
            };

            CefRuntime.Initialize(mainArgs, settings, app, IntPtr.Zero);

            Application.Run(new MainForm());

            CefRuntime.Shutdown();
            return 0;
        }
    }

    internal sealed class DemoCefApp : CefApp
    {
        protected override void OnBeforeCommandLineProcessing(string processType, CefCommandLine commandLine)
        {
        }
    }
}
