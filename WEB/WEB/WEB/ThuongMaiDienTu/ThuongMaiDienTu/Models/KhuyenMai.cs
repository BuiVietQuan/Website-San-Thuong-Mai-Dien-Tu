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
    
    public partial class KhuyenMai
    {
        public string MaGiamGia { get; set; }
        public string TenKhuyenMai { get; set; }
        public string MaVoucher { get; set; }
        public string MaCuaHang { get; set; }
        public double TyLeGiamGia { get; set; }
        public int DonHangToiThieu { get; set; }
        public Nullable<int> LuotSuDung { get; set; }
        public Nullable<int> MucGiamToiDa { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public System.DateTime NgayKetThuc { get; set; }
    
        public virtual CuaHang CuaHang { get; set; }
    }
}
