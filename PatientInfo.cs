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

            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            cmbSexe.Text = sexe;
            ChargerAntecedents();
        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            ChargerAntecedents();
        }

        private void ChargerAntecedents()
        {
            string query = "SELECT id_a, libelle_a FROM Antecedent";

            DataTable antecedentsTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(antecedentsTable);
                    }
                }
            }

            comboBox1.DisplayMember = "libelle_a";
            comboBox1.ValueMember = "id_a";
            comboBox1.DataSource = antecedentsTable;

            string selectQuery = "SELECT Antecedent.id_a, Antecedent.libelle_a FROM Antecedent INNER JOIN a_eu ON Antecedent.id_a = a_eu.id_a WHERE a_eu.id_p = @patientId";

            DataTable patientAntecedentsTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(patientAntecedentsTable);
                    }
                }
            }

            dataGridView1.DataSource = patientAntecedentsTable;
        }

        private void AjouterAntecedent(string antecedentId)
        {
            string selectQuery = "SELECT COUNT(*) FROM a_eu WHERE id_p = @patientId AND id_a = @antecedentId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);
                    command.Parameters.AddWithValue("@antecedentId", antecedentId);

                    connection.Open();

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 0)
                    {
                        string insertQuery = "INSERT INTO a_eu (id_p, id_a) VALUES (@patientId, @antecedentId)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@patientId", patientId);
                            insertCommand.Parameters.AddWithValue("@antecedentId", antecedentId);

                            insertCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("L'antécédent a été ajouté avec succès.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("L'antécédent sélectionné existe déjà pour ce patient.", "Doublon d'antécédent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string sexe = cmbSexe.Text;

            string query = "UPDATE Patient SET nom_p = @nom, prenom_p = @prenom, sexe = @sexe WHERE id_p = @id";

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string antecedentId = comboBox1.SelectedValue.ToString();
                AjouterAntecedent(antecedentId);
                ChargerAntecedents(); 
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un antécédent à ajouter.", "Sélectionner un antécédent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}