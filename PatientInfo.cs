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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string sexe = cmbSexe.Text;

            // Exécuter une requête SQL pour mettre à jour les données du patient dans la base de données
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


