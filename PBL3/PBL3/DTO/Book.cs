using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class Book
    {


        public string IdBook { get; set; }
        public string IdKhachHang { get; set; }
        public string IdNhanVien { get; set; }
        public DateTime NgayDatPhong { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int TienCoc { get; set; }

      

    }
}
