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
    internal unsafe struct cef_load_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_loading_state_change;
        internal IntPtr _on_load_start;
        internal IntPtr _on_load_end;
        internal IntPtr _on_load_error;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_load_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_load_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_load_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_load_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_loading_state_change_delegate(cef_load_handler_t* self, cef_browser_t* browser, int isLoading, int canGoBack, int canGoForward);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_load_start_delegate(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, CefTransitionType transition_type);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_load_end_delegate(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, int httpStatusCode);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_load_error_delegate(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, CefErrorCode errorCode, cef_string_t* errorText, cef_string_t* failedUrl);
        
        private static int _sizeof;
        
        static cef_load_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_load_handler_t));
        }
        
        internal static cef_load_handler_t* Alloc()
        {
            var ptr = (cef_load_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_load_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_load_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
