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
    
    public partial class CuaHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuaHang()
        {
            this.DonHangs = new HashSet<DonHang>();
            this.KhuyenMais = new HashSet<KhuyenMai>();
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public string MaCuaHang { get; set; }
        public string TenCuaHang { get; set; }
        public string AnhDaiDien { get; set; }
        public string SoDienThoai { get; set; }
        public System.DateTime NgayDangKy { get; set; }
        public string DiaChiLayHang { get; set; }
        public string ChuKy { get; set; }
        public int LuotTruyCap { get; set; }
        public bool TrangThai { get; set; }
    
        public virtual Xa_Phuong Xa_Phuong { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
