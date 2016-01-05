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

            //Get command line arguments and process them
            _args = Environment.GetCommandLineArgs();
            ProcessArgs();

            //Write file info to list
            WriteList();
        }

        private void ProcessArgs() {
            foreach (string arg in _args) {
                if (File.Exists(arg) && Util.FileName(arg) != Util.FileName(Util.GetExe())) {
                    _files.Add(new FileInfo(arg));
                }
            }
        }

        private void WriteList() {
            foreach (FileInfo file in _files) {
                lstArgs.Items.Add(file.Name);
            }
        }
    }
}
