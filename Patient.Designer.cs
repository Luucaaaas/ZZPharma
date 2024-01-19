namespace ZZinventory
{
    partial class Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            txtNom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPrenom = new TextBox();
            button1 = new Button();
            cmbSexe = new ComboBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(12, 293);
            txtNom.Margin = new Padding(3, 4, 3, 4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(169, 32);
            txtNom.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 264);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 1;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 329);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 391);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 3;
            label3.Text = "Sexe";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(12, 355);
            txtPrenom.Margin = new Padding(3, 4, 3, 4);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(169, 32);
            txtPrenom.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 461);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(169, 36);
            button1.TabIndex = 5;
            button1.Text = "Créer Patient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbSexe
            // 
            cmbSexe.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexe.FormattingEnabled = true;
            cmbSexe.Items.AddRange(new object[] { "Homme", "Femme" });
            cmbSexe.Location = new Point(12, 420);
            cmbSexe.Margin = new Padding(3, 4, 3, 4);
            cmbSexe.Name = "cmbSexe";
            cmbSexe.Size = new Size(169, 33);
            cmbSexe.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(187, 268);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(583, 229);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(606, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(164, 36);
            button2.TabIndex = 8;
            button2.Text = "Retour Accueil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, -50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-36, 256);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(852, 5);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 503);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(cmbSexe);
            Controls.Add(button1);
            Controls.Add(txtPrenom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNom);
            Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Patient";
            Text = "GSBPharma | Patient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPrenom;
        private Button button1;
        private ComboBox cmbSexe;
        private DataGridView dataGridView1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}