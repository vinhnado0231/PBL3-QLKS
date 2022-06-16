using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QLKS.BLL
{
    public class QLBook_BLL
    {
        private static QLBook_BLL _Instance;
//        QLKS db = new QLKS();
        public static QLBook_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLBook_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        public QLBook_BLL() { }
    }
}