using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ChiTietSuDungDichVu
    {
        public string ID_ChiTietSuDungDichVu { get; set; }
        public string ID_Phong { get; set; }
        public string ID_DichVu { get; set; }
        public string ID_HoaDon { get; set; }
        public DateTime NgaySuDung { get; set; }
        public int SoLuong { get; set; }
        public string DonGiaCTDV { get; set; }
    }
}
