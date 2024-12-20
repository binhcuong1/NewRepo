namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUYENMAI")]
    public partial class KHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYENMAI()
        {
            CHITITETKHUYENMAIs = new HashSet<CHITITETKHUYENMAI>();
        }

        [Key]
        [StringLength(20)]
        public string MaKM { get; set; }

        [StringLength(50)]
        public string TenKM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITITETKHUYENMAI> CHITITETKHUYENMAIs { get; set; }
    }
}
