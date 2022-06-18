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

        public ChiTietBook GetChiTietBookByIdPhong(string IdPhong)
        {
            return QLKS.Instance.ChiTietBooks.Where(p => p.IdPhong == IdPhong).FirstOrDefault();
        }

        public List<DichVu> GetAllDichVu()
        {
            return QLKS.Instance.DichVus.Select(p => p).ToList();
        }

        public DichVu GetDichVuByIdDV(string IdDichVu)
        {
            return QLKS.Instance.DichVus.Where(p => p.IdDichVu == IdDichVu).FirstOrDefault();
        }

        public HoaDon GetHoaDonByIdPhong(string IdPhong)
        {
            foreach (var hoaDon in GetAllHoaDon())
            {
                if (hoaDon.ChiTietThuePhongs.Where(p => p.IDPhong == IdPhong && p.TrangThai == false) != null)
                {
                    return hoaDon;
                };
            }
            return null;
        }

        public List<DichVu> GetAllDichVuByIdPhong(string IdPhong)
        {
            return QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_Phong == IdPhong && p.TrangThai == false).Select(p => p.DichVu).ToList();
        }

        public List<ChiTietSuDungDichVu> GetAllCTDichVuByIdPhong(string IdPhong)
        {
            return QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_Phong == IdPhong && p.TrangThai == false).ToList();
        }

        public ChiTietSuDungDichVu GetCtSDDVByIdPhong(string IdPhong)
        {
            return QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_Phong == IdPhong).FirstOrDefault();
        }

        public string GetLastIdChiTietDichVu()
        {
            return QLKS.Instance.ChiTietSuDungDichVus.Select(p => p.ID_ChiTietSuDungDichVu).ToList().LastOrDefault();
        }

        public List<ChiTietSuDungDichVu> GetAllChiTietSDDV()
        {
            return QLKS.Instance.ChiTietSuDungDichVus.Select(p => p).ToList();
        }

        public ChiTietThuePhong GetChiTietThuePhongByIdPhong(string IdPhong)
        {
            return QLKS.Instance.ChiTietThuePhongs.Where(p => p.IDPhong == IdPhong).FirstOrDefault();
        }

        public List<ThanhToanDichVuView> GetThanhToanDVView(string IdPhong)
        {
            List<ThanhToanDichVuView> data = new List<ThanhToanDichVuView>();
            foreach (ChiTietSuDungDichVu i in GetAllCTDichVuByIdPhong(IdPhong))
            {
                data.Add(new ThanhToanDichVuView { MaDichVu = i.ID_DichVu, DonGia = i.DichVu.DonGia, 
                    NgaySuDung = Convert.ToDateTime(i.NgaySuDung), SoLuong = i.SoLuong,
                    TenDichVu = i.DichVu.TenDichVu, TongTien = i.SoLuong * Convert.ToInt32(i.DichVu.DonGia)});
            }
            return data;
        }


        public void UpdateChiTietDichVu(string IdDichVu, int SoLuong, string IdPhong, DateTime NgaySuDung) 
        {
            foreach (ChiTietSuDungDichVu i in GetAllCTDichVuByIdPhong(IdPhong))
            {
                if (i.ID_DichVu == IdDichVu && i.NgaySuDung == NgaySuDung)
                {
                    i.SoLuong = SoLuong;
                }
            }
            QLKS.Instance.SaveChanges();
        }

        public void AddChiTietDichVu(ChiTietSuDungDichVu ctdv)
        {
            QLKS.Instance.ChiTietSuDungDichVus.Add(ctdv);
            QLKS.Instance.SaveChanges();
        }

        public void DelChiTietDicVu(ChiTietSuDungDichVu ctdv)
        {
            QLKS.Instance.ChiTietSuDungDichVus.Remove(ctdv);
            QLKS.Instance.SaveChanges();
        }
    }
}
