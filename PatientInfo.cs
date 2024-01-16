using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ZZinventory
{
    public partial class PatientInfo : Form
    {
        private string patientId;
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public PatientInfo(string id, string nom, string prenom, string sexe)
        {
            InitializeComponent();

            patientId = id;

            // Afficher les informations du patient dans les TextBox
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            cmbSexe.Text = sexe;

            // Charger les antécédents du patient
            ChargerAntecedents();
        }

        private void ChargerAntecedents()
        {
            // Charger la table Antecedent
            string antecedentQuery = "SELECT id_a, libelle_a FROM Antecedent";
            DataTable antecedentTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(antecedentQuery, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(antecedentTable);
                    }
                }
            }

            // Charger la table a_eu
            string aEuQuery = "SELECT id_a FROM a_eu WHERE id_p = @patientId";
            DataTable aEuTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(aEuQuery, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(aEuTable);
                    }
                }
            }

            // Fusionner les tables Antecedent et a_eu pour obtenir les antécédents du patient
            DataTable patientAntecedents = new DataTable();
            patientAntecedents.Columns.Add("id_a", typeof(int));
            patientAntecedents.Columns.Add("libelle_a", typeof(string));

            foreach (DataRow aEuRow in aEuTable.Rows)
            {
                int antecedentId = Convert.ToInt32(aEuRow["id_a"]);

                DataRow[] antecedentRows = antecedentTable.Select("id_a = " + antecedentId);

                if (antecedentRows.Length > 0)
                {
                    DataRow antecedentRow = antecedentRows[0];
                    patientAntecedents.Rows.Add(antecedentRow.ItemArray);
                }
            }

            // Afficher les antécédents du patient dans le DataGridView
            dataGridView1.DataSource = patientAntecedents;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string sexe = cmbSexe.Text;

            string query = "UPDATE Patient SET non_p = @nom, prenom_p = @prenom, sexe = @sexe WHERE id_p = @id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@sexe", sexe);
                    command.Parameters.AddWithValue("@id", patientId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Les informations du patient ont été mises à jour avec succès.", "Mise à jour réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}


