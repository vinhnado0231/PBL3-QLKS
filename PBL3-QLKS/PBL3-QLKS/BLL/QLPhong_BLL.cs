﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QLKS.BLL
{
    public class QLPhong_BLL
    {
        private static QLPhong_BLL _Instance;
        //        QLKS db = new QLKS();
        public static QLPhong_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLPhong_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        public QLPhong_BLL() { }
    }
}