//
// This file manually written from cef/include/internal/cef_types_runtime.h.
// C API name: cef_runtime_style_t.
//
namespace Xilium.CefGlue
{
    /// <summary>
    /// Describes the runtime style for a browser or window.
    /// Use the default style to get Chrome style behavior with the Chrome toolbar,
    /// or Alloy style for windowless (off-screen) rendering support.
    /// </summary>
    public enum CefRuntimeStyle
    {
        /// <summary>
        /// Use the default style. See documentation for exceptions.
        /// </summary>
        Default,

        /// <summary>
        /// Use Chrome style.
        /// </summary>
        Chrome,

        /// <summary>
        /// Use Alloy style.
        /// </summary>
        Alloy,
    }
}
