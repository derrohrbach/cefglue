namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// Class representing a V8 ArrayBuffer backing store. The backing store holds
    /// the memory that backs an ArrayBuffer. It must be created on a thread with a
    /// valid V8 isolate (renderer main thread or WebWorker thread). Once created,
    /// the Data() pointer can be safely read/written from any thread.
    /// </summary>
    public sealed unsafe partial class CefV8BackingStore
    {
        /// <summary>
        /// Create a new backing store with allocated memory of <paramref name="byteLength"/>
        /// bytes. The memory is uninitialized. This method must be called on a thread
        /// with a valid V8 isolate. Returns null on failure.
        /// </summary>
        public static CefV8BackingStore Create(int byteLength)
        {
            return FromNativeOrNull(cef_v8_backing_store_t.create((UIntPtr)byteLength));
        }

        /// <summary>
        /// Returns a pointer to the allocated memory, or IntPtr.Zero if the backing
        /// store has been consumed or is otherwise invalid.
        /// </summary>
        public IntPtr Data => (IntPtr)cef_v8_backing_store_t.data(_self);

        /// <summary>
        /// Returns the size of the allocated memory in bytes, or 0 if the backing
        /// store has been consumed.
        /// </summary>
        public int ByteLength => (int)cef_v8_backing_store_t.byte_length(_self);

        /// <summary>
        /// Returns true if this backing store has not yet been consumed by
        /// CefV8Value.CreateArrayBufferFromBackingStore.
        /// </summary>
        public bool IsValid => cef_v8_backing_store_t.is_valid(_self) != 0;
    }
}
