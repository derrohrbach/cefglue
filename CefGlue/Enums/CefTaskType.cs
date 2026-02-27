//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_task_type_t.
//
namespace Xilium.CefGlue
{
    /// <summary>
    /// Specifies the task type variants supported by CefTaskManager.
    /// Should be kept in sync with Chromium's task_manager::Task::Type type.
    /// </summary>
    public enum CefTaskType
    {
        Unknown,
        /// <summary>
        /// The main browser process.
        /// </summary>
        Browser,
        /// <summary>
        /// A graphics process.
        /// </summary>
        Gpu,
        /// <summary>
        /// A Linux zygote process.
        /// </summary>
        Zygote,
        /// <summary>
        /// A browser utility process.
        /// </summary>
        Utility,
        /// <summary>
        /// A renderer process.
        /// </summary>
        Renderer,
        /// <summary>
        /// An extension or app process.
        /// </summary>
        Extension,
        /// <summary>
        /// A guest process.
        /// </summary>
        Guest,
        /// <summary>
        /// A plugin process (deprecated).
        /// </summary>
        PluginDeprecated,
        /// <summary>
        /// A sandboxed helper process.
        /// </summary>
        SandboxHelper,
        /// <summary>
        /// A dedicated worker running on the renderer process.
        /// </summary>
        DedicatedWorker,
        /// <summary>
        /// A shared worker running on the renderer process.
        /// </summary>
        SharedWorker,
        /// <summary>
        /// A service worker running on the renderer process.
        /// </summary>
        ServiceWorker,

        NumValues,
    }
}
