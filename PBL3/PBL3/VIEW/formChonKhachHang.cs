using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PBL3.VIEW
{
    public partial class formChonKhachHang : Form
    {
        public delegate void Mydel(string a);
        public Mydel d;
        public formChonKhachHang()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {

            d(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
