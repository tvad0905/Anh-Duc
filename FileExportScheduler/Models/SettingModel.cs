using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExportScheduler.Models
{
    public class SettingModel
    {
        public bool AutoRun { get; set; }

        public int Interval { get; set; }

        public string ExportFilePath { get; set; }
    }
}
