using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRename {
    class Util {
        public static string GetExe() {
            return System.Reflection.Assembly.GetExecutingAssembly().Location;
        }

        public static string FileName(string input) {
            if (File.Exists(input)) {
                string output = Path.GetFileNameWithoutExtension(new FileInfo(input).Name);
                return System.Diagnostics.Debugger.IsAttached ? output.Replace(".vshost", "") : output;
            }
            return null;
        }
    }
}
