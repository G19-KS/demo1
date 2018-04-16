namespace QuanLiKhachSan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hi_HD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        public int? MaKH { get; set; }
    }
}
