using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class CreateDB:
                    CreateDatabaseIfNotExists<QLKS>
    //CreateDatabaseIfNotExists<QLKS>


    {
        protected override void Seed(QLKS context)
        {
            context.ChucVus.AddRange(new ChucVu[]
            {
                new ChucVu {IdChucVu = "AD", TenChucVu = "Admin"},
                new ChucVu {IdChucVu = "NV", TenChucVu = "Nhân Viên"},

            });

            context.LoaiPhongs.AddRange(new LoaiPhong[]
            {
                new LoaiPhong {IdLoaiPhong = "1T", TenLoaiPhong = "Phòng đơn thường"},
                new LoaiPhong {IdLoaiPhong = "2T", TenLoaiPhong = "Phòng đôi thường"},
                new LoaiPhong {IdLoaiPhong = "1V", TenLoaiPhong = "Phòng đơn VIP"},
                new LoaiPhong {IdLoaiPhong = "2V", TenLoaiPhong = "Phòng đôi VIP"},

            });

            context.DichVus.AddRange(new DichVu[]
            {
                new DichVu {IdDichVu = "DV1", TenDichVu = "Coca"},
                new DichVu {IdDichVu = "DV2", TenDichVu = "Mì tôm"},
                new DichVu {IdDichVu = "DV3", TenDichVu = "Bánh mì"},
                new DichVu {IdDichVu = "DV4", TenDichVu = "Massage"},
                new DichVu {IdDichVu = "DV5", TenDichVu = "Karaoke"},
                new DichVu {IdDichVu = "DV6", TenDichVu = "Bida"},
            });

            context.KhachHangs.AddRange(new KhachHang[]
            {
                new KhachHang {IdKhachHang = "K1", Ten = "NVA", GioiTinh = true, CMND = "123456789", SDT = "0123456789", QuocTich = "VN", GhiChu = ""},
                new KhachHang {IdKhachHang = "K2", Ten = "NVB", GioiTinh = false, CMND = "147258369", SDT = "147258369", QuocTich = "VN", GhiChu = ""},
                new KhachHang {IdKhachHang = "K3", Ten = "NVC", GioiTinh = false, CMND = "258147369", SDT = "258147369", QuocTich = "VN", GhiChu = ""},
                new KhachHang {IdKhachHang = "K4", Ten = "NVD", GioiTinh = false, CMND = "123465147", SDT = "123465147", QuocTich = "VN", GhiChu = ""},
                new KhachHang {IdKhachHang = "K5", Ten = "NVE", GioiTinh = true, CMND = "369123456", SDT = "369123456", QuocTich = "VN", GhiChu = ""},

            });

            context.TaiKhoans.AddRange(new TaiKhoan[]
            {
                new TaiKhoan {TenDangNhap = "NhanVien1", MatKhau = "nhanvien", TrangThai = true},
                new TaiKhoan {TenDangNhap = "NhanVien2", MatKhau = "nhanvien", TrangThai = false},
                new TaiKhoan {TenDangNhap = "NhanVien3", MatKhau = "nhanvien", TrangThai = false},
                new TaiKhoan {TenDangNhap = "NhanVien4", MatKhau = "nhanvien", TrangThai = false},
                new TaiKhoan {TenDangNhap = "Admin", MatKhau = "admin", TrangThai = false},

            });

            context.NhanViens.AddRange(new NhanVien[]
            {
                new NhanVien {IdNhanVien = "NV1", Username = "NhanVien1", IdChucVu = "NV", Ten = "NNA", GioiTinh = true, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam = new DateTime(2002, 07, 01)},
                new NhanVien {IdNhanVien = "NV2", Username = "NhanVien1", IdChucVu = "NV", Ten = "NNB", GioiTinh = false, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam = new DateTime(2002, 07, 01)},
                new NhanVien {IdNhanVien = "NV3", Username = "NhanVien1", IdChucVu = "NV", Ten = "NNC", GioiTinh = true, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam = new DateTime(2002, 07, 01)},
                new NhanVien {IdNhanVien = "NV4", Username = "NhanVien1", IdChucVu = "NV", Ten = "NND", GioiTinh = false, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam = new DateTime(2002, 07, 01)},
                new NhanVien {IdNhanVien = "NV5", Username = "NhanVien1", IdChucVu = "NV", Ten = "NNE", GioiTinh = false, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam = new DateTime(2002, 07, 01)},
                new NhanVien {IdNhanVien = "NV6", Username = "Admin", IdChucVu = "AD", Ten = "NNA", GioiTinh = true, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam = new DateTime(2002, 07, 01)},

            });

            context.HoaDons.AddRange(new HoaDon[] { 
                new HoaDon {IdHoaDon = "HD1", IDKhachHang = "K1", IDNhanVien = "NV1", NgayHoaDon = new DateTime(2002, 07, 30), TinhTrang = true, TienTraTruoc = 30},
                new HoaDon {IdHoaDon = "HD2", IDKhachHang = "K2", IDNhanVien = "NV2", NgayHoaDon = new DateTime(2002, 07, 30), TinhTrang = true, TienTraTruoc = 30},
                new HoaDon {IdHoaDon = "HD3", IDKhachHang = "K3", IDNhanVien = "NV3", NgayHoaDon = new DateTime(2002, 07, 30), TinhTrang = true, TienTraTruoc = 30},
                new HoaDon {IdHoaDon = "HD4", IDKhachHang = "K4", IDNhanVien = "NV4", NgayHoaDon = new DateTime(2002, 07, 30), TinhTrang = true, TienTraTruoc = 30},
                new HoaDon {IdHoaDon = "HD5", IDKhachHang = "K5", IDNhanVien = "NV5", NgayHoaDon = new DateTime(2002, 07, 30), TinhTrang = true, TienTraTruoc = 30},

            });


            context.ChiTietThuePhongs.AddRange(new ChiTietThuePhong[]
            {
                new ChiTietThuePhong {IDHoaDon = "HD1", IDPhong = "1P1", IDNhanVien = "NV1", NgayCheckIn = new DateTime(2002, 07, 28), NgayCheckOut = new DateTime(2002, 07, 30)},
                new ChiTietThuePhong {IDHoaDon = "HD2", IDPhong = "1P1", IDNhanVien = "NV1", NgayCheckIn = new DateTime(2002, 07, 28), NgayCheckOut = new DateTime(2002, 07, 30)},
                new ChiTietThuePhong {IDHoaDon = "HD3", IDPhong = "1P1", IDNhanVien = "NV1", NgayCheckIn = new DateTime(2002, 07, 28), NgayCheckOut = new DateTime(2002, 07, 30)},
                new ChiTietThuePhong {IDHoaDon = "HD4", IDPhong = "1P1", IDNhanVien = "NV1", NgayCheckIn = new DateTime(2002, 07, 28), NgayCheckOut = new DateTime(2002, 07, 30)},
                new ChiTietThuePhong {IDHoaDon = "HD1", IDPhong = "1P1", IDNhanVien = "NV1", NgayCheckIn = new DateTime(2002, 07, 28), NgayCheckOut = new DateTime(2002, 07, 30)},
                new ChiTietThuePhong {IDHoaDon = "HD1", IDPhong = "1P1", IDNhanVien = "NV1", NgayCheckIn = new DateTime(2002, 07, 28), NgayCheckOut = new DateTime(2002, 07, 30)},
            });

            context.Books.AddRange(new Book[] { 
                new Book {IdBook = "B1", IdKhachHang = "K1", IdNhanVien = "NV1", TienCoc = 300},
                new Book {IdBook = "B2", IdKhachHang = "K1", IdNhanVien = "NV1", TienCoc = 0},
                new Book {IdBook = "B3", IdKhachHang = "K2", IdNhanVien = "NV2", TienCoc = 300},
                new Book {IdBook = "B4", IdKhachHang = "K3", IdNhanVien = "NV3", TienCoc = 0},
                new Book {IdBook = "B5", IdKhachHang = "K4", IdNhanVien = "NV4", TienCoc = 300},
                new Book {IdBook = "B6", IdKhachHang = "K5", IdNhanVien = "NV5", TienCoc = 0},

            });

            context.Phongs.AddRange(new Phong[]
            {
                    new Phong {IdPhong = "1P1", TenPhong = "101", IdLoaiPhong = "1V", TrangThai = true, DonGiaPhong = "3000"},
                    new Phong {IdPhong = "1P2", TenPhong = "102", IdLoaiPhong = "2T", TrangThai = true, DonGiaPhong = "2000"},
                    new Phong {IdPhong = "1P3", TenPhong = "103", IdLoaiPhong = "2V", TrangThai = true, DonGiaPhong = "4000"},
                    new Phong {IdPhong = "2P1", TenPhong = "201", IdLoaiPhong = "1T", TrangThai = true, DonGiaPhong = "1000"},
                    new Phong {IdPhong = "2P2", TenPhong = "202", IdLoaiPhong = "2T", TrangThai = true, DonGiaPhong = "2000"},
                    new Phong {IdPhong = "2P3", TenPhong = "203", IdLoaiPhong = "1V", TrangThai = true, DonGiaPhong = "3000"},
                    new Phong {IdPhong = "3P1", TenPhong = "301", IdLoaiPhong = "1T", TrangThai = true, DonGiaPhong = "1000"},
                    new Phong {IdPhong = "3P2", TenPhong = "302", IdLoaiPhong = "1T", TrangThai = true, DonGiaPhong = "1000"},


            });

            context.ChiTietBooks.AddRange(new ChiTietBook[]
            {
                new ChiTietBook{IdBook = "B1", IdPhong = "1P1", NgayCheckInPhong = new DateTime(2002, 07, 28), NgayCheckOut = new DateTime(2002, 07, 30)},
                new ChiTietBook{IdBook = "B1", IdPhong = "1P2", NgayCheckInPhong = new DateTime(2002, 07, 20), NgayCheckOut = new DateTime(2002, 07, 30)},
                new ChiTietBook{IdBook = "B1", IdPhong = "2P3", NgayCheckInPhong = new DateTime(2002, 07, 25), NgayCheckOut = new DateTime(2002, 07, 30)},
                new ChiTietBook{IdBook = "B2", IdPhong = "1P1", NgayCheckInPhong = new DateTime(2002, 07, 25), NgayCheckOut = new DateTime(2002, 07, 27)},
                new ChiTietBook{IdBook = "B3", IdPhong = "1P1", NgayCheckInPhong = new DateTime(2002, 07, 20), NgayCheckOut = new DateTime(2002, 07, 24)},
                new ChiTietBook{IdBook = "B4", IdPhong = "1P1", NgayCheckInPhong = new DateTime(2002, 07, 28)},

            });

            context.LoaiVatDungs.AddRange(new LoaiVatDung[]
            {
                new LoaiVatDung {IdLoaiVatDung = "L1", TenVatDung = "TV", DonGia = "1000"},
                new LoaiVatDung {IdLoaiVatDung = "L2", TenVatDung = "Tủ lạnh", DonGia = "2000"},
                new LoaiVatDung {IdLoaiVatDung = "L3", TenVatDung = "Điều hòa", DonGia = "3000"},
                new LoaiVatDung {IdLoaiVatDung = "L4", TenVatDung = "Bàn", DonGia = "500"},
                new LoaiVatDung {IdLoaiVatDung = "L5", TenVatDung = "Ghế", DonGia = "200"},


            });

            context.VatDungPhongs.AddRange(new VatDungPhong[]
            {
                new VatDungPhong {IdVatDung = "VD1", IdPhong = "1P1", IdLoaiVatDung = "L1", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD2", IdPhong = "1P1", IdLoaiVatDung = "L2", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD3", IdPhong = "1P1", IdLoaiVatDung = "L3", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD3", IdPhong = "1P1", IdLoaiVatDung = "L5", SoLuongBanDau = 3},
                new VatDungPhong {IdVatDung = "VD4", IdPhong = "1P2", IdLoaiVatDung = "L3", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD5", IdPhong = "1P3", IdLoaiVatDung = "L3", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD6", IdPhong = "1P1", IdLoaiVatDung = "L4", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD7", IdPhong = "2P1", IdLoaiVatDung = "L1", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD8", IdPhong = "2P2", IdLoaiVatDung = "L1", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD9", IdPhong = "2P3", IdLoaiVatDung = "L3", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD10", IdPhong = "3P1", IdLoaiVatDung = "L1", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD11", IdPhong = "3P2", IdLoaiVatDung = "L1", SoLuongBanDau = 1},


            });

            context.ChiTietSuDungDichVus.AddRange(new ChiTietSuDungDichVu[] { 
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV1", ID_Phong = "1P1", ID_DichVu = "DV1", ID_HoaDon = "HD1", 
                    NgaySuDung = new DateTime(2002, 07, 28), SoLuong = 2},
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV2", ID_Phong = "1P1", ID_DichVu = "DV1", ID_HoaDon = "HD1",
                    NgaySuDung = new DateTime(2002, 07, 28), SoLuong = 2},
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV3", ID_Phong = "1P1", ID_DichVu = "DV2", ID_HoaDon = "HD1",
                    NgaySuDung = new DateTime(2002, 07, 28), SoLuong = 2},
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV4", ID_Phong = "1P2", ID_DichVu = "DV1", ID_HoaDon = "HD2",
                    NgaySuDung = new DateTime(2002, 07, 28), SoLuong = 2},
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV5", ID_Phong = "2P3", ID_DichVu = "DV3", ID_HoaDon = "HD3",
                    NgaySuDung = new DateTime(2002, 07, 26), SoLuong = 2},
            });






            base.Seed(context);
        }
    }
}
