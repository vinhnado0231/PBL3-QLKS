using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QLKS.BLL
{
    public class QLNguoiDung_BLL
    {
        private static QLNguoiDung_BLL _Instance;
        //        QLKS db = new QLKS();
        public static QLNguoiDung_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLNguoiDung_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        public QLNguoiDung_BLL() { }
    }
}
