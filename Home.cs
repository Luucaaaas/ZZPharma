using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZZinventory
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patient Patient = new Patient();
            Patient.Show();
            this.Hide();
        }

        private void btnOrdo_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void btnmedica_Click(object sender, EventArgs e)
        {
            ZZhome ZZhome = new ZZhome();
            ZZhome.Show();
            this.Hide();
        }

    }
}
