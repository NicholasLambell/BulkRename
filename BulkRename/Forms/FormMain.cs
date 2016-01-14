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
        private string[] _args;
        private List<FileInfo> _files;
        private FilterList _filterList;
        private ListViewColumnSorter lstSorter;


        public FormMain() {
            InitializeComponent();

            //Initialize files list
            _files = new List<FileInfo>();

            lstSorter = new ListViewColumnSorter();
            lstFiles.ListViewItemSorter = lstSorter;

            //Initialize list view with columns
            lstFiles.Columns.Add("File", -2);
            lstFiles.Columns.Add("Path", -2);

            //Get command line arguments and process them
            _args = Environment.GetCommandLineArgs();
            ProcessArgs();
        }

        #region Misc Methods
        private void ProcessArgs() {
            foreach (string arg in _args) {
                if (File.Exists(arg) && Util.FileName(arg) != Util.FileName(Util.GetExe())) {
                    _files.Add(new FileInfo(arg));
                }
            }
            //Refresh list view
            WriteList();
        }

        private void WriteList() {
            //Clear existing items
            lstFiles.Items.Clear();

            foreach (FileInfo file in _files) {
                //Create list view item
                ListViewItem item = new ListViewItem(file.Name);
                item.Checked = true;

                //Create list view sub item
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, file.DirectoryName);
                item.SubItems.Add(subItem);

                //Add item to list;
                lstFiles.Items.Add(item);
            }

            //Refresh column sizes
            lstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Sort items by file name column
            lstSorter.SortColumn = 0;
            lstSorter.Order = SortOrder.Ascending;
            lstFiles.Sort();
        }

        private void AddItem(string path) {
            if (!String.IsNullOrEmpty(path) && File.Exists(path)) {
                _files.Add(new FileInfo(path));
                WriteList();
            }
        }

        private void AddItems(List<string> paths) {
            if (paths != null && paths.Count > 0) {
                foreach (string path in paths) {
                    if (!String.IsNullOrEmpty(path) && File.Exists(path)) {
                        _files.Add(new FileInfo(path));
                    }
                }
                WriteList();
            }
        }
        #endregion

        #region GUI Event Handlers
        private void btnApply_Click(object sender, EventArgs e) {
            if (_filterList != null) {
                if (_files.Count > 0) {
                    List<FileInfo> fileList = new List<FileInfo>();

                    //Add all checked items to file list
                    for (int i = 0; i < lstFiles.Items.Count; i++) {
                        if (lstFiles.Items[i].Checked) {
                            fileList.Add(_files[i]);
                        }
                    }

                    FilterHandler.ProcessFilters(_filterList, fileList);
                } else {
                    MessageBox.Show("Please select at least one file before applying filters", "Error!");
                }
            } else {
                MessageBox.Show("Please use the filters edit dialog to select filters first.", "Error!");
            }
        }

        #region list box
        private void lstFiles_DragDrop(object sender, DragEventArgs e) {
            //Get collection of files dropped to list
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //Add files to file list
            AddItems(new List<string>(files));
        }

        private void lstFiles_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private void lstFiles_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                foreach (ListViewItem item in lstFiles.Items) {
                    if (item.Selected) {
                        //_files.RemoveAt(item.Index);
                        //item.Remove();
                    }
                }
            }
            WriteList();
        }
        #endregion
        #region menu strip
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
            FormFilters frmFilters = new FormFilters(_filterList);
            DialogResult result = frmFilters.ShowDialog();

            if (result == DialogResult.OK) {
                FilterList filterList = (FilterList)frmFilters.Tag;

                if (filterList != null) {
                    _filterList = filterList;
                }
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.Multiselect = true;

            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK) {
                AddItems(new List<string>(fileDialog.FileNames));
            }
        }

        private void mnuFilterSave_Click(object sender, EventArgs e) {

        }

        private void mnuFilterLoad_Click(object sender, EventArgs e) {

        }
        #endregion
        #endregion
    }
}
