using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExportScheduler.Models
{
    public class DeviceModel
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }

        public int TrangThaiKetNoi { get; set; }

        public Dictionary<string, DuLieuModel> ListDuLieuChoTungPLC = new Dictionary<string, DuLieuModel>();

        public TypeEnum TypeModel { get; set; }
    }


}
