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
                    DropCreateDatabaseAlways<QLKS>
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
                new LoaiPhong {IdLoaiPhong = "1T", TenLoaiPhong = "Phòng đơn thường", SoNguoiToiDa = 2},
                new LoaiPhong {IdLoaiPhong = "2T", TenLoaiPhong = "Phòng đôi thường", SoNguoiToiDa = 4},
                new LoaiPhong {IdLoaiPhong = "1V", TenLoaiPhong = "Phòng đơn VIP", SoNguoiToiDa = 3},
                new LoaiPhong {IdLoaiPhong = "2V", TenLoaiPhong = "Phòng đôi VIP", SoNguoiToiDa = 6},

            });

            context.DichVus.AddRange(new DichVu[]
            {
                new DichVu {IdDichVu = "DV1", TenDichVu = "Coca", DonGia = "10"},
                new DichVu {IdDichVu = "DV2", TenDichVu = "Mì tôm", DonGia = "30"},
                new DichVu {IdDichVu = "DV3", TenDichVu = "Bánh mì", DonGia = "25"},
                new DichVu {IdDichVu = "DV4", TenDichVu = "Massage", DonGia = "100"},
                new DichVu {IdDichVu = "DV5", TenDichVu = "Karaoke", DonGia = "80"},
                new DichVu {IdDichVu = "DV6", TenDichVu = "Bida", DonGia = "50"},
            });

            context.KhachHangs.AddRange(new KhachHang[]
            {
                new KhachHang{IdKhachHang="KH01",Ten="Nguyễn Văn A",GioiTinh=true,CMND="201642168",QuocTich="Việt Nam",GhiChu="Không",SDT="0447494380",NgaySinh=new DateTime(2002,1,1)},
                new KhachHang{IdKhachHang="KH02",Ten="Nguyễn Thị B",GioiTinh=false,CMND="201837437",QuocTich="Việt Nam",GhiChu="Không",SDT="0932666342",NgaySinh=new DateTime(2002,1,1)},
                new KhachHang{IdKhachHang="KH03",Ten="Trần Hồng C",GioiTinh=false,CMND="211889168",QuocTich="Việt Nam",GhiChu="Không",SDT="0140426734",NgaySinh=new DateTime(2002,1,1)},
                new KhachHang{IdKhachHang="KH04",Ten="Lê Văn D",GioiTinh=true,CMND="201829112",QuocTich="Việt Nam",GhiChu="Không",SDT="584638596",NgaySinh=new DateTime(2002,1,1)},
                new KhachHang{IdKhachHang="KH05",Ten="Nguyễn Thị E",GioiTinh=false,CMND="2029819203",QuocTich="Việt Nam",GhiChu="Không",SDT="0865245213",NgaySinh=new DateTime(2002,1,1)},
                new KhachHang{IdKhachHang="KH06",Ten="Nguyễn Ngọc F",GioiTinh=false,CMND="212821128",QuocTich="Việt Nam",GhiChu="Không",SDT="0777229083",NgaySinh=new DateTime(2002,1,1)},
                new KhachHang{IdKhachHang="KH07",Ten="Phạm Văn G",GioiTinh=true,CMND="201824567",QuocTich="Việt Nam",GhiChu="Không",SDT="0716440909",NgaySinh=new DateTime(2002,1,1)},
                new KhachHang{IdKhachHang="KH08",Ten="Huỳnh Đinh H",GioiTinh=true,CMND="201876543",QuocTich="Việt Nam",GhiChu="Không",SDT="0987456789",NgaySinh=new DateTime(2002,1,1)}

            });

            context.TaiKhoans.AddRange(new TaiKhoan[]
            {
                new TaiKhoan {TenDangNhap = "NhanVien1", IdTaiKhoan = "1", MatKhau = "nhanvien", TrangThai = true},
                new TaiKhoan {TenDangNhap = "NhanVien2", IdTaiKhoan = "2", MatKhau = "nhanvien", TrangThai = false},
                new TaiKhoan {TenDangNhap = "NhanVien3", IdTaiKhoan = "3", MatKhau = "nhanvien", TrangThai = false},
                new TaiKhoan {TenDangNhap = "NhanVien4", IdTaiKhoan = "4", MatKhau = "nhanvien", TrangThai = false},
                new TaiKhoan {TenDangNhap = "Admin", IdTaiKhoan = "5", MatKhau = "admin", TrangThai = false},

            });

            context.NhanViens.AddRange(new NhanVien[]
            {
                new NhanVien {IdNhanVien = "NV1",  IdChucVu = "NV", Ten = "NNA", GioiTinh = true, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam = new DateTime(2022, 05, 01), IdTaiKhoan = "1"},
                new NhanVien {IdNhanVien = "NV2",  IdChucVu = "NV", Ten = "NNB", GioiTinh = false, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam = new DateTime(2022, 05, 01) ,IdTaiKhoan = "2"},
                new NhanVien {IdNhanVien = "NV3",  IdChucVu = "NV", Ten = "NNC", GioiTinh = true, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam =  new DateTime(2022, 05, 01), IdTaiKhoan = "3"},
                new NhanVien {IdNhanVien = "NV4",  IdChucVu = "NV", Ten = "NND", GioiTinh = false, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam =  new DateTime(2022, 05, 01), IdTaiKhoan = "4"},
                new NhanVien {IdNhanVien = "NV6", IdChucVu = "AD", Ten = "NNA", GioiTinh = true, CMND = "1234698",
                SDT = "13245789", DiaChi = "A", NgayVaoLam =  new DateTime(2022, 05, 01), IdTaiKhoan = "5"},

            });

            context.HoaDons.AddRange(new HoaDon[] { 
                new HoaDon {IdHoaDon = "HD1", IDKhachHang = "KH01", IDNhanVien = "NV1", NgayHoaDon = new DateTime(2022, 07, 07), TinhTrang = true, TienTraTruoc = 30},
                new HoaDon {IdHoaDon = "HD2", IDKhachHang = "KH01", IDNhanVien = "NV2", NgayHoaDon = new DateTime(2022, 07, 07), TinhTrang = true, TienTraTruoc = 30},
                new HoaDon {IdHoaDon = "HD3", IDKhachHang = "KH02", IDNhanVien = "NV3", NgayHoaDon = new DateTime(2022, 07, 07), TinhTrang = true, TienTraTruoc = 30},
                new HoaDon {IdHoaDon = "HD4", IDKhachHang = "KH03", IDNhanVien = "NV4", NgayHoaDon = new DateTime(2022, 07, 07), TinhTrang = true, TienTraTruoc = 30},
                new HoaDon {IdHoaDon = "HD5", IDKhachHang = "KH04", IDNhanVien = "NV6", NgayHoaDon = new DateTime(2022, 07, 07), TinhTrang = true, TienTraTruoc = 30},

            });


            context.ChiTietThuePhongs.AddRange(new ChiTietThuePhong[]
            {
                new ChiTietThuePhong { IdChiTietThuePhong = "CTTP1", IDHoaDon = "HD1", IDPhong = "1P1", /* IdNhanVien = "NV1",*/ NgayCheckIn = new DateTime(2022, 07, 07), NgayCheckOut = new DateTime(2022, 07, 08)},
                new ChiTietThuePhong {IdChiTietThuePhong = "CTTP2", IDHoaDon = "HD2", IDPhong = "1P2", /* IdNhanVien = "NV2",*/ NgayCheckIn = new DateTime(2022, 07, 07), NgayCheckOut = new DateTime(2022, 07, 08)},
                new ChiTietThuePhong {IdChiTietThuePhong = "CTTP3", IDHoaDon = "HD3", IDPhong = "2P3", /* IdNhanVien = "NV2",*/ NgayCheckIn = new DateTime(2022, 07, 07), NgayCheckOut = new DateTime(2022, 07, 08)},
                new ChiTietThuePhong {IdChiTietThuePhong = "CTTP4", IDHoaDon = "HD4", IDPhong = "1P1", /*IdNhanVien = "NV3",*/ NgayCheckIn = new DateTime(2022, 07, 07), NgayCheckOut = new DateTime(2022, 07, 08)},
            });

            context.Books.AddRange(new Book[] { 
                new Book {IdBook = "B1", IdKhachHang = "KH01", IdNhanVien = "NV1", TienCoc = 300},
                new Book {IdBook = "B2", IdKhachHang = "KH02", IdNhanVien = "NV1", TienCoc = 0},
                new Book {IdBook = "B3", IdKhachHang = "KH03", IdNhanVien = "NV2", TienCoc = 300},
                new Book {IdBook = "B4", IdKhachHang = "KH04", IdNhanVien = "NV3", TienCoc = 0},
                new Book {IdBook = "B5", IdKhachHang = "KH05", IdNhanVien = "NV4", TienCoc = 300},
                new Book {IdBook = "B6", IdKhachHang = "KH06", IdNhanVien = "NV6", TienCoc = 0},

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
                new ChiTietBook{IdChiTietBook = "CTB1",  IdBook = "B1", IdPhong = "1P1", NgayCheckInPhong = new DateTime(2022, 07, 04), NgayCheckOut = new DateTime(2022, 07, 06)},
                new ChiTietBook{IdChiTietBook = "CTB2", IdBook = "B1", IdPhong = "1P2", NgayCheckInPhong = new DateTime(2022, 07, 03), NgayCheckOut = new DateTime(2022, 07, 06)},
                new ChiTietBook{IdChiTietBook = "CTB3", IdBook = "B1", IdPhong = "2P3", NgayCheckInPhong = new DateTime(2022, 07, 02), NgayCheckOut = new DateTime(2022, 07, 08)},
                new ChiTietBook{IdChiTietBook = "CTB4", IdBook = "B2", IdPhong = "1P1", NgayCheckInPhong = new DateTime(2022, 07, 08), NgayCheckOut = new DateTime(2022, 07, 09)},
                new ChiTietBook{IdChiTietBook = "CTB5", IdBook = "B3", IdPhong = "1P1", NgayCheckInPhong = new DateTime(2022, 07, 01), NgayCheckOut = new DateTime(2022, 07, 02)},
                new ChiTietBook{IdChiTietBook = "CTB6", IdBook = "B4", IdPhong = "1P1", NgayCheckInPhong = new DateTime(2022, 07, 03)},

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
                new VatDungPhong {IdVatDung = "VD4", IdPhong = "1P1", IdLoaiVatDung = "L5", SoLuongBanDau = 3},
                new VatDungPhong {IdVatDung = "VD5", IdPhong = "1P2", IdLoaiVatDung = "L3", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD6", IdPhong = "1P3", IdLoaiVatDung = "L3", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD7", IdPhong = "1P1", IdLoaiVatDung = "L4", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD8", IdPhong = "2P1", IdLoaiVatDung = "L1", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD9", IdPhong = "2P2", IdLoaiVatDung = "L1", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD10", IdPhong = "2P3", IdLoaiVatDung = "L3", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD11", IdPhong = "3P1", IdLoaiVatDung = "L1", SoLuongBanDau = 1},
                new VatDungPhong {IdVatDung = "VD12", IdPhong = "3P2", IdLoaiVatDung = "L1", SoLuongBanDau = 1},


            });

            context.ChiTietSuDungDichVus.AddRange(new ChiTietSuDungDichVu[] { 
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV1", ID_Phong = "1P1", ID_DichVu = "DV1", ID_HoaDon = "HD1", 
                    NgaySuDung = new DateTime(2002, 07, 07), SoLuong = 2},
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV2", ID_Phong = "1P1", ID_DichVu = "DV1", ID_HoaDon = "HD1",
                    NgaySuDung = new DateTime(2002, 07, 07), SoLuong = 2},
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV3", ID_Phong = "1P1", ID_DichVu = "DV2", ID_HoaDon = "HD1",
                    NgaySuDung = new DateTime(2002, 07, 07), SoLuong = 2},
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV4", ID_Phong = "1P2", ID_DichVu = "DV1", ID_HoaDon = "HD2",
                    NgaySuDung = new DateTime(2002, 07, 07), SoLuong = 2},
                new ChiTietSuDungDichVu {ID_ChiTietSuDungDichVu = "CTDV5", ID_Phong = "2P3", ID_DichVu = "DV3", ID_HoaDon = "HD3",
                    NgaySuDung = new DateTime(2002, 07, 07), SoLuong = 2},
            });






            base.Seed(context);
        }
    }
}
