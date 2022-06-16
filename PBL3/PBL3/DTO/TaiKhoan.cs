using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class TaiKhoan
    {
        [Key, StringLength(50), Required]
        public string TenDangNhap { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
