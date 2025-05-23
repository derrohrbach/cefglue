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
    internal unsafe struct cef_shared_process_message_builder_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _is_valid;
        internal IntPtr _size;
        internal IntPtr _memory;
        internal IntPtr _build;
        
        // Create
        [DllImport(libcef.DllName, EntryPoint = "cef_shared_process_message_builder_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_shared_process_message_builder_t* create(cef_string_t* name, UIntPtr byte_size);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_shared_process_message_builder_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_shared_process_message_builder_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_shared_process_message_builder_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_at_least_one_ref_delegate(cef_shared_process_message_builder_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_valid_delegate(cef_shared_process_message_builder_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate UIntPtr size_delegate(cef_shared_process_message_builder_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void* memory_delegate(cef_shared_process_message_builder_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_process_message_t* build_delegate(cef_shared_process_message_builder_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_shared_process_message_builder_t* self)
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
        
        public static int release(cef_shared_process_message_builder_t* self)
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
        
        public static int has_one_ref(cef_shared_process_message_builder_t* self)
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
        
        public static int has_at_least_one_ref(cef_shared_process_message_builder_t* self)
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
        
        // IsValid
        private static IntPtr _p4;
        private static is_valid_delegate _d4;
        
        public static int is_valid(cef_shared_process_message_builder_t* self)
        {
            is_valid_delegate d;
            var p = self->_is_valid;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (is_valid_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_valid_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // Size
        private static IntPtr _p5;
        private static size_delegate _d5;
        
        public static UIntPtr size(cef_shared_process_message_builder_t* self)
        {
            size_delegate d;
            var p = self->_size;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (size_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(size_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // Memory
        private static IntPtr _p6;
        private static memory_delegate _d6;
        
        public static void* memory(cef_shared_process_message_builder_t* self)
        {
            memory_delegate d;
            var p = self->_memory;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (memory_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(memory_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // Build
        private static IntPtr _p7;
        private static build_delegate _d7;
        
        public static cef_process_message_t* build(cef_shared_process_message_builder_t* self)
        {
            build_delegate d;
            var p = self->_build;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (build_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(build_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
    }
}
