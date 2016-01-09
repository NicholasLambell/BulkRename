using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkRename {
    public partial class FormFilters : Form {
        public FormFilters() {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            //Create and populate default filters list
            List<DefaultFilters> defaultFilters = new List<DefaultFilters>();

            for (int i = 0; i < chklstComFilters.Items.Count; i++) {
                if (chklstComFilters.GetItemCheckState(i) == CheckState.Checked) {
                    defaultFilters.Add((DefaultFilters)i);
                }
            }

            //Create and populate custom filters list
            List<string[]> customFilters = new List<string[]>();

            foreach (DataGridViewRow row in gvFilters.Rows) {
                if (row.Index < gvFilters.Rows.Count - 1) {
                    customFilters.Add(new string[] { row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString() });
                }
            }

            //Set form tag to filter list container object
            this.Tag = new FilterList(defaultFilters, customFilters);

            //If both lists are empty set tag to null
            if (defaultFilters.Count == 0 && customFilters.Count == 0) {
                this.Tag = null;
            }

            //Set dialog result to return to main form
            this.DialogResult = DialogResult.OK;



            //FilterList filterList = new FilterList(defaultFilters, customFilters);
            //string message = "Default Filters:\n";

            //foreach (DefaultFilters filter in filterList.defaultFilters) {
            //    message += filter.ToString() + "\n";
            //}

            //message += "\n\nCustom Filters:\n";

            //foreach (string[] filter in filterList.customFilters) {
            //    message += filter[0] + " > " + filter[1] + "\n";
            //}

            //MessageBox.Show(message);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
