namespace QuanLiKhachSan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHD")]
    public partial class ChiTietHD
    {
        [Key]
        [Column(Order = 0)]
        public int SoHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhong { get; set; }

        public int? SoNgayO { get; set; }

        public int? DonGia { get; set; }

        public int? Tien { get; set; }

        public bool? DeleteFiag { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual PhongThue PhongThue { get; set; }
    }
}
