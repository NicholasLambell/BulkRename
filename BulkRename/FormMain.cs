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
        List<FileInfo> _fileDirs;

        public FormMain() {
            InitializeComponent();

            //Initialize files list
            _fileDirs = new List<FileInfo>();

            //Get command line arguments and process them
            _args = Environment.GetCommandLineArgs();
            ProcessArgs();
        }

        private void ProcessArgs() {
            if (_args.Length > 0) {
                foreach (string arg in _args) {
                    if (File.Exists(arg)) {

                    }
                }
            }
        }
    }
}
