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
        bool caseSnse;
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
            txtDesc.Text = "";
            picIcon.Image = null;
            btnOpenFolder.Enabled = false;

            if (btnFind.Text == "Find")
            {
                caseSnse = btnFind.BackColor == Color.Green;
                if (!caseSnse)
                    value = value.ToLower();
                exit = false;
                desc = new List<string>();
                value = txttext.Text;
                Task.Run(find);
                txttext.Enabled = false;
                btnFind.Text = "Stop";
            }
            else
            {
                exit = true;
                System.Threading.Thread.Sleep(500);

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
            try
            {
                foreach (string x in Directory.GetFiles(dpath))
                {
                    if (exit)
                        return;
                    if (checkFile(x))
                        addFileToList(x);
                }
            }
            catch { }
            try
            {
                foreach (string x in Directory.GetDirectories(dpath))
                {
                    if (exit)
                        return;
                    dirExplorer(x);
                }
            }
            catch { }
        }

        public bool checkFile(string p)
        {
            if (!format.Contains(Path.GetExtension(p)))
                return false;
            foreach (string x in File.ReadAllLines(p))
            {
                if (exit)
                    return false;

                if (caseSnse)
                {
                    if (x.Contains(value))
                        return true;
                }
                else if(x.ToLower().Contains(value))
                    return true;

            }
            return false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            exit = true;
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex == -1)
            {
                txtDesc.Text = "";
                picIcon.Image = null;
                btnOpenFolder.Enabled = false;
                return;
            }
            btnOpenFolder.Enabled = true;
            try
            {
                picIcon.Image = Icon.ExtractAssociatedIcon(desc[lstItems.SelectedIndex]).ToBitmap();
            }
            catch { }
            try
            {
                FileInfo fi = new FileInfo(desc[lstItems.SelectedIndex]);
                txtDesc.Text = fi.FullName;
                txtDesc.Text += "\r\n\r\nfile size : " + (fi.Length / 1024).ToString() + " KB";
                txtDesc.Text += "\r\ncreation time : " + fi.CreationTime.ToLongDateString()+"  -  "+ fi.CreationTime.ToLongTimeString();
                txtDesc.Text += "\r\nlast write time : " + fi.LastWriteTime.ToLongDateString() + "  -  " + fi.LastWriteTime.ToLongTimeString();
                txtDesc.Text += "\r\nlast access time : " + fi.LastAccessTime.ToLongDateString() + "  -  " + fi.LastAccessTime.ToLongTimeString();
            }
            catch { }
        }

        private void btnMatchCase_Click(object sender, EventArgs e)
        {
            if (btnMatchCase.BackColor == Color.Green)
            {
                btnMatchCase.BackColor = Color.Red;
                btnMatchCase.Text = "Match Case";
            }
            else
            {
                btnMatchCase.BackColor = Color.Green;
                btnMatchCase.Text = "match case";
            }
        }

        private void lstItems_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Path.GetFullPath(desc[lstItems.SelectedIndex]));
            }
            catch { }
        }
    }
}
