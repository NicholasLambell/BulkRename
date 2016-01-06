using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRename {
    public class FilterList {
        public List<DefaultFilters> defaultFilters;
        public List<string[]> customFilters;

        public FilterList(List<DefaultFilters> defaultFilters, List<string[]> customFilters) {
            this.defaultFilters = defaultFilters;
            this.customFilters = customFilters;
        }
    }
}
