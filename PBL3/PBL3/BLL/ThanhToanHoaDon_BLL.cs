using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTOVIEW;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class ThanhToanHoaDon_BLL
    {
        private static ThanhToanHoaDon_BLL _Instance;
        public static ThanhToanHoaDon_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ThanhToanHoaDon_BLL();
                }
                return _Instance;
            }
            set { }
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return QLKS.Instance.HoaDons.Select(p => p).ToList();
        }

        public HoaDon GetHoaDonByIdPhong(string IdPhong)
        {
            foreach (var hoaDon in GetAllHoaDon())
            {
                if (hoaDon.ChiTietThuePhongs.Where(p => p.IDPhong == IdPhong) != null)
                {
                    return hoaDon;
                };
            }
            return null;
        }



        
    }
}
