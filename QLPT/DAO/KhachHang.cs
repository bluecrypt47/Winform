namespace QLPT.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
            HopDongThueNhas = new HashSet<HopDongThueNha>();
        }

        [Key]
        [StringLength(10)]
        public string CMND { get; set; }

        [StringLength(10)]
        public string Ho { get; set; }

        [StringLength(20)]
        public string TenLot { get; set; }

        [StringLength(10)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDongThueNha> HopDongThueNhas { get; set; }
    }
}
