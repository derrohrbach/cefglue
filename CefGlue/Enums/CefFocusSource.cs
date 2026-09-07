//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_focus_source_t.
//
namespace Xilium.CefGlue
{
    using System;

    /// <summary>
    /// Focus sources.
    /// </summary>
    public enum CefFocusSource
    {
        /// <summary>
        /// The source is explicit navigation via the API (LoadURL(), etc).
        /// </summary>
        Navigation = 0,

        /// <summary>
        /// The source is a system-generated focus event.
        /// </summary>
        System,
    }
}
