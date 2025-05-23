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
    internal unsafe struct cef_urlrequest_client_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_request_complete;
        internal IntPtr _on_upload_progress;
        internal IntPtr _on_download_progress;
        internal IntPtr _on_download_data;
        internal IntPtr _get_auth_credentials;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_urlrequest_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_urlrequest_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_urlrequest_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_urlrequest_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_request_complete_delegate(cef_urlrequest_client_t* self, cef_urlrequest_t* request);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_upload_progress_delegate(cef_urlrequest_client_t* self, cef_urlrequest_t* request, long current, long total);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_download_progress_delegate(cef_urlrequest_client_t* self, cef_urlrequest_t* request, long current, long total);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_download_data_delegate(cef_urlrequest_client_t* self, cef_urlrequest_t* request, void* data, UIntPtr data_length);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_auth_credentials_delegate(cef_urlrequest_client_t* self, int isProxy, cef_string_t* host, int port, cef_string_t* realm, cef_string_t* scheme, cef_auth_callback_t* callback);
        
        private static int _sizeof;
        
        static cef_urlrequest_client_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_urlrequest_client_t));
        }
        
        internal static cef_urlrequest_client_t* Alloc()
        {
            var ptr = (cef_urlrequest_client_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_urlrequest_client_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_urlrequest_client_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
