using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QLKS.BLL
{
    public class QLKhachHang_BLL
    {
        private static QLKhachHang_BLL _Instance;
        //       QLKS db = new QLKS();
        public static QLKhachHang_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLKhachHang_BLL();
                }
                return _Instance;
            }
            private set { }

        }
        public QLKhachHang_BLL() { }
    }
}