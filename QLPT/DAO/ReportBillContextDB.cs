namespace QLPT.DAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ReportBillContextDB : DbContext
    {
        public ReportBillContextDB()
            : base("name=ReportBillContextDB")
        {
        }

        public virtual DbSet<DayNha> DayNhas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HopDongThueNha> HopDongThueNhas { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DayNha>()
                .HasMany(e => e.Phongs)
                .WithRequired(e => e.DayNha)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<HopDongThueNha>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HopDongThueNhas)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.HopDongThueNhas)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);
        }
    }
}
