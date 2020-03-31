using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textSearch
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            configReader r = new configReader(Application.StartupPath+ "\\textsearch.config");
            r.readFile();
            try
            {
                path = r.configs["path"].Split('?');
            }
            catch { }

            try
            {
                format = r.configs["format"].Split(',');
            }
            catch { }
            r.Dispose();
        }
        string[] path;
        string[] format;

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
