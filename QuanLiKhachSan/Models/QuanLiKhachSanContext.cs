namespace QuanLiKhachSan.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLiKhachSanContext : DbContext
    {
        public QuanLiKhachSanContext()
            : base("name=QuanLiKhachSanContext")
        {
        }

        public virtual DbSet<B_HD> B_HD { get; set; }
        public virtual DbSet<BK_CTHD> BK_CTHD { get; set; }
        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<ChiTietThue> ChiTietThues { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<Hi_HD> Hi_HD { get; set; }
        public virtual DbSet<His_CTHD> His_CTHD { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiKhach> LoaiKhaches { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<PhongThue> PhongThues { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThamSo> ThamSoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietThue>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaLoaiKhach)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
              .Property(e => e.MaLoaiKhach)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiKhach>()
                .Property(e => e.MaLoaiKhach)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.MaLoaiPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaLoaiPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhongThue>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.PhongThue)
                .HasForeignKey(e => e.SoHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhongThue>()
                .HasMany(e => e.ChiTietThues)
                .WithRequired(e => e.PhongThue)
                .WillCascadeOnDelete(false);
        }
    }
}
