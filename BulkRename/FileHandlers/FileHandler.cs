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
                FileInfo file = null;

                try {
                    file = new FileInfo(filePath);
                    file.MoveTo(file.Directory.FullName + @"\" + rename + file.Extension);
                    return true;

                } catch (IOException ex) {
                    ErrorHandler.LogError(ex.GetType().ToString(), true);

                    if (file != null && File.Exists(file.Directory.FullName + @"\" + rename + file.Extension)) {
                        int iteration = 2;
                        string sIteration = "";

                        //Continue incrimenting the iteration until no file with name exists
                        while (File.Exists(file.Directory.FullName + @"\" + rename + sIteration + file.Extension)) {
                            sIteration = String.Format(" ({0})", iteration);
                            iteration++;
                        }

                        return Rename(filePath, rename + sIteration);
                    }
                } catch (Exception ex) {
                    ErrorHandler.LogError(ex.GetType() + ": " + ex.Message, true);
                }
            }
            return false;
        }
    }
}
