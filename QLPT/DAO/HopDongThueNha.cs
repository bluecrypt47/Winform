namespace QLPT.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDongThueNha")]
    public partial class HopDongThueNha
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IDHopDong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string SoPhong { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string CMND { get; set; }

        [StringLength(200)]
        public string TinhTrangTienCoc { get; set; }

        public DateTime? NgayChuyenVao { get; set; }

        public long? TienCoc { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
