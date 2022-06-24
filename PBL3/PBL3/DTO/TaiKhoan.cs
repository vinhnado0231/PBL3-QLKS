﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class TaiKhoan
    {
        [Key, StringLength(50), Required]
        public string TenDangNhap { get; set; }
        [StringLength(10), Required]
        public string IdNhanVien { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        [ForeignKey("IdNhanVien")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
