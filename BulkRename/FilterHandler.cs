using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRename {
    class FilterHandler {
        private List<FileInfo> _files;

        public void ProcessFilters(FilterList filterList, List<FileInfo> files) {
            _files = files;
        }

        private void ProcessDefaultFilters(List<DefaultFilters> filters) {

        }

        private void ProcessCustomFilters(List<string[]> filters) {

        }
    }
}
