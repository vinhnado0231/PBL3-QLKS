using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DTOVIEW;
using PBL3.DAL;

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

        public List<HoaDon> GetAllHoaDon()
        {
            return QLKS.Instance.HoaDons.Select(p => p).ToList();
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
            List<HoaDonView> data = new List<HoaDonView>();
            if (From != new DateTime() && To != new DateTime())
            {


                if (loaiTimKiem == "Mã hóa đơn")
                {
                    foreach (HoaDon i in GetAllHoaDon())
                    {
                        if (i.IdHoaDon.Contains(txt))
                        {
                            AddHoaDonView(data, i);
                        }
                    }
                }

                if (loaiTimKiem == "Mã khách hàng")
                {
                    foreach (HoaDon i in GetAllHoaDon())
                    {
                        if (i.IDKhachHang.Contains(txt))
                        {
                            AddHoaDonView(data, i);
                        }
                    }
                }

                if (loaiTimKiem == "Tên khách hàng")
                {
                    foreach (HoaDon i in GetAllHoaDon())
                    {
                        if (i.KhachHang.Ten.Contains(txt))
                        {
                            AddHoaDonView(data, i);
                        }
                    }
                }

                if (loaiTimKiem == "Mã nhân viên")
                {
                    foreach (HoaDon i in GetAllHoaDon())
                    {
                        if (i.IDNhanVien.Contains(txt))
                        {
                            AddHoaDonView(data, i);
                        }
                    }
                }

                if (loaiTimKiem == "")
                {
                    foreach (HoaDon i in GetAllHoaDon())
                    {


                        AddHoaDonView(data, i);

                    }
                }

            }


           
            return data;
        }

        public void AddHoaDonView(List<HoaDonView> data, HoaDon i)
        {
            

            data.Add(new HoaDonView
            {
                MaHoaDon = i.IdHoaDon,
                MaKhachHang = i.IDKhachHang,
                TenKhachHang = i.KhachHang.Ten,
                MaNhanVien = i.IDNhanVien,
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
