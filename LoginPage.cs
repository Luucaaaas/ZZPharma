using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using BCrypt.Net;

namespace ZZinventory
{
    public partial class LoginPage : Form
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            textBoxUsername = new TextBox();
            textBoxMDP = new TextBox();
            btnLogin = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panelUP = new Panel();
            button2 = new Button();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            labelUsername = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            labelMDP = new Label();
            pictureBoxLock = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLock).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Cursor = Cursors.IBeam;
            textBoxUsername.Font = new Font("News Gothic Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.ForeColor = Color.FromArgb(19, 70, 104);
            textBoxUsername.Location = new Point(51, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(600, 40);
            textBoxUsername.TabIndex = 0;
            textBoxUsername.Click += txtUsername_Click;
            textBoxUsername.KeyPress += txtUsername_KeyPress;
            // 
            // textBoxMDP
            // 
            textBoxMDP.BackColor = Color.White;
            textBoxMDP.BorderStyle = BorderStyle.None;
            textBoxMDP.Cursor = Cursors.IBeam;
            textBoxMDP.Font = new Font("News Gothic Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMDP.ForeColor = Color.FromArgb(19, 70, 104);
            textBoxMDP.Location = new Point(51, 5);
            textBoxMDP.Name = "textBoxMDP";
            textBoxMDP.Size = new Size(600, 40);
            textBoxMDP.TabIndex = 1;
            textBoxMDP.UseSystemPasswordChar = true;
            textBoxMDP.Click += txtPassword_Click;
            textBoxMDP.KeyPress += txtPassword_KeyPress_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(435, 345);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Connexion";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(435, 554);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(160, 34);
            button1.TabIndex = 6;
            button1.Text = "Crée un compte";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(851, 598);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-1, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 570);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("News Gothic Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(28, 537);
            label1.Name = "label1";
            label1.Size = new Size(139, 18);
            label1.TabIndex = 11;
            label1.Text = "©GSBPharma 2007-2024\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("News Gothic Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 251);
            label5.Name = "label5";
            label5.Size = new Size(154, 39);
            label5.TabIndex = 10;
            label5.Text = "GSBPharma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("News Gothic Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 202);
            label4.Name = "label4";
            label4.Size = new Size(54, 39);
            label4.TabIndex = 9;
            label4.Text = "sur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("News Gothic Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 153);
            label3.Name = "label3";
            label3.Size = new Size(135, 39);
            label3.TabIndex = 8;
            label3.Text = "Bienvenue";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panelUP
            // 
            panelUP.BackColor = Color.FromArgb(19, 70, 104);
            panelUP.Controls.Add(button2);
            panelUP.Controls.Add(pictureBox5);
            panelUP.Controls.Add(label2);
            panelUP.Cursor = Cursors.SizeAll;
            panelUP.Dock = DockStyle.Top;
            panelUP.Location = new Point(0, 0);
            panelUP.Name = "panelUP";
            panelUP.Size = new Size(850, 30);
            panelUP.TabIndex = 9;
            panelUP.MouseDown += panelUP_MouseDown;
            panelUP.MouseMove += panelUP_MouseMove;
            panelUP.MouseUp += panelUP_MouseUp;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 70, 104);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(820, 0);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 10;
            button2.Text = "✗\t";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.MouseDown += pictureBox5_MouseDown;
            pictureBox5.MouseMove += pictureBox5_MouseMove;
            pictureBox5.MouseUp += pictureBox5_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("News Gothic Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, -1);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 12;
            label2.Text = "GSBPharma | Login";
            label2.MouseDown += label2_MouseDown;
            label2.MouseMove += label2_MouseMove;
            label2.MouseUp += label2_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelUsername);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(textBoxUsername);
            panel2.Location = new Point(199, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 49);
            panel2.TabIndex = 10;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("News Gothic Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.Gray;
            labelUsername.Location = new Point(433, 5);
            labelUsername.Name = "labelUsername";
            labelUsername.RightToLeft = RightToLeft.No;
            labelUsername.Size = new Size(215, 39);
            labelUsername.TabIndex = 10;
            labelUsername.Text = "Nom D'utilisateur";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelMDP);
            panel3.Controls.Add(pictureBoxLock);
            panel3.Controls.Add(textBoxMDP);
            panel3.Location = new Point(199, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(651, 49);
            panel3.TabIndex = 11;
            // 
            // labelMDP
            // 
            labelMDP.AutoSize = true;
            labelMDP.Font = new Font("News Gothic Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelMDP.ForeColor = Color.Gray;
            labelMDP.Location = new Point(477, 5);
            labelMDP.Name = "labelMDP";
            labelMDP.RightToLeft = RightToLeft.No;
            labelMDP.Size = new Size(171, 39);
            labelMDP.TabIndex = 11;
            labelMDP.Text = "Mot De Passe";
            // 
            // pictureBoxLock
            // 
            pictureBoxLock.Cursor = Cursors.Hand;
            pictureBoxLock.Image = Properties.Resources._lock;
            pictureBoxLock.InitialImage = null;
            pictureBoxLock.Location = new Point(0, 0);
            pictureBoxLock.Name = "pictureBoxLock";
            pictureBoxLock.Size = new Size(49, 49);
            pictureBoxLock.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLock.TabIndex = 4;
            pictureBoxLock.TabStop = false;
            pictureBoxLock.Click += pictureBoxLock_Click;
            // 
            // LoginPage
            // 
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(850, 600);
            ControlBox = false;
            Controls.Add(panelUP);
            Controls.Add(btnLogin);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GSBPharma | Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelUP.ResumeLayout(false);
            panelUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLock).EndInit();
            ResumeLayout(false);
        }

        private TextBox textBoxUsername;
        private TextBox textBoxMDP;
        private Button button1;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panelUP;
        private Button button2;
        private Button btnLogin;
        private bool isFirstImageDisplayed = true;
        private bool isDragging = false;
        private Point dragStartPoint;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxLock;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox5;
        private Label labelUsername;
        private Label labelMDP;
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public LoginPage()
        {
            InitializeComponent();

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
            string login = textBoxUsername.Text;
            string password = textBoxMDP.Text;

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



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.LightCyan;
            panel2.BackColor = Color.LightCyan;
            textBoxMDP.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.White;
            panel2.BackColor = Color.White;
            textBoxMDP.BackColor = Color.LightCyan;
            panel3.BackColor = Color.LightCyan;
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


        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point screenPoint = PointToScreen(e.Location);
                Location = new Point(screenPoint.X - dragStartPoint.X, screenPoint.Y - dragStartPoint.Y);
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            {
                isDragging = false;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                isDragging = true;
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point screenPoint = PointToScreen(e.Location);
                Location = new Point(screenPoint.X - dragStartPoint.X, screenPoint.Y - dragStartPoint.Y);
            }
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            {
                isDragging = false;
            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
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
    }
}
