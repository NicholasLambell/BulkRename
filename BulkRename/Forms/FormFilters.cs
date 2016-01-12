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
        public FormFilters(FilterList filterList) {
            InitializeComponent();

            SetFilters(filterList);
        }

        private void SetFilters(FilterList filterList) {
            if (filterList != null) {
                //Set default filters
                foreach (DefaultFilters filter in filterList.defaultFilters) {
                    chklstComFilters.SetItemChecked((int)filter, true);
                }

                //Set custom filters
                foreach (string[] filter in filterList.customFilters) {
                    gvFilters.Rows.Add(filter[0], filter[1]);

                    //DataGridViewRow row = new DataGridViewRow();
                    ////row.Cells.;

                    //row.Cells[0].Value = filter[0];
                    //row.Cells[1].Value = filter[1];

                    //gvFilters.Rows.Add(row);
                }
            }
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
                    string cell0 = (row.Cells[0].Value != null) ? row.Cells[0].Value.ToString() : "";
                    string cell1 = (row.Cells[1].Value != null) ? row.Cells[1].Value.ToString() : "";

                    customFilters.Add(new string[] { cell0, cell1 });
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
