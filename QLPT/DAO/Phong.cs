namespace QLPT.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            HoaDons = new HashSet<HoaDon>();
            HopDongThueNhas = new HashSet<HopDongThueNha>();
        }

        [Key]
        [StringLength(10)]
        public string SoPhong { get; set; }

        [Required]
        [StringLength(10)]
        public string IDDayNha { get; set; }

        public byte? SoNguoiTroCungLuc { get; set; }

        [StringLength(1000)]
        public string TinhTrangPhong { get; set; }

        public long? GiaPhong { get; set; }

        public virtual DayNha DayNha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDongThueNha> HopDongThueNhas { get; set; }
    }
}
