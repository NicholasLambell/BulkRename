using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BulkRename {
    class FileHandler {
        public static bool Rename(FileInfo file, string rename) {
            if (file != null && file.Exists && !String.IsNullOrEmpty(rename)) {
                int iteration = 1;

                //Regex regex = new Regex(@" (\d{})");
                string fileName = Util.FileName(file.Name);

                //if (regex.IsMatch(fileName)) {
                //    Match match = regex.Match(fileName);
                //    string sMatch = match.Value;

                //    string sIteration = (fileName.Length >= 4) ? fileName.Substring(fileName.Length - 4) : "";

                //    iteration = !String.IsNullOrEmpty(sIteration) ? Convert.ToInt32(sIteration.Substring(2, 1)) : iteration;
                //}

                if (fileName != null && fileName.Length >= 4) {
                    int iterationGet = GetIteration(fileName);
                    iteration = (iterationGet > iteration) ? iterationGet : iteration;
                }

                while (!ApplyRename(file, rename, iteration)) {
                    iteration++;
                }
                return true;
            }
            return false;
        }

        //public static bool Rename(string filePath, string rename) {
        private static bool ApplyRename(FileInfo file, string rename, int iteration) {
            //if (!String.IsNullOrEmpty(filePath) && !String.IsNullOrEmpty(rename) && File.Exists(filePath)) {
            if (file != null && file.Exists && !String.IsNullOrEmpty(rename)) {
                //FileInfo file = null;

                try {
                    //string sIteration = (iteration >= 2) ? String.Format(" ({0})", iteration) : "";
                    string sIteration = "";

                    if (iteration >= 2) {
                        sIteration = String.Format(" ({0})", iteration);

                        Regex regex = new Regex(@" \(\d+\)$");
                        if (regex.IsMatch(rename)) {
                            rename = regex.Replace(rename, "");
                        }
                    }


                    //file = new FileInfo(filePath);
                    file.MoveTo(file.Directory.FullName + @"\" + rename + sIteration + file.Extension);
                    return true;

                } catch (IOException ex) {
                    //ErrorHandler.LogError(ex.GetType().ToString(), true);

                    //if (file != null && File.Exists(file.Directory.FullName + @"\" + rename + file.Extension)) {
                    //    int iteration = 2;
                    //    string sIteration = "";

                    //    //Continue incrimenting the iteration until no file with name exists
                    //    while (File.Exists(file.Directory.FullName + @"\" + rename + sIteration + file.Extension)) {
                    //        sIteration = String.Format(" ({0})", iteration);
                    //        iteration++;
                    //    }

                    //    //return Rename(filePath, rename + sIteration);
                    //    return Rename(file, rename + sIteration);
                    //}
                } catch (Exception ex) {
                    ErrorHandler.LogError(ex.GetType() + ": " + ex.Message, true);
                }
            }
            return false;
        }

        private static int GetIteration(string fileName) {
            Regex regex = new Regex(@"(?<=\()\d+(?=\)$)");
            Match match = regex.Match(fileName);
            int output;
            return (match.Groups[0].Value != String.Empty && Int32.TryParse(match.Groups[0].Value, out output)) ? output : 0;
        }
    }
}
