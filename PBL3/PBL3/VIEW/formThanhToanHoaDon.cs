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

namespace PBL3.VIEW
{
    public partial class formThanhToanHoaDon : Form
    {
        public formThanhToanHoaDon()
        {
            InitializeComponent();
        }



        private void formThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ThanhToanHoaDon_BLL.Instance.GetHoaDonByIdPhong("1P1").ToString());
        }
    }
}
