using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
//using System.Data;
//using System.Text;
//using System.ComponentModel;

namespace textSearch
{
    public partial class frmMain : Form
    {
        string[] path;
        string[] format;
        string value;
        volatile bool caseSnse;
        int tasks = 0;
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
                lstItems.Items.Clear();
                caseSnse = btnFind.BackColor == Color.Green;
                exit = false;
                desc = new List<string>();
                value = txttext.Text;
                if (!caseSnse)
                    value = value.ToLower();
                Task.Run(find);
                txttext.Enabled = false;
                btnFind.Text = "Stop";
            }
            else
            {
                txttext.Enabled = true;
                exit = true;
                System.Threading.Thread.Sleep(500);
                btnFind.Text = "Find";
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
                for (int j = 0; j < path.Length; j++)
                {
                    if (exit)
                    {
                        Invoke(new Action(()=> MessageBox.Show("end")));
                        Invoke(new Action(() => lblStatus.Text = lstItems.Items.Count.ToString()+" items founded."));
                        return;
                    }
                    tasks+=1;
                    try
                    {
                        string tstr = path[j];
                        Task.Run(new Action(() => dirExplorer(tstr,true)));
                    }
                    catch { tasks -= 1; }
                }
                if (exit)
                {
                    Invoke(new Action(() => MessageBox.Show("end")));
                    Invoke(new Action(() => lblStatus.Text = lstItems.Items.Count.ToString() + " items founded."));
                    return;
                }
                while (tasks > 0)
                    System.Threading.Thread.Sleep(10);
            }
            catch { }
            this.Invoke(new Action(()=> btnFind.Text = "Find"));
            this.Invoke(new Action(()=> txttext.Enabled = true));
            Invoke(new Action(() => MessageBox.Show("end")));
            Invoke(new Action(() => lblStatus.Text = lstItems.Items.Count.ToString() + " items founded."));
        }

        public void dirExplorer(string dpath,bool root=false)
        {
            
            try
            {
                foreach (string x in Directory.GetFiles(dpath))
                {
                    if (exit)
                    {
                        if(root)tasks -= 1;
                        return;
                    }
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
                    {
                        if(root)tasks -= 1;
                        return;
                    }
                    dirExplorer(x);
                }
            }
            catch { }
            if(root)tasks -= 1;
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
                caseSnse = false;
            }
            else
            {
                btnMatchCase.BackColor = Color.Green;
                btnMatchCase.Text = "match case";
                caseSnse = true;
            }
        }

        private void lstItems_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lstItems.SelectedIndex != -1)
                    System.Diagnostics.Process.Start(desc[lstItems.SelectedIndex]);
            }
            catch { }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(desc[lstItems.SelectedIndex].Substring(0, desc[lstItems.SelectedIndex].Length-Path.GetFileName(desc[lstItems.SelectedIndex]).Length));
            }
            catch { }
        }

        private void lblChangeSettingsState_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = !pnlSettings.Visible;
            lblChangeSettingsState.Text =pnlSettings.Visible?">":"<";
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            chkPath.Height = pnlSettings.Height / 2;
        }
    }
}
