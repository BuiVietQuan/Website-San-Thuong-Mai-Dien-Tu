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
    
    public partial class ChiTietDonHang
    {
        public string MaDonHang { get; set; }
        public string MaSP { get; set; }
        public string MaCTKichCo { get; set; }
        public int SoLuong { get; set; }
        public int TongTien { get; set; }
    
        public virtual ChiTietKichCo ChiTietKichCo { get; set; }
        public virtual DonHang DonHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
