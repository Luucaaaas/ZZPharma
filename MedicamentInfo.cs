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
    public partial class MedicamentInfo : Form
    {
        private string medicamentId;

        public MedicamentInfo(string id, string libelle, string contreIndication)
        {
            InitializeComponent();
            medicamentId = id;
            txtLibelleMed.Text = libelle;
            txtContreIndication.Text = contreIndication;
            txtmed.Text = libelle + " - " + contreIndication;
        }

    }
}
