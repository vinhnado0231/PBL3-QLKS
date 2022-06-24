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
            List<HoaDon> hoaDons = QLKS.Instance.HoaDons.Select(p => p).ToList();
            foreach (HoaDon hoaDon in hoaDons)
            {
                if (hoaDon.ChiTietSuDungDichVus.Where(a => a.ID_Phong == IdPhong && a.TrangThai == false) != null)
                {
                    return hoaDon;
                }
            }
            return null;
        }

        public List<DichVu> GetAllDichVuByIdPhong(string IdPhong)
        {
            return QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_Phong == IdPhong && p.TrangThai == false).Select(p => p.DichVu).ToList();
        }

        public ChiTietSuDungDichVu GetCtSDDVByIdPhong(string IdPhong)
        {
            return QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_Phong == IdPhong).FirstOrDefault();
        }

        public int GetLastIdChiTietDichVu()
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
            List<ChiTietSuDungDichVu> chiTietSuDungDichVus = QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_Phong == IdPhong && p.TrangThai == false).ToList();
            foreach (ChiTietSuDungDichVu i in chiTietSuDungDichVus)
            {
                data.Add(new ThanhToanDichVuView { 
                    MaChiTietDV = i.ID_ChiTietSuDungDichVu,
                    MaDichVu = i.ID_DichVu, 
                    DonGia = i.DichVu.DonGia, 
                    NgaySuDung = Convert.ToDateTime(i.NgaySuDung), 
                    SoLuong = i.SoLuong,
                    TenDichVu = i.DichVu.TenDichVu, TongTien = i.SoLuong * Convert.ToInt32(i.DichVu.DonGia)});
            }
            return data;
        }


        public void UpdateChiTietDichVu(ThanhToanDichVuView data, string idPhong) 
        {
            List<ChiTietSuDungDichVu> chiTietSuDungDichVus = QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_Phong == idPhong && p.TrangThai == false).ToList();
            foreach (ChiTietSuDungDichVu i in chiTietSuDungDichVus)
            {
                if (i.ID_ChiTietSuDungDichVu == data.MaChiTietDV)
                {
                    i.SoLuong = data.SoLuong;
                    i.ID_DichVu = data.MaDichVu;
                    i.NgaySuDung = data.NgaySuDung;
                }
            }
            QLKS.Instance.SaveChanges();
        }

        public bool checkData(string IdDV, DateTime NgaySd)
        {
            if (QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_DichVu == IdDV && p.NgaySuDung == NgaySd.Date).Select(p => p).FirstOrDefault() != null)
            {
                return true;
            }
            return false;
        }

        public void AddChiTietDichVu(ChiTietSuDungDichVu ctdv)
        {
            QLKS.Instance.ChiTietSuDungDichVus.Add(ctdv);
            QLKS.Instance.SaveChanges();
        }

        public void DelChiTietDichVu(List<ThanhToanDichVuView> list, string IdPhong)
        {
            List<ChiTietSuDungDichVu> chiTietSuDungDichVus = QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_Phong == IdPhong && p.TrangThai == false).ToList();
            List<ChiTietSuDungDichVu> chiTietSuDungDichVusDel = new List<ChiTietSuDungDichVu>();
            foreach (ChiTietSuDungDichVu i in chiTietSuDungDichVus)
            {
                foreach (ThanhToanDichVuView j in list)
                {
                    if (i.ID_DichVu == j.MaDichVu && i.NgaySuDung == j.NgaySuDung)
                    {
                        chiTietSuDungDichVusDel.Add(i);
                    }
                }
            }
            QLKS.Instance.ChiTietSuDungDichVus.RemoveRange(chiTietSuDungDichVusDel);
            QLKS.Instance.SaveChanges();
        }
    }
}
