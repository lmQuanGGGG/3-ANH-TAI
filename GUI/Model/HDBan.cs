namespace GUI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDBan")]
    public partial class HDBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HDBan()
        {
            ChiTietHDBans = new HashSet<ChiTietHDBan>();
        }

        [Key]
        [StringLength(30)]
        public string MaHDBan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNV { get; set; }

        public DateTime NgayBan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhach { get; set; }

        public double TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDBan> ChiTietHDBans { get; set; }

        public virtual Khach Khach { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
