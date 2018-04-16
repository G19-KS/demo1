namespace QuanLiKhachSan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongThue")]
    public partial class PhongThue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongThue()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
            ChiTietThues = new HashSet<ChiTietThue>();
        }

        [Key]
        public int MaThue { get; set; }

        public int? SoHD { get; set; }

        public int? MaPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThue> ChiTietThues { get; set; }
    }
}
