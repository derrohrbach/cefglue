//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_resource_bundle_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _get_localized_string;
        internal IntPtr _get_data_resource;
        internal IntPtr _get_data_resource_for_scale;
        
        // GetGlobal
        [DllImport(libcef.DllName, EntryPoint = "cef_resource_bundle_get_global", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_resource_bundle_t* get_global();
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_resource_bundle_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_resource_bundle_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_resource_bundle_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_at_least_one_ref_delegate(cef_resource_bundle_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_localized_string_delegate(cef_resource_bundle_t* self, int string_id);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_binary_value_t* get_data_resource_delegate(cef_resource_bundle_t* self, int resource_id);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_binary_value_t* get_data_resource_for_scale_delegate(cef_resource_bundle_t* self, int resource_id, CefScaleFactor scale_factor);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_resource_bundle_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_resource_bundle_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_resource_bundle_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // HasAtLeastOneRef
        private static IntPtr _p3;
        private static has_at_least_one_ref_delegate _d3;
        
        public static int has_at_least_one_ref(cef_resource_bundle_t* self)
        {
            has_at_least_one_ref_delegate d;
            var p = self->_base._has_at_least_one_ref;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (has_at_least_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_at_least_one_ref_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // GetLocalizedString
        private static IntPtr _p4;
        private static get_localized_string_delegate _d4;
        
        public static cef_string_userfree* get_localized_string(cef_resource_bundle_t* self, int string_id)
        {
            get_localized_string_delegate d;
            var p = self->_get_localized_string;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (get_localized_string_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_localized_string_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self, string_id);
        }
        
        // GetDataResource
        private static IntPtr _p5;
        private static get_data_resource_delegate _d5;
        
        public static cef_binary_value_t* get_data_resource(cef_resource_bundle_t* self, int resource_id)
        {
            get_data_resource_delegate d;
            var p = self->_get_data_resource;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (get_data_resource_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_data_resource_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self, resource_id);
        }
        
        // GetDataResourceForScale
        private static IntPtr _p6;
        private static get_data_resource_for_scale_delegate _d6;
        
        public static cef_binary_value_t* get_data_resource_for_scale(cef_resource_bundle_t* self, int resource_id, CefScaleFactor scale_factor)
        {
            get_data_resource_for_scale_delegate d;
            var p = self->_get_data_resource_for_scale;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (get_data_resource_for_scale_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_data_resource_for_scale_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self, resource_id, scale_factor);
        }
        
    }
}
