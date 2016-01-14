using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BulkRename {
    class Util {
        #region File Related Methods
        public static string GetExe() {
            return System.Reflection.Assembly.GetExecutingAssembly().Location;
        }

        public static string FileName(string input) {
            if (!String.IsNullOrEmpty(input) && File.Exists(input)) {
                string output = Path.GetFileNameWithoutExtension(new FileInfo(input).Name);
                return System.Diagnostics.Debugger.IsAttached ? output.Replace(".vshost", "") : output;
            }
            return input;
        }
        #endregion

        public static string[] SplitWords(string input) {
            if (!String.IsNullOrEmpty(input)) {
                return Regex.Split(input, " ");
            }
            return null;
        }

        public static string Capitalize(string input) {
            if (!String.IsNullOrEmpty(input)) {
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
            }
            return input;
        }
    }
}
