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
            List<DefaultFilters> defaultFilters = new List<DefaultFilters>();

            List<string[]> customFilters = new List<string[]>();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
