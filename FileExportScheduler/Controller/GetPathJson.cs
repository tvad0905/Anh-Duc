using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileExportScheduler.Controller
{
    public static class GetPathJson
    {
        public static string getPathConfig(string pathFile)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var pathCombine = path.Substring(0, path.LastIndexOf("\\", path.LastIndexOf("\\") - 1)) +
                pathFile;
            return pathCombine;
        }
    }
}
