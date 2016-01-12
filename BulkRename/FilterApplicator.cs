using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRename {
    class FilterApplicator {
        #region Default Filters
        public static string ReplacePeriods(string fileName) {
            if (!String.IsNullOrEmpty(fileName)) {
                return fileName.Replace(".", " ");
            }
            return fileName;
        }

        public static string CapitalizeAll(string fileName) {
            if (!String.IsNullOrEmpty(fileName)) {
                ////Split name into individual words
                //string[] words = Util.SplitWords(fileName);

                ////Cycle through words and capitalize all words
                //for (int i = 0; i < words.Length; i++) {
                //    words[i] = Util.Capitalize(words[i]);
                //}

                ////Return formatted string
                //return String.Join(" ", words);
                return Util.Capitalize(fileName);
            }
            return fileName;
        }

        public static string CapitalizeKey(string fileName) {
            if (!String.IsNullOrEmpty(fileName)) {
                string[] noCap = { "a", "an", "the", "and", "but", "or", "nor", "at", "by", "for", "from", "in", "into", "of", "off", "on", "up", "with", "to", "as", "o,Clock" };

                //Split name into individual words
                string[] words = Util.SplitWords(fileName);

                if (words.Length > 0) {
                    int last = words.Length - 1;

                    //Capitalize first and last word
                    words[0] = Util.Capitalize(words[0]);
                    words[last] = Util.Capitalize(words[last]);

                    //Cycle through words and capitalize all key words
                    for (int i = 1; i < words.Length - 1; i++) {
                        if (words[i].Length >= 5) {
                            words[i] = Util.Capitalize(words[i]);
                        } else if (!noCap.Contains(words[i])) {
                            words[i] = Util.Capitalize(words[i]);
                        }
                    }
                }
            }
            return fileName;
        }
        #endregion

        public static string CustomFilter(string fileName, string filterIn, string filterOut) {
            if (String.IsNullOrEmpty(fileName)) {
                return fileName.Replace(filterIn, filterOut);
            }
            return fileName;
        }
    }
}
