using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class LoaiVatDung
    {

        public string IdLoaiVatDung { get; set; }

        public string TenVatDung { get; set; }
        public string DonGia { get; set; }

    }
}
