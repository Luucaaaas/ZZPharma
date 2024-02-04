using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ZZinventory
{

    public partial class Home : Form
    {
        private string connectionString;


        public Home()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        }

        private void LoadMedecins()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT nom_p, prenom_p FROM Medecin";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string nomMedecin = reader.GetString(0);
                                string prenomMedecin = reader.GetString(1);

                                labelMedecin.Text = nomMedecin +", "+ prenomMedecin;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des médecins : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
