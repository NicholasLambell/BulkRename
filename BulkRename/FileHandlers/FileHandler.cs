using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRename {
    class FileHandler {
        public static bool Rename(string filePath, string rename) {
            if (!String.IsNullOrEmpty(filePath) && !String.IsNullOrEmpty(rename) && File.Exists(filePath)) {
                try {
                    FileInfo file = new FileInfo(filePath);
                    int iteration = 2;
                    string sIteration = "";

                    //Check to make sure file doesn't already exist with that name and auto incriment number if it does
                    while (File.Exists(file.Directory.FullName + @"\" + rename + sIteration + file.Extension)) {
                        sIteration = String.Format(" ({0})", iteration);
                        iteration++;
                    }
                    rename += sIteration;

                    file.MoveTo(file.Directory.FullName + @"\" + rename + file.Extension);
                    return true;

                } catch (Exception ex) {
                    ErrorHandler.LogError(ex.GetType() + ": " + ex.Message, true);
                }
            }
            return false;
        }
    }
}
