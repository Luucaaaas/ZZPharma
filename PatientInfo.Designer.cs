namespace ZZinventory
{
    partial class PatientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfo));
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            BtnModifier = new Button();
            cmbSexe = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PatientANT = new DataGridView();
            BtnADDant = new Button();
            comboBox1 = new ComboBox();
            btnCREERant = new Button();
            textBox1 = new TextBox();
            dataGridViewAntecedents = new DataGridView();
            dataGridViewAllergies = new DataGridView();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            comboBoxAllergies = new ComboBox();
            BtnADDall = new Button();
            textBox2 = new TextBox();
            btnAllergie = new Button();
            PatientALL = new DataGridView();
            reccupNom = new Label();
            label4 = new Label();
            txtPAT = new Label();
            txtSEXE = new Label();
            dataGridViewinc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PatientANT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAntecedents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllergies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientALL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewinc).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(13, 85);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(170, 27);
            txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(13, 150);
            txtPrenom.Margin = new Padding(4);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(170, 27);
            txtPrenom.TabIndex = 1;
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(13, 250);
            BtnModifier.Margin = new Padding(4);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(170, 36);
            BtnModifier.TabIndex = 3;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = true;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // cmbSexe
            // 
            cmbSexe.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexe.FormattingEnabled = true;
            cmbSexe.Items.AddRange(new object[] { "Homme", "Femme" });
            cmbSexe.Location = new Point(13, 207);
            cmbSexe.Margin = new Padding(4);
            cmbSexe.Name = "cmbSexe";
            cmbSexe.Size = new Size(170, 28);
            cmbSexe.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 5;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 186);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 7;
            label3.Text = "Sexe";
            // 
            // PatientANT
            // 
            PatientANT.AllowUserToAddRows = false;
            PatientANT.AllowUserToDeleteRows = false;
            PatientANT.AllowUserToResizeColumns = false;
            PatientANT.AllowUserToResizeRows = false;
            PatientANT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientANT.EnableHeadersVisualStyles = false;
            PatientANT.Location = new Point(213, 56);
            PatientANT.Margin = new Padding(4);
            PatientANT.MultiSelect = false;
            PatientANT.Name = "PatientANT";
            PatientANT.ReadOnly = true;
            PatientANT.RowHeadersWidth = 51;
            PatientANT.RowTemplate.Height = 29;
            PatientANT.Size = new Size(215, 155);
            PatientANT.TabIndex = 8;
            PatientANT.CellContentDoubleClick += PatientANT_CellContentDoubleClick;
            // 
            // BtnADDant
            // 
            BtnADDant.Location = new Point(213, 250);
            BtnADDant.Margin = new Padding(4);
            BtnADDant.Name = "BtnADDant";
            BtnADDant.Size = new Size(215, 36);
            BtnADDant.TabIndex = 9;
            BtnADDant.Text = "Ajouter Antecedent";
            BtnADDant.UseVisualStyleBackColor = true;
            BtnADDant.Click += BtnADDant_Click;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownHeight = 25;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownWidth = 151;
            comboBox1.IntegralHeight = false;
            comboBox1.ItemHeight = 20;
            comboBox1.Location = new Point(213, 216);
            comboBox1.Margin = new Padding(4);
            comboBox1.MaxDropDownItems = 5;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 28);
            comboBox1.TabIndex = 10;
            // 
            // btnCREERant
            // 
            btnCREERant.Location = new Point(4, 743);
            btnCREERant.Margin = new Padding(4);
            btnCREERant.Name = "btnCREERant";
            btnCREERant.Size = new Size(161, 36);
            btnCREERant.TabIndex = 11;
            btnCREERant.Text = "Créer Antecedent";
            btnCREERant.UseVisualStyleBackColor = true;
            btnCREERant.Click += btnCREERant_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 687);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 12;
            // 
            // dataGridViewAntecedents
            // 
            dataGridViewAntecedents.AllowUserToAddRows = false;
            dataGridViewAntecedents.AllowUserToDeleteRows = false;
            dataGridViewAntecedents.AllowUserToResizeColumns = false;
            dataGridViewAntecedents.AllowUserToResizeRows = false;
            dataGridViewAntecedents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAntecedents.EnableHeadersVisualStyles = false;
            dataGridViewAntecedents.Location = new Point(197, 553);
            dataGridViewAntecedents.MultiSelect = false;
            dataGridViewAntecedents.Name = "dataGridViewAntecedents";
            dataGridViewAntecedents.ReadOnly = true;
            dataGridViewAntecedents.RowHeadersWidth = 51;
            dataGridViewAntecedents.RowTemplate.Height = 29;
            dataGridViewAntecedents.Size = new Size(300, 188);
            dataGridViewAntecedents.TabIndex = 14;
            dataGridViewAntecedents.CellContentDoubleClick += dataGridViewAntecedents_CellContentDoubleClick;
            // 
            // dataGridViewAllergies
            // 
            dataGridViewAllergies.AllowUserToAddRows = false;
            dataGridViewAllergies.AllowUserToDeleteRows = false;
            dataGridViewAllergies.AllowUserToResizeColumns = false;
            dataGridViewAllergies.AllowUserToResizeRows = false;
            dataGridViewAllergies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllergies.EnableHeadersVisualStyles = false;
            dataGridViewAllergies.Location = new Point(559, 553);
            dataGridViewAllergies.MultiSelect = false;
            dataGridViewAllergies.Name = "dataGridViewAllergies";
            dataGridViewAllergies.ReadOnly = true;
            dataGridViewAllergies.RowHeadersWidth = 51;
            dataGridViewAllergies.RowTemplate.Height = 29;
            dataGridViewAllergies.Size = new Size(377, 188);
            dataGridViewAllergies.TabIndex = 15;
            dataGridViewAllergies.CellContentDoubleClick += dataGridViewAllergies_CellContentDoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(503, 436);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 526);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-16, 399);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1271, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // comboBoxAllergies
            // 
            comboBoxAllergies.Cursor = Cursors.Hand;
            comboBoxAllergies.DropDownHeight = 25;
            comboBoxAllergies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAllergies.DropDownWidth = 151;
            comboBoxAllergies.IntegralHeight = false;
            comboBoxAllergies.ItemHeight = 20;
            comboBoxAllergies.Location = new Point(436, 219);
            comboBoxAllergies.Margin = new Padding(4);
            comboBoxAllergies.MaxDropDownItems = 5;
            comboBoxAllergies.Name = "comboBoxAllergies";
            comboBoxAllergies.Size = new Size(215, 28);
            comboBoxAllergies.TabIndex = 18;
            // 
            // BtnADDall
            // 
            BtnADDall.Location = new Point(436, 250);
            BtnADDall.Margin = new Padding(4);
            BtnADDall.Name = "BtnADDall";
            BtnADDall.Size = new Size(215, 36);
            BtnADDall.TabIndex = 19;
            BtnADDall.Text = "Ajouter Allergie";
            BtnADDall.UseVisualStyleBackColor = true;
            BtnADDall.Click += BtnADDall_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(960, 566);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 21;
            // 
            // btnAllergie
            // 
            btnAllergie.Location = new Point(960, 622);
            btnAllergie.Margin = new Padding(4);
            btnAllergie.Name = "btnAllergie";
            btnAllergie.Size = new Size(161, 36);
            btnAllergie.TabIndex = 20;
            btnAllergie.Text = "Créer Allergie";
            btnAllergie.UseVisualStyleBackColor = true;
            btnAllergie.Click += btnAllergie_Click;
            // 
            // PatientALL
            // 
            PatientALL.AllowUserToAddRows = false;
            PatientALL.AllowUserToDeleteRows = false;
            PatientALL.AllowUserToResizeColumns = false;
            PatientALL.AllowUserToResizeRows = false;
            PatientALL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientALL.EnableHeadersVisualStyles = false;
            PatientALL.Location = new Point(436, 56);
            PatientALL.Margin = new Padding(4);
            PatientALL.MultiSelect = false;
            PatientALL.Name = "PatientALL";
            PatientALL.ReadOnly = true;
            PatientALL.RowHeadersWidth = 51;
            PatientALL.RowTemplate.Height = 29;
            PatientALL.Size = new Size(215, 155);
            PatientALL.TabIndex = 22;
            PatientALL.CellContentDoubleClick += PatientALL_CellContentDoubleClick;
            // 
            // reccupNom
            // 
            reccupNom.AutoSize = true;
            reccupNom.Location = new Point(13, 9);
            reccupNom.Name = "reccupNom";
            reccupNom.Size = new Size(95, 20);
            reccupNom.TabIndex = 23;
            reccupNom.Text = "Information De";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("News Gothic Condensed", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(213, 378);
            label4.Name = "label4";
            label4.Size = new Size(132, 14);
            label4.TabIndex = 24;
            label4.Text = "(Double Clique pour supprimer)";
            // 
            // txtPAT
            // 
            txtPAT.AutoSize = true;
            txtPAT.Location = new Point(163, 9);
            txtPAT.Name = "txtPAT";
            txtPAT.Size = new Size(31, 20);
            txtPAT.TabIndex = 28;
            txtPAT.Text = "info";
            // 
            // txtSEXE
            // 
            txtSEXE.AutoSize = true;
            txtSEXE.Location = new Point(105, 9);
            txtSEXE.Name = "txtSEXE";
            txtSEXE.Size = new Size(31, 20);
            txtSEXE.TabIndex = 29;
            txtSEXE.Text = "info";
            // 
            // dataGridViewinc
            // 
            dataGridViewinc.AllowUserToAddRows = false;
            dataGridViewinc.AllowUserToDeleteRows = false;
            dataGridViewinc.AllowUserToResizeColumns = false;
            dataGridViewinc.AllowUserToResizeRows = false;
            dataGridViewinc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewinc.EnableHeadersVisualStyles = false;
            dataGridViewinc.Location = new Point(659, 56);
            dataGridViewinc.Margin = new Padding(4);
            dataGridViewinc.MultiSelect = false;
            dataGridViewinc.Name = "dataGridViewinc";
            dataGridViewinc.ReadOnly = true;
            dataGridViewinc.RowHeadersWidth = 51;
            dataGridViewinc.RowTemplate.Height = 29;
            dataGridViewinc.Size = new Size(215, 155);
            dataGridViewinc.TabIndex = 30;
            // 
            // PatientInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1163, 864);
            Controls.Add(dataGridViewinc);
            Controls.Add(txtSEXE);
            Controls.Add(txtPAT);
            Controls.Add(label4);
            Controls.Add(reccupNom);
            Controls.Add(PatientALL);
            Controls.Add(textBox2);
            Controls.Add(btnAllergie);
            Controls.Add(BtnADDall);
            Controls.Add(comboBoxAllergies);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridViewAllergies);
            Controls.Add(dataGridViewAntecedents);
            Controls.Add(textBox1);
            Controls.Add(btnCREERant);
            Controls.Add(comboBox1);
            Controls.Add(BtnADDant);
            Controls.Add(PatientANT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbSexe);
            Controls.Add(BtnModifier);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "PatientInfo";
            Text = "GSBPharma | PatientInfo";
            ((System.ComponentModel.ISupportInitialize)PatientANT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAntecedents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllergies).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientALL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewinc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtPrenom;
        private Button BtnModifier;
        private ComboBox cmbSexe;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView PatientANT;
        private Button BtnADDant;
        private ComboBox comboBox1;
        private Button btnCREERant;
        private TextBox textBox1;
        private DataGridView dataGridViewAntecedents;
        private DataGridView dataGridViewAllergies;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ComboBox comboBoxAllergies;
        private Button BtnADDall;
        private TextBox textBox2;
        private Button btnAllergie;
        private DataGridView PatientALL;
        private Label reccupNom;
        private Label label4;
        private Label txtPAT;
        private Label txtSEXE;
        private DataGridView dataGridViewinc;
    }
}