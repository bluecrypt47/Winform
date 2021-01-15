namespace QLPT.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DayNha")]
    public partial class DayNha
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DayNha()
        {
            Phongs = new HashSet<Phong>();
        }

        [Key]
        [StringLength(10)]
        public string IDDayNha { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChiDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
