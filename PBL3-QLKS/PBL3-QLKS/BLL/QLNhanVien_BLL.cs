using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QLKS.BLL
{
    public class QLNhanVien_BLL
    {
        private static QLNhanVien_BLL _Instance;
        //        QLKS db = new QLKS();
        public static QLNhanVien_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLNhanVien_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        public QLNhanVien_BLL() { }
    }
}
