namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// Callback interface for component update results.
    /// </summary>
    public abstract unsafe partial class CefComponentUpdateCallback
    {
        private void on_complete(cef_component_update_callback_t* self, cef_string_t* component_id, CefComponentUpdateError error)
        {
            CheckSelf(self);

            var m_componentId = cef_string_t.ToString(component_id);
            OnComplete(m_componentId, error);
        }

        /// <summary>
        /// Called when the component update operation completes.
        /// <paramref name="componentId"/> is the ID of the component that was updated.
        /// <paramref name="error"/> contains the result of the operation.
        /// </summary>
        protected abstract void OnComplete(string componentId, CefComponentUpdateError error);
    }
}
