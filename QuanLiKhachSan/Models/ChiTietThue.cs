namespace QuanLiKhachSan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietThue")]
    public partial class ChiTietThue
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThue { get; set; }

        [Key]
        [Column(Order = 1)]
        public int STT { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string CMND { get; set; }

        public virtual PhongThue PhongThue { get; set; }
    }
}
