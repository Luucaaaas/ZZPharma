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
            txtUsername.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtUsername, "txtUsername");
            txtUsername.ForeColor = Color.DeepSkyBlue;
            txtUsername.Name = "txtUsername";
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.ForeColor = Color.DeepSkyBlue;
            txtPassword.Name = "txtPassword";
            txtPassword.KeyPress += txtPassword_KeyPress_1;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.ForeColor = Color.DeepSkyBlue;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.DeepSkyBlue;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // LoginPage
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            MaximizeBox = false;
            Name = "LoginPage";
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
                Home Home = new Home();
                Home.Show();
                Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
