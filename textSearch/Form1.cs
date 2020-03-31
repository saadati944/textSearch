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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            configReader reader = new configReader(Application.StartupPath + "\\textsearch.config");
            reader.readFile();

            foreach (var x in reader.configs)
            {
                MessageBox.Show(";"+x.Key + ":" + x.Value + ";");
            }
        }
    }
}
