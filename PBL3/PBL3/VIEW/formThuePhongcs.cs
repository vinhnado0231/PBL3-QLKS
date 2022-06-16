using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.DTOVIEW;

namespace PBL3.VIEW
{
    public partial class formThuePhongcs : Form
    {
        public formThuePhongcs()
        {
            InitializeComponent();
         
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTenPhong.Items.Clear();
        }

        private void butChonKhachHang_Click(object sender, EventArgs e)
        {
            formChonKhachHang f = new formChonKhachHang();
            f.d = new formChonKhachHang.Mydel(ShowKH);
            f.Show();
        }
       public void ShowKH(string MaKH)
        {
        }

        private void formThuePhongcs_Load(object sender, EventArgs e)
        {

        }
    }
}
