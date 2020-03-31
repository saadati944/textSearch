using System;
using System.IO;
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
        string[] path;
        string[] format;
        string value;
        List<string> desc = new List<string>();

        bool exit = false;


        public frmMain()
        {
            InitializeComponent();
            configReader r = new configReader(Application.StartupPath + "\\textsearch.config");
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Text == "Find")
            {
                exit = false;
                desc = new List<string>();
                value = txttext.Text;
                Task.Run(find);
                txttext.Enabled = lstItems.Enabled = false;
                btnFind.Text = "Stop"; }
            else
            {

            }
        }
        public void addFileToList(string fpath)
        {
            this.Invoke(new Action(() => lstItems.Items.Add(Path.GetFileName(fpath))));
            desc.Add(fpath);
        }
        void find()
        {
            try
            {

                for (int i = 0; i < path.Length; i++)
                {
                    if (exit)
                        return;
                    dirExplorer(path[i]);
                }
            }
            catch { }
            btnFind.Text = "Find";
        }

        public void dirExplorer(string dpath)
        {
            foreach (string x in Directory.GetFiles(dpath))
            {
                if (exit)
                    return;
                if (checkFile(x))
                    addFileToList(x);
            }
            foreach (string x in Directory.GetDirectories(dpath))
            {
                if (exit)
                    return;
                dirExplorer(x);
            }
        }

        public bool checkFile(string p)
        {
            if (!format.Contains(Path.GetExtension(p)))
                return false;
            foreach (string x in File.ReadAllLines(p))
            {
                if (exit)
                    return false;
                if (x.ToLower().Contains(value))
                    return true;
            }
            return false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            exit = true;
        }
    }
}
