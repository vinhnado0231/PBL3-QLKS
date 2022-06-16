using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Phong
    {

        public string IdPhong { get; set; }
        public string TenPhong { get; set; }

        public string IdLoaiPhong { get; set; }

        public bool TrangThai { get; set; }
        public string DonGiaPhong { get; set; }


    }
}
