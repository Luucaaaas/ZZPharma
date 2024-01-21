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
            Ordonance Ordonance = new Ordonance();
            Ordonance.Show();
            this.Hide();
        }

        private void btnmedica_Click(object sender, EventArgs e)
        {
            Medicament Medicament = new Medicament();
            Medicament.Show();
            this.Hide();
        }

        private void btnINC_Click(object sender, EventArgs e)
        {
            incompatible incompatible = new incompatible();
            incompatible.Show();
            this.Hide();
        }
    }
}
