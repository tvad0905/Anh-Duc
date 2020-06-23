using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExportScheduler.Models
{
    public class DuLieuModel

    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string DonViDo { get; set; }
        public int GiaTri { get; set; }

        public DateTime ThoiGianDocGiuLieu { get; set; }
    }
}
