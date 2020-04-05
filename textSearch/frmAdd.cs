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
    public partial class frmAdd : Form
    {
        bool _addtopath;
        public frmAdd(bool addtopath)
        {
            InitializeComponent();
            _addtopath = addtopath;
            if (_addtopath)
                Text = "Enter a path to add to list";
            else
                Text = "Enter a format to add to list (formats start with dot)";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
                return;
            txtValue.Text = txtValue.Text.ToLower();
            if (_addtopath && checkpath(txtValue.Text))
            { Program.addValue = txtValue.Text; Close(); }
            else if (!_addtopath && checkFormat(txtValue.Text))
            { Program.addValue = txtValue.Text; Close(); }
            else
                MessageBox.Show("invalid value!!!");
        }
        bool checkpath(string value)
        {
            return System.IO.Directory.Exists(value);
        }
        bool checkFormat(string value)
        {
            return !value.EndsWith(" ") && value.StartsWith(".");
        }
    }
}
