using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using BCrypt.Net;

namespace ZZinventory
{
    public partial class LoginPage : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public LoginPage()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(324, 53);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 32);
            txtUsername.TabIndex = 0;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(324, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(291, 32);
            txtPassword.TabIndex = 1;
            txtPassword.KeyPress += txtPassword_KeyPress_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("News Gothic Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(324, 22);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 2;
            label1.Text = "Nom D'utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("News Gothic Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(324, 103);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 3;
            label2.Text = "Mot De Passe";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(367, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Connexion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 195);
            button1.Name = "button1";
            button1.Size = new Size(165, 39);
            button1.TabIndex = 6;
            button1.Text = "Crée un compte";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("News Gothic Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 164);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 7;
            label3.Text = "Pas de compte ?";
            // 
            // LoginPage
            // 
            ClientSize = new Size(629, 272);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginPage";
            Text = "ZZPharma | Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private System.ComponentModel.IContainer components;
        private Button btnLogin;

        private bool AuthenticateUser(string login, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT password_m FROM Medecin WHERE login_m = @login";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", login);

                    string hashedPassword = command.ExecuteScalar() as string;
                    conn.Close();

                    if (hashedPassword != null && BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string login = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(login, password))
            {
                ZZhome ZZhome = new ZZhome();
                ZZhome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click_1(sender, e);
            }
        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click_1(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewUser NewUser = new NewUser();
            NewUser.Show();
        }
    }
}
