//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThuongMaiDienTu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietGioHang
    {
        public string ID { get; set; }
        public string MaCTKichCo { get; set; }
        public int SoLuong { get; set; }
    
        public virtual ChiTietKichCo ChiTietKichCo { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
