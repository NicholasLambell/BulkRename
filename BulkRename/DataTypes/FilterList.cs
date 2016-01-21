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

        public FilterList Merge(FilterList filterList) {
            if (filterList != null) {
                foreach (DefaultFilters filter in filterList.defaultFilters) {
                    if (!this.defaultFilters.Contains(filter)) {
                        this.defaultFilters.Add(filter);
                    }
                }

                foreach (string[] filter in filterList.customFilters) {
                    if (this.customFilters.FindIndex(item => item[0] == filter[0] && item[1] == filter[1]) < 0) {
                        this.customFilters.Add(filter);
                    }
                }
            }
            return this;
        }
    }
}
