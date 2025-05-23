//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefAuthCallback : IDisposable
    {
        internal static CefAuthCallback FromNative(cef_auth_callback_t* ptr)
        {
            return new CefAuthCallback(ptr);
        }
        
        internal static CefAuthCallback FromNativeOrNull(cef_auth_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefAuthCallback(ptr);
        }
        
        private cef_auth_callback_t* _self;
        
        private CefAuthCallback(cef_auth_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefAuthCallback()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_auth_callback_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_auth_callback_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_auth_callback_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_auth_callback_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_auth_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
