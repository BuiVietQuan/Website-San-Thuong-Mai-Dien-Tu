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
    
    public partial class ThongTinLienHe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinLienHe()
        {
            this.DonHangs = new HashSet<DonHang>();
        }
    
        public string MaLH { get; set; }
        public string ID { get; set; }
        public string TenNguoiNhan { get; set; }
        public string MaXP { get; set; }
        public string DiaChiCuThe { get; set; }
        public string SoDienThoai { get; set; }
        public string LoaiDiaChi { get; set; }
        public Nullable<bool> MacDinh { get; set; }
        public Nullable<bool> An { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual Xa_Phuong Xa_Phuong { get; set; }
    }
}
