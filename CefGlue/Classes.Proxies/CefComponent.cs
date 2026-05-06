namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// Class representing a snapshot of a component's state at the time of
    /// retrieval. To get updated information, retrieve a new CefComponent object
    /// via CefComponentUpdater::GetComponentByID or GetComponents. The methods of
    /// this class may be called on any thread.
    /// </summary>
    public sealed unsafe partial class CefComponent
    {
        /// <summary>
        /// Returns the unique identifier for this component.
        /// </summary>
        public string Id
        {
            get
            {
                var n_result = cef_component_t.get_id(_self);
                return cef_string_userfree.ToString(n_result);
            }
        }

        /// <summary>
        /// Returns the human-readable name of this component.
        /// Returns an empty string if the component is not installed.
        /// </summary>
        public string Name
        {
            get
            {
                var n_result = cef_component_t.get_name(_self);
                return cef_string_userfree.ToString(n_result);
            }
        }

        /// <summary>
        /// Returns the version of this component as a string (e.g., "1.2.3.4").
        /// Returns an empty string if the component is not installed.
        /// </summary>
        public string Version
        {
            get
            {
                var n_result = cef_component_t.get_version(_self);
                return cef_string_userfree.ToString(n_result);
            }
        }

        /// <summary>
        /// Returns the state of this component at the time this object was created.
        /// </summary>
        public CefComponentState State => cef_component_t.get_state(_self);
    }
}
