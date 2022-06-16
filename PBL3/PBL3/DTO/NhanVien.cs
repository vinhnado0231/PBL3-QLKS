using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class NhanVien
    {

        public string IdNhanVien { get; set; }

        public string Username { get; set; }
        public string IdChucVu { get; set; }
        public string Ten { get; set; }   
        public bool GioiTinh { get; set; }
        
        public string CMND { get; set; }
       
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayVaoLam { get; set; }

    }
}
