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
    internal unsafe struct cef_extension_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_extension_load_failed;
        internal IntPtr _on_extension_loaded;
        internal IntPtr _on_extension_unloaded;
        internal IntPtr _on_before_background_browser;
        internal IntPtr _on_before_browser;
        internal IntPtr _get_active_browser;
        internal IntPtr _can_access_browser;
        internal IntPtr _get_extension_resource;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_extension_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_extension_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_extension_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_extension_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_extension_load_failed_delegate(cef_extension_handler_t* self, CefErrorCode result);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_extension_loaded_delegate(cef_extension_handler_t* self, cef_extension_t* extension);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_extension_unloaded_delegate(cef_extension_handler_t* self, cef_extension_t* extension);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_before_background_browser_delegate(cef_extension_handler_t* self, cef_extension_t* extension, cef_string_t* url, cef_client_t** client, cef_browser_settings_t* settings);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_before_browser_delegate(cef_extension_handler_t* self, cef_extension_t* extension, cef_browser_t* browser, cef_browser_t* active_browser, int index, cef_string_t* url, int active, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_browser_t* get_active_browser_delegate(cef_extension_handler_t* self, cef_extension_t* extension, cef_browser_t* browser, int include_incognito);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int can_access_browser_delegate(cef_extension_handler_t* self, cef_extension_t* extension, cef_browser_t* browser, int include_incognito, cef_browser_t* target_browser);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_extension_resource_delegate(cef_extension_handler_t* self, cef_extension_t* extension, cef_browser_t* browser, cef_string_t* file, cef_get_extension_resource_callback_t* callback);
        
        private static int _sizeof;
        
        static cef_extension_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_extension_handler_t));
        }
        
        internal static cef_extension_handler_t* Alloc()
        {
            var ptr = (cef_extension_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_extension_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_extension_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
