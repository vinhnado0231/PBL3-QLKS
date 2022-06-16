using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ChiTietThuePhong
    {
        [Key, StringLength(10), Required]
        public string IDHoaDon { get; set; }
        [StringLength(10), Required]
        public string IDPhong { get; set; }
        [StringLength(10), Required]
        public string IDNhanVien { get; set; }
        [Required]
        public DateTime NgayCheckIn { get; set; }
        [Required]
        public DateTime NgayCheckOut { get; set; }
        [ForeignKey("IDHoaDon")]
        public virtual HoaDon HoaDon { get; set; }
        [ForeignKey("IDPhong")]
        public virtual Phong Phong { get; set; }
        [ForeignKey("IDNhanVien")]
        public virtual NhanVien NhanVien { get; set; }

    }
}
