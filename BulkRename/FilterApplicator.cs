using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRename {
    class FilterApplicator {
        #region Default Filters
        public static string ReplacePeriods(string fileName) {
            return fileName.Replace(".", " ");
        }

        public static string CapitalizeAll(string fileName) {
            //Split name into individual words
            string[] words = Util.SplitWords(fileName);

            //Cycle through words and capitalize all words
            for (int i = 0; i < words.Length; i++) {

            }

            return null;
        }

        public static string CapitalizeKey(string fileName) {
            string[] noCap = { "a", "an", "the", "and", "but", "or", "nor", "at", "by", "for", "from", "in", "into", "of", "off", "on", "up", "with", "to", "as", "o,Clock" };

            //Split name into individual words
            string[] words = Util.SplitWords(fileName);

            //Cycle through words and capitalize all key words
            for (int i = 0; i < words.Length; i++) {

            }

            return null;
        }
        #endregion

        public static string CustomFilter(string fileName, string filterIn, string filterOut) {
            return fileName.Replace(filterIn, filterOut);
        }
    }
}
