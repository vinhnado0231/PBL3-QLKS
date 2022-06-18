using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTOVIEW;

namespace PBL3.VIEW
{
    public partial class formThanhToanHoaDon : Form
    {
        QLKS qlks = new QLKS();
        string IdPhong = "1P1";
        public formThanhToanHoaDon()
        {
            InitializeComponent();
            setCbbTenDV();
            txtDonGia.Enabled = false;
            txtMaDichVu.Enabled = false;
        }

        public void setCbbTenDV()
        {
            
            foreach (DichVu i in ThanhToanHoaDon_BLL.Instance.GetAllDichVu())
            {
                cbbTenDV.Items.Add(new CBBItem { Text = i.TenDichVu, Value = i.IdDichVu});
            }
        }

        public void ShowView()
        {
            dataGridView.DataSource = ThanhToanHoaDon_BLL.Instance.GetThanhToanDVView(IdPhong).ToList();


            HoaDon data = ThanhToanHoaDon_BLL.Instance.GetHoaDonByIdPhong(IdPhong);

            lbMaHoaDon.Text = data.IdHoaDon.ToString();
            lbMaKhachHang.Text = data.IDKhachHang.ToString();
            lbTenKhachHang.Text = data.KhachHang.Ten.ToString();
            lbTenPhong.Text = ThanhToanHoaDon_BLL.Instance.GetChiTietThuePhongByIdPhong(IdPhong).Phong.TenPhong;
            lbNhanVien.Text = data.NhanVien.Ten.ToString();
            lbNgayLap.Text = data.NgayHoaDon.ToString();
            lbNgayThue.Text = ThanhToanHoaDon_BLL.Instance.GetChiTietThuePhongByIdPhong(IdPhong).NgayCheckIn.ToString();
            lbNgayTra.Text = ThanhToanHoaDon_BLL.Instance.GetChiTietThuePhongByIdPhong(IdPhong).NgayCheckOut.ToString();
            lbGiaPhong.Text = ThanhToanHoaDon_BLL.Instance.GetChiTietThuePhongByIdPhong(IdPhong).Phong.DonGiaPhong.ToString();

            int TongtienDV = 0;
            foreach (ThanhToanDichVuView i in ThanhToanHoaDon_BLL.Instance.GetThanhToanDVView(IdPhong))
            {
                TongtienDV += i.TongTien;
            }

            lbTongGiaDV.Text = TongtienDV.ToString();
            lbTienTraTruoc.Text = data.TienTraTruoc.ToString();
            lbTongTien.Text = (Convert.ToInt32(lbGiaPhong.Text) + TongtienDV + data.TienTraTruoc).ToString();
        }

        private void formThanhToanHoaDon_Load(object sender, EventArgs e)
        {

            ShowView();
        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ThanhToanDichVuView data = (ThanhToanDichVuView)dataGridView.SelectedRows[0].DataBoundItem;
            txtMaDichVu.Text = data.MaDichVu.ToString();
            foreach (CBBItem i in cbbTenDV.Items)
            {
                if (i.Text == data.TenDichVu)
                {
                    cbbTenDV.SelectedItem = i;
                }
            }
            cbbTenDV.Enabled = false;
            txtSoLuong.Text = data.SoLuong.ToString();
            txtDonGia.Text = data.DonGia.ToString();

            dateTimePicker1.Value = data.NgaySuDung;
            dateTimePicker1.Enabled = false;
        }

        private void btnDatLaiTxt_Click(object sender, EventArgs e)
        {
            txtMaDichVu.Text = "";
            cbbTenDV.Enabled = true;
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Enabled = true;
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                List<ThanhToanDichVuView> data = new List<ThanhToanDichVuView>();
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    data.Add((ThanhToanDichVuView)row.DataBoundItem);
                }

                foreach (ChiTietSuDungDichVu i in ThanhToanHoaDon_BLL.Instance.GetAllCTDichVuByIdPhong(IdPhong))
                {
                    foreach (ThanhToanDichVuView j in data)
                    {
                        if (i.ID_DichVu == j.MaDichVu && i.NgaySuDung == j.NgaySuDung)
                        {
                            ThanhToanHoaDon_BLL.Instance.DelChiTietDicVu(i);
                        }
                    }
                }
            }
            this.btnDatLaiTxt_Click(sender, e);
            ShowView();

        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {

            if (txtSoLuong.Text == "" || cbbTenDV.SelectedItem == null)
            {
                MessageBox.Show("Nhập thiếu thông tin");
                return;
            }

            foreach (ChiTietSuDungDichVu i in ThanhToanHoaDon_BLL.Instance.GetAllCTDichVuByIdPhong(IdPhong))
            {
                if (((CBBItem)cbbTenDV.SelectedItem).Value == i.ID_DichVu && dateTimePicker1.Value.Date == i.NgaySuDung)
                {
                    MessageBox.Show("Dịch vụ đã có trong danh sách");
                    return;
                }
            }

            ThanhToanHoaDon_BLL.Instance.AddChiTietDichVu(new ChiTietSuDungDichVu
            {
                ID_ChiTietSuDungDichVu = "CTDV" + (ThanhToanHoaDon_BLL.Instance.GetAllChiTietSDDV().Count + 1),
                ID_Phong = IdPhong.ToString(),
                ID_DichVu = ((CBBItem)cbbTenDV.SelectedItem).Value.ToString(),
                ID_HoaDon = ThanhToanHoaDon_BLL.Instance.GetHoaDonByIdPhong(IdPhong).IdHoaDon.ToString(),
                NgaySuDung = Convert.ToDateTime(dateTimePicker1.Value),
                SoLuong = Convert.ToInt32(txtSoLuong.Text),
                TrangThai = false,
            });
            this.btnDatLaiTxt_Click(sender, e);
            ShowView();
        }

        private void btnEditDV_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                ThanhToanDichVuView data = (ThanhToanDichVuView)dataGridView.SelectedRows[0].DataBoundItem;
                ThanhToanHoaDon_BLL.Instance.UpdateChiTietDichVu(data.MaDichVu, Convert.ToInt32(txtSoLuong.Text), IdPhong, data.NgaySuDung);
                ShowView();
            }

        }

        private void cbbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdDichVu = ((CBBItem)cbbTenDV.SelectedItem).Value.ToString();

            txtDonGia.Text = ThanhToanHoaDon_BLL.Instance.GetDichVuByIdDV(IdDichVu).DonGia.ToString();
            txtMaDichVu.Text = ThanhToanHoaDon_BLL.Instance.GetDichVuByIdDV(IdDichVu).IdDichVu.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanHoaDon_BLL.Instance.GetHoaDonByIdPhong(IdPhong).TinhTrang = true;
            ThanhToanHoaDon_BLL.Instance.GetChiTietThuePhongByIdPhong(IdPhong).TrangThai = true;
            ThanhToanHoaDon_BLL.Instance.GetCtSDDVByIdPhong(IdPhong).TrangThai = true;
            ThanhToanHoaDon_BLL.Instance.GetChiTietBookByIdPhong(IdPhong).TrangThai = true;
            MessageBox.Show("Hóa đơn đã được thanh toán");

        }
    }
}
