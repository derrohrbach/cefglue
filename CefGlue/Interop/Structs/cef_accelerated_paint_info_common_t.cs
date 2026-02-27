//
// This file manually written from cef/include/internal/cef_types_osr.h.
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    internal unsafe struct cef_accelerated_paint_info_common_t
    {
        public UIntPtr size;
        public ulong timestamp;
        public cef_size_t coded_size;
        public cef_rect_t visible_rect;
        public cef_rect_t content_rect;
        public cef_size_t source_size;
        public cef_rect_t capture_update_rect;
        public cef_rect_t region_capture_rect;
        public ulong capture_counter;
        public byte has_capture_update_rect;
        public byte has_region_capture_rect;
        public byte has_source_size;
        public byte has_capture_counter;
    }
}
