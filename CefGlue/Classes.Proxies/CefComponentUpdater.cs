namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// This class provides access to Chromium's component updater service, allowing
    /// clients to discover registered components and trigger on-demand updates. The
    /// methods of this class may only be called on the browser process UI thread.
    /// If the CEF context is not initialized or the component updater service is
    /// not available, methods will return safe defaults (0, nullptr, or empty).
    /// </summary>
    public sealed unsafe partial class CefComponentUpdater
    {
        /// <summary>
        /// Returns the global CefComponentUpdater singleton. Returns null if
        /// called from the incorrect thread.
        /// </summary>
        public static CefComponentUpdater GetGlobal()
        {
            return FromNativeOrNull(cef_component_updater_t.get());
        }

        /// <summary>
        /// Returns the number of registered components, or 0 if the service is not
        /// available.
        /// </summary>
        public int GetComponentCount()
        {
            return (int)cef_component_updater_t.get_component_count(_self);
        }

        /// <summary>
        /// Returns all registered components.
        /// </summary>
        public CefComponent[] GetComponents()
        {
            var count = cef_component_updater_t.get_component_count(_self);
            if (count == UIntPtr.Zero) return new CefComponent[0];

            var n_count = count;
            var ptrArray = new IntPtr[(int)count];
            fixed (IntPtr* ptr = ptrArray)
            {
                cef_component_updater_t.get_components(_self, &n_count, (cef_component_t**)ptr);
            }

            var result = new CefComponent[(int)n_count];
            for (var i = 0; i < (int)n_count; i++)
            {
                result[i] = CefComponent.FromNative((cef_component_t*)ptrArray[i]);
            }
            return result;
        }

        /// <summary>
        /// Returns the component with the specified <paramref name="componentId"/>,
        /// or null if not found or the service is not available.
        /// </summary>
        public CefComponent GetComponentById(string componentId)
        {
            fixed (char* componentId_str = componentId)
            {
                var n_componentId = new cef_string_t(componentId_str, componentId.Length);
                return CefComponent.FromNativeOrNull(cef_component_updater_t.get_component_by_id(_self, &n_componentId));
            }
        }

        /// <summary>
        /// Triggers an on-demand update for the component with the specified
        /// <paramref name="componentId"/>. <paramref name="priority"/> specifies
        /// whether the update should be processed in the background or foreground.
        /// <paramref name="callback"/> may be null if no notification is needed.
        /// </summary>
        public void Update(string componentId, CefComponentUpdatePriority priority, CefComponentUpdateCallback callback)
        {
            fixed (char* componentId_str = componentId)
            {
                var n_componentId = new cef_string_t(componentId_str, componentId.Length);
                cef_component_updater_t.update(_self, &n_componentId, priority, callback != null ? callback.ToNative() : null);
            }
        }
    }
}
