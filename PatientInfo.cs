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
            ChargerAllergies();
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

            string selectQueryAllAntecedents = "SELECT id_a, libelle_a FROM Antecedent";

            DataTable allAntecedentsTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectQueryAllAntecedents, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(allAntecedentsTable);
                    }
                }
            }

            dataGridViewAntecedents.DataSource = allAntecedentsTable;

            string selectQueryPatientAntecedents = "SELECT Antecedent.id_a, Antecedent.libelle_a FROM Antecedent INNER JOIN a_eu ON Antecedent.id_a = a_eu.id_a WHERE a_eu.id_p = @patientId";

            DataTable patientAntecedentsTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectQueryPatientAntecedents, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(patientAntecedentsTable);
                    }
                }
            }

            PatientANT.DataSource = patientAntecedentsTable;
        }

        private void ChargerAllergies()
        {
            string query = "SELECT id_al, libelle_al FROM Allergie";

            DataTable allergiesTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(allergiesTable);
                    }
                }
            }

            comboBoxAllergies.DisplayMember = "libelle_al";
            comboBoxAllergies.ValueMember = "id_al";
            comboBoxAllergies.DataSource = allergiesTable;

            string selectQueryAllAllergies = "SELECT id_al, libelle_al FROM Allergie";

            DataTable allAllergiesTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectQueryAllAllergies, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(allAllergiesTable);
                    }
                }
            }

            dataGridViewAllergies.DataSource = allAllergiesTable;

            string selectQueryPatientAllergies = "SELECT Allergie.id_al, Allergie.libelle_al FROM Allergie INNER JOIN est ON Allergie.id_al = est.id_al WHERE est.id_p = @patientId";

            DataTable patientAllergiesTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectQueryPatientAllergies, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(patientAllergiesTable);
                    }
                }
            }

            PatientALL.DataSource = patientAllergiesTable;
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

        private void AjouterAllergie(string allergieId)
        {
            string selectQuery = "SELECT COUNT(*) FROM est WHERE id_p = @patientId AND id_al = @allergieId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);
                    command.Parameters.AddWithValue("@allergieId", allergieId);

                    connection.Open();

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 0)
                    {
                        string insertQuery = "INSERT INTO est (id_p, id_al) VALUES (@patientId, @allergieId)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@patientId", patientId);
                            insertCommand.Parameters.AddWithValue("@allergieId", allergieId);

                            insertCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("L'allergie a été ajoutée avec succès.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("L'allergie sélectionnée existe déjà pour ce patient.", "Doublon d'allergie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void SupprimerAntecedentDeLaBDD(string antecedentId)
        {
            string deleteQuery = "DELETE FROM Antecedent WHERE id_a = @antecedentId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@antecedentId", antecedentId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void SupprimerAllergieDeLaBDD(string allergieId)
        {
            string deleteQuery = "DELETE FROM Allergie WHERE id_al = @allergieId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@allergieId", allergieId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void SupprimerAntecedent(string antecedentId)
        {
            string deleteQuery = "DELETE FROM a_eu WHERE id_p = @patientId AND id_a = @antecedentId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);
                    command.Parameters.AddWithValue("@antecedentId", antecedentId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("L'antécédent a été supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AjouterNouvelAntecedent(string nouvelAntecedent)
        {
            string insertQuery = "INSERT INTO Antecedent (libelle_a) VALUES (@libelle)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@libelle", nouvelAntecedent);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Le nouvel antécédent a été ajouté avec succès.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
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

        private void BtnADDall_Click(object sender, EventArgs e)
        {
            if (comboBoxAllergies.SelectedItem != null)
            {
                string AllergieId = comboBoxAllergies.SelectedValue.ToString();
                AjouterAllergie(AllergieId);
                ChargerAllergies();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une allergie à ajouter.", "Sélectionner une alletgie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnADDant_Click(object sender, EventArgs e)
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

        private void PatientANT_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = PatientANT.Rows[e.RowIndex];
                string antecedentId = selectedRow.Cells["id_a"].Value.ToString();

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet antécédent ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SupprimerAntecedent(antecedentId);
                    ChargerAntecedents();
                }
            }
        }

        private void btnCREERant_Click(object sender, EventArgs e)
        {
            string nouvelAntecedent = textBox1.Text;

            if (!string.IsNullOrEmpty(nouvelAntecedent))
            {
                AjouterNouvelAntecedent(nouvelAntecedent);
                ChargerAntecedents();
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nouvel antécédent.", "Antécédent manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewAntecedents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewAntecedents.Rows[e.RowIndex];
                string antecedentId = selectedRow.Cells["id_a"].Value.ToString();

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet antécédent ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SupprimerAntecedentDeLaBDD(antecedentId);
                    ChargerAntecedents();
                }
            }
        }

        private void dataGridViewAllergies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewAllergies.Rows[e.RowIndex];
                string AllergiestId = selectedRow.Cells["id_al"].Value.ToString();

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette allergie ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SupprimerAllergieDeLaBDD(AllergiestId);
                    ChargerAllergies();
                }
            }
        }
    }
}