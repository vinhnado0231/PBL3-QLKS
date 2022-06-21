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
using PBL3.DTOVIEW;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.VIEW
{
    public partial class formQLHoaDon : Form
    {
        public formQLHoaDon()
        {
            InitializeComponent();
            setSearchCbb();
        }

        public void setSearchCbb()
        {
            for (int i = 1; i < dataGridViewHoaDon.Columns.Count; i++) 
            {
                searchCbb.Items.Add(dataGridViewHoaDon.Columns[i].HeaderText);
            }
        }

        public void showDataView()
        {
            dataGridViewHoaDon.DataSource = QLHoaDon_BLL.Instance.getAllHoaDonView().ToList();
            
        }

        public void setSTT()
        {
            for (int i = 0; i < dataGridViewHoaDon.Rows.Count; i++)
            {
                dataGridViewHoaDon.Rows[i].Cells["STT"].Value = i + 1;
            }






        }

        private void formQLHoaDon_Load(object sender, EventArgs e)
        {
            showDataView();
            setSTT();
        }

        private void dataGridViewHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idHoaDon = ((HoaDonView)dataGridViewHoaDon.SelectedRows[0].DataBoundItem).MaHoaDon;


            dataGridViewThuePhong.DataSource = QLHoaDon_BLL.Instance.getAllChiTietThuePhongView(idHoaDon).ToList();
            for (int i = 0; i < dataGridViewThuePhong.Rows.Count; i++)
            {
                dataGridViewThuePhong.Rows[i].Cells["STT1"].Value = i + 1;
            }
            dataGridViewDV.DataSource = QLHoaDon_BLL.Instance.getAllChiTietDVView(idHoaDon).ToList();
            for (int i = 0; i < dataGridViewDV.Rows.Count; i++)
            {
                dataGridViewDV.Rows[i].Cells["STT2"].Value = i + 1;
            }
        }


    }
}
