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
        private bool isFirstImageDisplayed = true;
        private bool isDragging = false;
        private Point dragStartPoint;

        public NewUser()
        {

            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
            textBoxNom.Click += (sender, e) =>
            {
                labelNom.Visible = false;
            };

            textBoxNom.TextChanged += (sender, e) =>
            {
                if (textBoxNom.Text == "")
                {
                    labelNom.Visible = true;
                }
                else
                {
                    labelNom.Visible = false;
                }
            };

            textBoxNom.Leave += (sender, e) =>
            {
                if (textBoxNom.Text == "")
                {
                    labelNom.Visible = true;
                }
            };
            ///
            textBoxPrenom.Click += (sender, e) =>
            {
                labelPrenom.Visible = false;
            };

            textBoxPrenom.TextChanged += (sender, e) =>
            {
                if (textBoxPrenom.Text == "")
                {
                    labelPrenom.Visible = true;
                }
                else
                {
                    labelPrenom.Visible = false;
                }
            };

            textBoxPrenom.Leave += (sender, e) =>
            {
                if (textBoxPrenom.Text == "")
                {
                    labelPrenom.Visible = true;
                }
            };
            ///
            textBoxUsername.Click += (sender, e) =>
            {
                labelUsername.Visible = false;
            };

            textBoxUsername.TextChanged += (sender, e) =>
            {
                if (textBoxUsername.Text == "")
                {
                    labelUsername.Visible = true;
                }
                else
                {
                    labelUsername.Visible = false;
                }
            };

            textBoxUsername.Leave += (sender, e) =>
            {
                if (textBoxUsername.Text == "")
                {
                    labelUsername.Visible = true;
                }
            };
            ///
            textBoxMDP.Click += (sender, e) =>
            {
                labelMDP.Visible = false;
            };

            textBoxMDP.TextChanged += (sender, e) =>
            {
                if (textBoxMDP.Text == "")
                {
                    labelMDP.Visible = true;
                }
                else
                {
                    labelMDP.Visible = false;
                }
            };

            textBoxMDP.Leave += (sender, e) =>
            {
                if (textBoxMDP.Text == "")
                {
                    labelMDP.Visible = true;
                }
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string dateNaissance = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string login = textBoxUsername.Text;
            string password = textBoxMDP.Text;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(dateNaissance) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

                        textBoxNom.Text = "";
                        textBoxPrenom.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        textBoxUsername.Text = "";
                        textBoxMDP.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la création de l'utilisateur.");
                    }
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelNOMpage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point screenPoint = PointToScreen(e.Location);
                Location = new Point(screenPoint.X - dragStartPoint.X, screenPoint.Y - dragStartPoint.Y);
            }
        }

        private void labelNOMpage_MouseUp(object sender, MouseEventArgs e)
        {
            {
                isDragging = false;
            }
        }

        private void labelNOMpage_MouseDown(object sender, MouseEventArgs e)
        {
            {
                isDragging = true;
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void pcBOXpage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point screenPoint = PointToScreen(e.Location);
                Location = new Point(screenPoint.X - dragStartPoint.X, screenPoint.Y - dragStartPoint.Y);
            }
        }

        private void pcBOXpage_MouseUp(object sender, MouseEventArgs e)
        {
            {
                isDragging = false;
            }
        }

        private void pcBOXpage_MouseDown(object sender, MouseEventArgs e)
        {
            {
                isDragging = true;
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void panelUP_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }
        private void panelUP_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point screenPoint = PointToScreen(e.Location);
                Location = new Point(screenPoint.X - dragStartPoint.X, screenPoint.Y - dragStartPoint.Y);
            }
        }

        private void panelUP_MouseUp(object sender, MouseEventArgs e)
        {
            {
                isDragging = false;
            }
        }

        private void pictureBoxLock_Click(object sender, EventArgs e)
        {
            if (isFirstImageDisplayed)
            {
                pictureBoxLock.Image = Properties.Resources.unlock;
                isFirstImageDisplayed = false;
                textBoxMDP.UseSystemPasswordChar = false;

            }
            else
            {
                pictureBoxLock.Image = Properties.Resources._lock;
                isFirstImageDisplayed = true;
                textBoxMDP.UseSystemPasswordChar = true;

            }
        }

        private void textBoxNom_Click(object sender, EventArgs e)
        {
            textBoxNom.BackColor = Color.LightCyan;
            panelNom.BackColor = Color.LightCyan;

            textBoxPrenom.BackColor = Color.White;
            panelPrenom.BackColor = Color.White;

            textBoxUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;

            textBoxMDP.BackColor = Color.White;
            panelMDP.BackColor = Color.White;
        }

        private void textBoxPrenom_Click(object sender, EventArgs e)
        {
            textBoxNom.BackColor = Color.White;
            panelNom.BackColor = Color.White;

            textBoxPrenom.BackColor = Color.LightCyan;
            panelPrenom.BackColor = Color.LightCyan;

            textBoxUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;

            textBoxMDP.BackColor = Color.White;
            panelMDP.BackColor = Color.White;
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxNom.BackColor = Color.White;
            panelNom.BackColor = Color.White;

            textBoxPrenom.BackColor = Color.White;
            panelPrenom.BackColor = Color.White;

            textBoxUsername.BackColor = Color.LightCyan;
            panelUsername.BackColor = Color.LightCyan;

            textBoxMDP.BackColor = Color.White;
            panelMDP.BackColor = Color.White;
        }

        private void textBoxMDP_Click(object sender, EventArgs e)
        {
            textBoxNom.BackColor = Color.White;
            panelNom.BackColor = Color.White;

            textBoxPrenom.BackColor = Color.White;
            panelPrenom.BackColor = Color.White;

            textBoxUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;

            textBoxMDP.BackColor = Color.LightCyan;
            panelMDP.BackColor = Color.LightCyan;
        }
    }
}