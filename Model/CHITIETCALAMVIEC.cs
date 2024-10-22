namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETCALAMVIEC")]
    public partial class CHITIETCALAMVIEC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaCa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaNV { get; set; }

        public bool? TrangThai { get; set; }

        public virtual CALAMVIEC CALAMVIEC { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
