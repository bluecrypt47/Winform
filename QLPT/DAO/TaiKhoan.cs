namespace QLPT.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(100)]
        public string TenTaiKhoan { get; set; }

        [StringLength(100)]
        public string TenHienThi { get; set; }

        [StringLength(1000)]
        public string MatKhau { get; set; }
    }
}
