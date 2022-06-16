using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class HoaDon
    {

        public string IdHoaDon { get; set; }
        public string IDKhachHang { get; set; }
        public string IDNhanVien { get; set; }

        public DateTime NgayHoaDon { get; set; }
        public bool TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public int TienTraTruoc { get; set; }

    }
}
