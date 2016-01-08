using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRename {
    class FilterHandler {
        private static List<string> _renameFiles;

        public static void ProcessFilters(FilterList filterList, List<FileInfo> files) {
            //Initialize list of file names
            _renameFiles = new List<string>();
            foreach (FileInfo info in files) {
                _renameFiles.Add(Util.FileName(info.Name));
            }

            //Run filter processors
            ProcessDefaultFilters(filterList.defaultFilters);
            ProcessCustomFilters(filterList.customFilters);

            //Rename files
            if (files.Count == _renameFiles.Count) {
                for (int i = 0; i < files.Count; i++) {
                    if (Util.FileName(files[i].Name) != _renameFiles[i]) {
                        FileHandler.Rename(files[i].FullName, _renameFiles[i]);
                    }
                }
            } else {
                ErrorHandler.LogError("File and Rename count missmatch, please try again.", true);
            }
        }

        private static void ProcessDefaultFilters(List<DefaultFilters> filters) {
            for (int i = 0; i < _renameFiles.Count; i++) {
                foreach (DefaultFilters filter in filters) {
                    switch (filter) {
                        case DefaultFilters.ReplacePeriods:
                            _renameFiles[i] = FilterApplicator.ReplacePeriods(_renameFiles[i]);
                            break;

                        case DefaultFilters.CapitalizeAll:
                            _renameFiles[i] = FilterApplicator.CapitalizeAll(_renameFiles[i]);
                            break;

                        case DefaultFilters.CapitalizeKey:
                            _renameFiles[i] = FilterApplicator.CapitalizeKey(_renameFiles[i]);
                            break;
                    }
                }
            }
        }

        private static void ProcessCustomFilters(List<string[]> filters) {
            for (int i = 0; i < _renameFiles.Count; i++) {
                foreach (string[] filter in filters) {
                    _renameFiles[i] = FilterApplicator.CustomFilter(_renameFiles[i], filter[0], filter[1]);
                }
            }
        }
    }
}
