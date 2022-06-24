using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DTOVIEW;
using PBL3.DAL;
using System.Reflection;

namespace PBL3.BLL
{
    public class QLHoaDon_BLL
    {
        private static QLHoaDon_BLL _Instance;
        public static QLHoaDon_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLHoaDon_BLL();
                }
                return _Instance;
            }
            set { }
        }



        public List<ChiTietThuePhong> GetAllChiTietThuePhong()
        {
            return QLKS.Instance.ChiTietThuePhongs.Select(p => p).ToList();
        }
        public List<ChiTietSuDungDichVu> GetAllChiTietDichVu()
        {
            return QLKS.Instance.ChiTietSuDungDichVus.Select(p => p).ToList();
        }

        public List<ChiTietThuePhong> getAllChiTietThuePhongByIDHoaDon(string idHoaDon)
        {
            return QLKS.Instance.ChiTietThuePhongs.Where(p => p.IDHoaDon == idHoaDon).ToList();
        }

        public List<ChiTietSuDungDichVu> getAllChiTietDVByIDHoaDon(string idHoaDon)
        {
            return QLKS.Instance.ChiTietSuDungDichVus.Where(p => p.ID_HoaDon == idHoaDon).ToList();
        }

        public int TongTienPhongByIdHoaDon(string idHoaDon)
        {
            int sum = 0;
            foreach (ChiTietThuePhong i in getAllChiTietThuePhongByIDHoaDon(idHoaDon))
            {
                TimeSpan Ngay = Convert.ToDateTime(i.NgayCheckOut) - Convert.ToDateTime(i.NgayCheckIn);
                sum += Convert.ToInt32(i.Phong.DonGiaPhong) * Convert.ToInt32(Ngay.Days);
            }
            return sum;
        }

        public int TongTienDVByIdHoaDon(string idHoaDon)
        {
            int sum = 0;
            foreach (ChiTietSuDungDichVu i in getAllChiTietDVByIDHoaDon(idHoaDon))
            {
                sum += Convert.ToInt32(i.DichVu.DonGia) * i.SoLuong;
            }
            return sum;
        }



        public List<HoaDonView> getAllHoaDonView(string txt, string loaiTimKiem, DateTime From, DateTime To)
        {
            List<HoaDonView> dataMain = new List<HoaDonView>();
            List<HoaDon> hoaDons = QLKS.Instance.HoaDons.Select(p => p).ToList();
            hoaDons.ForEach(p => AddHoaDonView(dataMain, p));

            if (From != new DateTime() && To != new DateTime())
            {
                if (loaiTimKiem != "")
                {
                    List<HoaDonView> hoaDonSearchsBycbb = dataMain.Where(p => p.GetType().GetProperty(loaiTimKiem.ToString()).GetValue(p).ToString().Contains(txt)
                                                                        && p.NgayThanhToan.Date >= From && p.NgayThanhToan.Date <= To.Date).ToList();
                    return hoaDonSearchsBycbb;
                }
                else
                {
                    List<HoaDonView> hoaDonSearchAll = dataMain.Where(p => p.GetType().GetProperties().GetValue(p.GetType().GetProperties().Length - 1).ToString().Contains(txt)
                                                                      && p.NgayThanhToan.Date >= From && p.NgayThanhToan.Date <= To.Date).ToList();
                    return hoaDonSearchAll;
                }
            }

            if (loaiTimKiem != "")
            {
                List<HoaDonView> hoaDonSearchsBycbb = dataMain.Where(p => p.GetType().GetProperty(loaiTimKiem.ToString()).GetValue(p).ToString().Contains(txt)).ToList();
                return hoaDonSearchsBycbb;
            }
            else
            {
                List<HoaDonView> hoaDonSearchAll = dataMain.Where(p => p.GetType().GetProperties().GetValue(p.GetType().GetProperties().Length - 1).ToString().Contains(txt)).ToList();
                return hoaDonSearchAll;
            }


        }

        

        public void AddHoaDonView(List<HoaDonView> data, HoaDon i)
        {
            

            data.Add(new HoaDonView
            {
                IdHoaDon = i.IdHoaDon,
                IDKhachHang = i.IDKhachHang,
                TenKhachHang = i.KhachHang.Ten,
                IDNhanVien = i.IDNhanVien,
                NgayThanhToan = Convert.ToDateTime(i.NgayHoaDon),
                TienTraTruoc = i.TienTraTruoc,
                TienPhong = TongTienPhongByIdHoaDon(i.IdHoaDon),
                TongTienDV = TongTienDVByIdHoaDon(i.IdHoaDon),
                ThueVAT = (TongTienPhongByIdHoaDon(i.IdHoaDon) + TongTienDVByIdHoaDon(i.IdHoaDon)) * 5 / 100,
                TongTien = TongTienDVByIdHoaDon(i.IdHoaDon) + TongTienPhongByIdHoaDon(i.IdHoaDon) + i.TienTraTruoc + (TongTienPhongByIdHoaDon(i.IdHoaDon) + TongTienDVByIdHoaDon(i.IdHoaDon)) * 5 / 100,
                TrangThai = i.TinhTrang
            });
        }

        public List<ChiTietThuePhongView> getAllChiTietThuePhongView(string idHoaDon)
        {
            List<ChiTietThuePhongView> data = new List<ChiTietThuePhongView>();
            foreach (ChiTietThuePhong i in getAllChiTietThuePhongByIDHoaDon(idHoaDon))
            {
                data.Add(new ChiTietThuePhongView { 
                    MaPhong = i.IDPhong,
                    TenPhong = i.Phong.TenPhong,
                    NgayThue = Convert.ToDateTime(i.NgayCheckIn),
                    NgayTra = Convert.ToDateTime(i.NgayCheckOut),
                    DonGiaPhong = Convert.ToInt32(i.Phong.DonGiaPhong),
                    TienPhong = Convert.ToInt32(i.Phong.DonGiaPhong) * (Convert.ToDateTime(i.NgayCheckOut) - Convert.ToDateTime(i.NgayCheckIn)).Days,
                });
            }
            return data;
        }


        public List<ChiTietDichVuView> getAllChiTietDVView(string idHoaDon)
        {
            List<ChiTietDichVuView> data = new List<ChiTietDichVuView> ();
            foreach (ChiTietSuDungDichVu i in getAllChiTietDVByIDHoaDon(idHoaDon)) {
                data.Add(new ChiTietDichVuView { 
                    MaDichVu = i.ID_DichVu,
                    TenDichVu = i.DichVu.TenDichVu,
                    TenPhong = i.Phong.TenPhong,
                    NgaySuDung = Convert.ToDateTime(i.NgaySuDung),
                    SoLuong = i.SoLuong,
                    DonGia = Convert.ToInt32(i.DichVu.DonGia),
                    TongTien = i.SoLuong * Convert.ToInt32(i.DichVu.DonGia)
                });
            }
            return data;
        }
    }
}
