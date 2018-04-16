namespace QuanLiKhachSan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiKhach")]
    public partial class LoaiKhach
    {
        [Key]
        [StringLength(10)]
        public string MaLoaiKhach { get; set; }

        [StringLength(10)]
        public string TenLoaiKhach { get; set; }
    }
}
