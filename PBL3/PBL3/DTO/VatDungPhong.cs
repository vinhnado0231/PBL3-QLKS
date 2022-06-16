using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class VatDungPhong
    {
        public string IdVatDung { get; set; } 
        public string IdPhong { get; set; }
        public int SoLuongBanDau { get; set; }

    }
}
