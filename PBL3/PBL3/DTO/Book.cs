using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class Book
    {

        [Key, StringLength(10), Required]
        public string IdBook { get; set; }
        [Required, StringLength(10)]
        public string IdKhachHang { get; set; }
        [Required, StringLength(10)]
        public string IdNhanVien { get; set; }
        public int TienCoc { get; set; }
        [ForeignKey("IdKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        public virtual ChiTietBook ChiTietBook { get; set; }
        [ForeignKey("IdNhanVien")]
        public virtual NhanVien NhanVien { get; set; }

    }
}
