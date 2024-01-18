using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ZZinventory
{
    public partial class Patient : Form
    {
        private string connectionString;

        public Patient()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
            ChargerDonnees();
            this.Activated += Patient_activated;
        }

        private void Patient_activated(object sender,EventArgs e)
        {
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            string query = "SELECT id_p, nom_p, prenom_p, sexe FROM Patient";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    {
                        connection.Open();

                        DataTable dataTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }


        private void AjouterPatient(string nom, string prenom, string sexe)
        {
            string query = "INSERT INTO Patient (nom_p, prenom_p, sexe) VALUES (@nom, @prenom, @sexe)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@sexe", sexe);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string sexe = cmbSexe.Text;

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(sexe))
            {
                MessageBox.Show("Veuillez remplir tous les champs du formulaire.", "Champ(s) manquant(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Le patient a été ajouté avec succès.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            AjouterPatient(nom, prenom, sexe);

            ChargerDonnees();

            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            cmbSexe.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string id = row.Cells["id_p"].Value.ToString();
                string nom = row.Cells["nom_p"].Value.ToString();
                string prenom = row.Cells["prenom_p"].Value.ToString();
                string sexe = row.Cells["sexe"].Value.ToString();

                PatientInfo patientInfoForm = new PatientInfo(id, nom, prenom, sexe);
                patientInfoForm.Show();
            }
        }
    }
}
