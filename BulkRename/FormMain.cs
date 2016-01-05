using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkRename {
    public partial class FormMain : Form {
        string[] _args;
        List<FileInfo> _files;

        public FormMain() {
            InitializeComponent();

            //Initialize files list
            _files = new List<FileInfo>();

            //Initialize list view with columns
            lstFiles.Columns.Add("File", -2);
            lstFiles.Columns.Add("Path", -2);

            //Get command line arguments and process them
            _args = Environment.GetCommandLineArgs();
            ProcessArgs();

            //Write file info to list
            WriteList();

            
        }

        #region Misc Methods
        private void ProcessArgs() {
            foreach (string arg in _args) {
                if (File.Exists(arg) && Util.FileName(arg) != Util.FileName(Util.GetExe())) {
                    _files.Add(new FileInfo(arg));
                }
            }
        }

        private void WriteList() {
            foreach (FileInfo file in _files) {
                //Create list view item
                ListViewItem item = new ListViewItem(file.Name);
                item.Checked = true;

                //Create list view sub item
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, file.DirectoryName);
                item.SubItems.Add(subItem);

                //Add item to list;
                lstFiles.Items.Add(item);

                //Refresh column sizes
                lstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void AddItem(string path) {
            _files.Add(new FileInfo(path));
            WriteList();
        }
        #endregion

        #region GUI Event Handlers
        //==================//
        //GUI Event Handlers//
        //==================//
        private void mnuSelAll_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lstFiles.Items) {
                item.Checked = true;
            }
        }

        private void mnuDesel_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lstFiles.Items) {
                item.Checked = false;
            }
        }

        private void mnuInvSel_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lstFiles.Items) {
                item.Checked = !item.Checked;
            }
        }

        private void mnuFilterEdit_Click(object sender, EventArgs e) {
            FormFilters frmFilters = new FormFilters();
            DialogResult result = frmFilters.ShowDialog();
        }

        private void mnuFilterSave_Click(object sender, EventArgs e) {

        }

        private void mnuFilterLoad_Click(object sender, EventArgs e) {

        }
        #endregion
    }
}
