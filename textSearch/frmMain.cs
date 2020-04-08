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
        //to use your own config file set useCFP to true and set your own configfilepath.
        bool useCFP = false;
        string configfilepath = "";



        string[] _path;
        string[] _format;
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
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            configReader r;
            if (useCFP)
                ;
            else if (Application.StartupPath.StartsWith("/"))
                configfilepath = Application.StartupPath + "/textsearch.config";
            else
                configfilepath = Application.StartupPath + "\\textsearch.config";
            r = new configReader(configfilepath);


            r.readFile();
            try
            {
                _path = r.configs["path"].Split('?');
                chkPath.Items.AddRange(_path);
                for (int i = 0; i < _path.Length; i++)
                    chkPath.SetItemChecked(i, true);
            }
            catch (Exception ex) { log(ex.Message); }

            try
            {
                _format = r.configs["format"].Split(',');
                chkFormat.Items.AddRange(_format);
                for (int i = 0; i < _format.Length; i++)
                    chkFormat.SetItemChecked(i, true);
            }
            catch (Exception ex) { log(ex.Message); }
            r.Dispose();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            txtDesc.Text = "";
            picIcon.Image = null;
            btnOpenFolder.Enabled = false;
            chkFormat.Enabled = chkPath.Enabled =pnlFormatsTool.Enabled=pnlPathsTool.Enabled= false;

            path = new string[chkPath.CheckedItems.Count];
            for (int i = 0; i < path.Length; i++)
                path[i] = chkPath.CheckedItems[i].ToString();

            format = new string[chkFormat.CheckedItems.Count];
            for (int i = 0; i < format.Length; i++)
                format[i] = chkFormat.CheckedItems[i].ToString();

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
        void ended()
        {
            Invoke(new Action(() => MessageBox.Show("end")));
            Invoke(new Action(() => lblStatus.Text = lstItems.Items.Count.ToString() + " items founded."));
            Invoke(new Action(() => chkFormat.Enabled = chkPath.Enabled=pnlPathsTool.Enabled=pnlFormatsTool.Enabled = true));
        }
        void find()
        {
            try
            {
                for (int j = 0; j < path.Length; j++)
                {
                    if (exit)
                    {
                        ended();
                        return;
                    }
                    tasks += 1;
                    try
                    {
                        string tstr = path[j];
                        Task.Run(new Action(() => dirExplorer(tstr, true)));
                    }
                    catch  { tasks -= 1; }
                }
                if (exit)
                {
                    ended();
                    return;
                }
                while (tasks > 0)
                    System.Threading.Thread.Sleep(10);
            }
            catch (Exception ex) { log(ex.Message); }
            this.Invoke(new Action(() => btnFind.Text = "Find"));
            this.Invoke(new Action(() => txttext.Enabled = true));
            ended();
        }

        public void dirExplorer(string dpath, bool root = false)
        {

            try
            {
                foreach (string x in Directory.GetFiles(dpath))
                {
                    if (exit)
                    {
                        if (root) tasks -= 1;
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
                        if (root) tasks -= 1;
                        return;
                    }
                    dirExplorer(x);
                }
            }
            catch (Exception ex) { log(ex.Message); }
            if (root) tasks -= 1;
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
                else if (x.ToLower().Contains(value))
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
            catch (Exception ex) { log(ex.Message); }
            try
            {
                FileInfo fi = new FileInfo(desc[lstItems.SelectedIndex]);
                txtDesc.Text = fi.FullName;
                txtDesc.Text += "\r\n\r\nfile size : " + (fi.Length / 1024).ToString() + " KB";
                txtDesc.Text += "\r\ncreation time : " + fi.CreationTime.ToLongDateString() + "  -  " + fi.CreationTime.ToLongTimeString();
                txtDesc.Text += "\r\nlast write time : " + fi.LastWriteTime.ToLongDateString() + "  -  " + fi.LastWriteTime.ToLongTimeString();
                txtDesc.Text += "\r\nlast access time : " + fi.LastAccessTime.ToLongDateString() + "  -  " + fi.LastAccessTime.ToLongTimeString();
            }
            catch (Exception ex) { log(ex.Message); }
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
            catch (Exception ex) { log(ex.Message); }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(desc[lstItems.SelectedIndex].Substring(0, desc[lstItems.SelectedIndex].Length - Path.GetFileName(desc[lstItems.SelectedIndex]).Length));
            }
            catch (Exception ex) { log(ex.Message); }
        }

        private void lblChangeSettingsState_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = !pnlSettings.Visible;
            lblChangeSettingsState.Text = pnlSettings.Visible ? ">" : "<";
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            chkPath.Height = (pnlSettings.Height - 72) / 2;
        }

        private void btnInvertPath_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkPath.Items.Count; i++)
            {
                chkPath.SetItemChecked(i, !chkPath.GetItemChecked(i));
            }
        }

        private void btnInvertFormat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkFormat.Items.Count; i++)
            {
                chkFormat.SetItemChecked(i, !chkFormat.GetItemChecked(i));
            }
        }

        private void btnPathPlus_Click(object sender, EventArgs e)
        {
            frmAdd addf = new frmAdd(true);
            addf.ShowDialog();
            
            if(!_path.Contains(Program.addValue))
            {
                try
                {
                    System.IO.File.AppendAllText(configfilepath, "\r\n?" + Program.addValue);
                    chkPath.Items.Add(Program.addValue);
                }
                catch (Exception ex) { log(ex.Message); }
            }
            else
            {
                MessageBox.Show("value already exists.");
            }
        }

        private void btnFormatPlus_Click(object sender, EventArgs e)
        {
            frmAdd addf = new frmAdd(false);
            addf.ShowDialog();

            if (!_format.Contains(Program.addValue))
            {
                try
                {
                    System.IO.File.AppendAllText(configfilepath, "\r\n," + Program.addValue);
                    chkFormat.Items.Add(Program.addValue);
                }
                catch (Exception ex) { log(ex.Message); }
            }
            else
            {
                MessageBox.Show("value already exists.");
            }
        }
        private void lblChangeLogsState_Click(object sender, EventArgs e)
        {
            pnlLog.Visible = !pnlLog.Visible;
            lblChangeLogsState.Text = pnlLog.Visible ? "v" : "^";
            frmMain_Resize(this, null) ;
        }
        void log(string message)
        {
            Invoke(new Action(() => lstLog.Items.Add(message)));
        }

        private void lstLog_DoubleClick(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }

        
    }
}
