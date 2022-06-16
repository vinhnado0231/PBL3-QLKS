using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ChiTietBook
    {

        public string IdPhong { get; set; }

        public string IdBook { get; set; }

        public DateTime NgayCheckInPhong { get; set; }
        public DateTime NgayCheckOut { get; set; }


    }
}
