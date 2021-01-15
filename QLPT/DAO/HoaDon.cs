namespace QLPT.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string IDHoaDon { get; set; }

        [Required]
        [StringLength(10)]
        public string SoPhong { get; set; }

        [Required]
        [StringLength(10)]
        public string CMND { get; set; }

        public DateTime? NgayLap { get; set; }

        public long? ChiSoNuocCu { get; set; }

        public long? ChiSoNuocMoi { get; set; }

        public long? ChiSoDienCu { get; set; }

        public long? ChiSoDienMoi { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
