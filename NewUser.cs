using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;


namespace ZZinventory
{
    public partial class NewUser : Form
    {
        private string connectionString;

        public NewUser()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string prenom = textBox2.Text;
            string dateNaissance = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string login = textBox4.Text;
            string password = textBox5.Text;

            // Vérifier si l'une des cases est vide
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(dateNaissance) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hasher le mot de passe avec BCrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string query = "INSERT INTO Medecin (nom_m, prenom_m, date_naissance_m, login_m, password_m) " +
                           "VALUES (@Nom, @Prenom, @DateNaissance, @Login, @Password)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Prenom", prenom);
                    command.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Utilisateur créé avec succès !");
                        // Réinitialiser les champs de saisie
                        textBox1.Text = "";
                        textBox2.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        textBox4.Text = "";
                        textBox5.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la création de l'utilisateur.");
                    }
                }
            }
        }
    }
}