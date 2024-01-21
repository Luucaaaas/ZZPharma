using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ZZinventory
{
    public partial class incompatible : Form
    {

        public class MedicamentItem
        {
            public int Id { get; set; }
            public string Libelle { get; set; }

            public MedicamentItem(int id, string libelle)
            {
                Id = id;
                Libelle = libelle;
            }

            public override string ToString()
            {
                return Libelle;
            }
        }

        public class AntecedentItem
        {
            public int Id { get; set; }
            public string Libelle { get; set; }

            public AntecedentItem(int id, string libelle)
            {
                Id = id;
                Libelle = libelle;
            }

            public override string ToString()
            {
                return Libelle;
            }
        }

        public class AllergieItem
        {
            public int Id { get; set; }
            public string Libelle { get; set; }

            public AllergieItem(int id, string libelle)
            {
                Id = id;
                Libelle = libelle;
            }

            public override string ToString()
            {
                return Libelle;
            }
        }
        private string connectionString;

        public incompatible()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
            RemplirComboBoxMedicaments();
            RemplirComboBoxAntecedents();
            RemplirComboBoxAllergies();
            cmbMedicaments.MaxDropDownItems = 5;
            cmbMedicaments.DropDownHeight = cmbMedicaments.ItemHeight * cmbMedicaments.MaxDropDownItems;
            cmbAllergies.MaxDropDownItems = 5;
            cmbAllergies.DropDownHeight = cmbAllergies.ItemHeight * cmbAllergies.MaxDropDownItems;
            cmbAntecedents.MaxDropDownItems = 5;
            cmbAntecedents.DropDownHeight = cmbAntecedents.ItemHeight * cmbAntecedents.MaxDropDownItems;
        }

        private void RemplirComboBoxMedicaments()
        {
            string query = "SELECT id_med, libelle_med FROM Medicament";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idMedicament = reader.GetInt32("id_med");
                        string libelleMedicament = reader.GetString("libelle_med");
                        cmbMedicaments.Items.Add(new MedicamentItem(idMedicament, libelleMedicament));
                    }
                    reader.Close();
                }
            }
        }

        private void RemplirComboBoxAntecedents()
        {
            string query = "SELECT id_a, libelle_a FROM Antecedent";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idAntecedent = reader.GetInt32("id_a");
                        string libelleAntecedent = reader.GetString("libelle_a");
                        cmbAntecedents.Items.Add(new AntecedentItem(idAntecedent, libelleAntecedent));
                    }
                    reader.Close();
                }
            }
        }

        private void RemplirComboBoxAllergies()
        {
            string query = "SELECT id_al, libelle_al FROM Allergie";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idAllergie = reader.GetInt32("id_al");
                        string libelleAllergie = reader.GetString("libelle_al");
                        cmbAllergies.Items.Add(new AllergieItem(idAllergie, libelleAllergie));
                    }
                    reader.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void btnCREERinc_Click(object sender, EventArgs e)
        {
            MedicamentItem selectedMedicament = cmbMedicaments.SelectedItem as MedicamentItem;

            if (selectedMedicament != null)
            {
                int medicamentId = selectedMedicament.Id;
                bool hasAllergie = chkAllergie.Checked;
                bool hasAntecedent = chkAntecedent.Checked;

                if (hasAllergie || hasAntecedent)
                {
                    if (hasAllergie && hasAntecedent)
                    {
                        AllergieItem selectedAllergie = cmbAllergies.SelectedItem as AllergieItem;
                        AntecedentItem selectedAntecedent = cmbAntecedents.SelectedItem as AntecedentItem;

                        if (selectedAllergie != null && selectedAntecedent != null)
                        {
                            int allergieId = selectedAllergie.Id;
                            int antecedentId = selectedAntecedent.Id;

                            string queryAllergie = "INSERT INTO incompatible (id_med, id_al) VALUES (@medicamentId, @allergieId)";
                            string queryAntecedent = "INSERT INTO incompatible (id_med, id_a) VALUES (@medicamentId, @antecedentId)";

                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();

                                using (MySqlCommand commandAllergie = new MySqlCommand(queryAllergie, connection))
                                {
                                    commandAllergie.Parameters.AddWithValue("@medicamentId", medicamentId);
                                    commandAllergie.Parameters.AddWithValue("@allergieId", allergieId);
                                    commandAllergie.ExecuteNonQuery();
                                }

                                using (MySqlCommand commandAntecedent = new MySqlCommand(queryAntecedent, connection))
                                {
                                    commandAntecedent.Parameters.AddWithValue("@medicamentId", medicamentId);
                                    commandAntecedent.Parameters.AddWithValue("@antecedentId", antecedentId);
                                    commandAntecedent.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Allergie et antécédent attribués au médicament avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Veuillez sélectionner à la fois une allergie et un antécédent.");
                        }
                    }
                    else if (hasAllergie)
                    {
                        AllergieItem selectedAllergie = cmbAllergies.SelectedItem as AllergieItem;

                        if (selectedAllergie != null)
                        {
                            int allergieId = selectedAllergie.Id;

                            string queryAllergie = "INSERT INTO incompatible (id_med, id_al) VALUES (@medicamentId, @allergieId)";

                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                using (MySqlCommand commandAllergie = new MySqlCommand(queryAllergie, connection))
                                {
                                    commandAllergie.Parameters.AddWithValue("@medicamentId", medicamentId);
                                    commandAllergie.Parameters.AddWithValue("@allergieId", allergieId);

                                    connection.Open();
                                    commandAllergie.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Allergie attribuée au médicament avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Veuillez sélectionner une allergie.");
                        }
                    }
                    else if (hasAntecedent)
                    {
                        AntecedentItem selectedAntecedent = cmbAntecedents.SelectedItem as AntecedentItem;

                        if (selectedAntecedent != null)
                        {
                            int antecedentId = selectedAntecedent.Id;

                            string queryAntecedent = "INSERT INTO incompatible (id_med, id_a) VALUES (@medicamentId, @antecedentId)";

                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                using (MySqlCommand commandAntecedent = new MySqlCommand(queryAntecedent, connection))
                                {
                                    commandAntecedent.Parameters.AddWithValue("@medicamentId", medicamentId);
                                    commandAntecedent.Parameters.AddWithValue("@antecedentId", antecedentId);

                                    connection.Open();
                                    commandAntecedent.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Antécédent attribué au médicament avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Veuillez sélectionner un antécédent.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une allergie, un antécédent ou les deux.");
                }
            }
        }
    }
}









