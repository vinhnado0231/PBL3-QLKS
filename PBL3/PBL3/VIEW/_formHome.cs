using Room;
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
    public partial class _formHome : Form
    {
        public _formHome()
        {
            InitializeComponent();
 
        }

        private void flowLayoutPanelTang3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelTang2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelTang1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomHotel1_Load(object sender, EventArgs e)
        {

        }
        public void roomDoubleClick(object sender,MouseEventArgs e)
        {
            
            if (((RoomHotel)sender).roomStatus == "Phòng Trống")
            {
                ((RoomHotel)sender).BackColor = System.Drawing.Color.Orange;
                ((RoomHotel)sender).roomStatus = "Đang có khách";
                ((RoomHotel)sender).ChangePic(0);
            }
            else
            {
                ((RoomHotel)sender).BackColor = System.Drawing.Color.LightSeaGreen;
                ((RoomHotel)sender).roomStatus = "Phòng Trống";
                ((RoomHotel)sender).ChangePic(1);
            }
        }
        private void roomHotel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel13_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
