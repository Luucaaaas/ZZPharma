using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZZinventory
{
    public partial class FormDetails : Form
    {
        public FormDetails(string name, string description)
        {
            InitializeComponent();
            this.textBox1.Text = name;
            this.textBox2.Text = description;
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
