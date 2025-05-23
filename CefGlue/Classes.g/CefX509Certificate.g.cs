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
    public sealed unsafe partial class CefX509Certificate : IDisposable
    {
        internal static CefX509Certificate FromNative(cef_x509certificate_t* ptr)
        {
            return new CefX509Certificate(ptr);
        }
        
        internal static CefX509Certificate FromNativeOrNull(cef_x509certificate_t* ptr)
        {
            if (ptr == null) return null;
            return new CefX509Certificate(ptr);
        }
        
        private cef_x509certificate_t* _self;
        
        private CefX509Certificate(cef_x509certificate_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefX509Certificate()
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
            cef_x509certificate_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_x509certificate_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_x509certificate_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_x509certificate_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_x509certificate_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
