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
    internal unsafe struct cef_x509cert_principal_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _get_display_name;
        internal IntPtr _get_common_name;
        internal IntPtr _get_locality_name;
        internal IntPtr _get_state_or_province_name;
        internal IntPtr _get_country_name;
        internal IntPtr _get_organization_names;
        internal IntPtr _get_organization_unit_names;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_x509cert_principal_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_x509cert_principal_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_x509cert_principal_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_at_least_one_ref_delegate(cef_x509cert_principal_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_display_name_delegate(cef_x509cert_principal_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_common_name_delegate(cef_x509cert_principal_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_locality_name_delegate(cef_x509cert_principal_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_state_or_province_name_delegate(cef_x509cert_principal_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_country_name_delegate(cef_x509cert_principal_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_organization_names_delegate(cef_x509cert_principal_t* self, cef_string_list* names);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_organization_unit_names_delegate(cef_x509cert_principal_t* self, cef_string_list* names);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_x509cert_principal_t* self)
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
        
        public static int release(cef_x509cert_principal_t* self)
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
        
        public static int has_one_ref(cef_x509cert_principal_t* self)
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
        
        public static int has_at_least_one_ref(cef_x509cert_principal_t* self)
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
        
        // GetDisplayName
        private static IntPtr _p4;
        private static get_display_name_delegate _d4;
        
        public static cef_string_userfree* get_display_name(cef_x509cert_principal_t* self)
        {
            get_display_name_delegate d;
            var p = self->_get_display_name;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (get_display_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_display_name_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // GetCommonName
        private static IntPtr _p5;
        private static get_common_name_delegate _d5;
        
        public static cef_string_userfree* get_common_name(cef_x509cert_principal_t* self)
        {
            get_common_name_delegate d;
            var p = self->_get_common_name;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (get_common_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_common_name_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // GetLocalityName
        private static IntPtr _p6;
        private static get_locality_name_delegate _d6;
        
        public static cef_string_userfree* get_locality_name(cef_x509cert_principal_t* self)
        {
            get_locality_name_delegate d;
            var p = self->_get_locality_name;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (get_locality_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_locality_name_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // GetStateOrProvinceName
        private static IntPtr _p7;
        private static get_state_or_province_name_delegate _d7;
        
        public static cef_string_userfree* get_state_or_province_name(cef_x509cert_principal_t* self)
        {
            get_state_or_province_name_delegate d;
            var p = self->_get_state_or_province_name;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (get_state_or_province_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_state_or_province_name_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // GetCountryName
        private static IntPtr _p8;
        private static get_country_name_delegate _d8;
        
        public static cef_string_userfree* get_country_name(cef_x509cert_principal_t* self)
        {
            get_country_name_delegate d;
            var p = self->_get_country_name;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (get_country_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_country_name_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
        // GetOrganizationNames
        private static IntPtr _p9;
        private static get_organization_names_delegate _d9;
        
        public static void get_organization_names(cef_x509cert_principal_t* self, cef_string_list* names)
        {
            get_organization_names_delegate d;
            var p = self->_get_organization_names;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (get_organization_names_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_organization_names_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            d(self, names);
        }
        
        // GetOrganizationUnitNames
        private static IntPtr _pa;
        private static get_organization_unit_names_delegate _da;
        
        public static void get_organization_unit_names(cef_x509cert_principal_t* self, cef_string_list* names)
        {
            get_organization_unit_names_delegate d;
            var p = self->_get_organization_unit_names;
            if (p == _pa) { d = _da; }
            else
            {
                d = (get_organization_unit_names_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_organization_unit_names_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            d(self, names);
        }
        
    }
}
