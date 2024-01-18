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
            button5 = new Button();
            PatientALL = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PatientANT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAntecedents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllergies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientALL).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(13, 43);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(140, 32);
            txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(161, 43);
            txtPrenom.Margin = new Padding(4);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(140, 32);
            txtPrenom.TabIndex = 1;
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(485, 40);
            BtnModifier.Margin = new Padding(4);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(105, 36);
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
            cmbSexe.Location = new Point(309, 42);
            cmbSexe.Margin = new Padding(4);
            cmbSexe.Name = "cmbSexe";
            cmbSexe.Size = new Size(170, 33);
            cmbSexe.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 5;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 6;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 12);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 7;
            label3.Text = "Sexe";
            // 
            // PatientANT
            // 
            PatientANT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientANT.Location = new Point(598, 40);
            PatientANT.Margin = new Padding(4);
            PatientANT.Name = "PatientANT";
            PatientANT.RowHeadersWidth = 51;
            PatientANT.RowTemplate.Height = 29;
            PatientANT.Size = new Size(377, 155);
            PatientANT.TabIndex = 8;
            PatientANT.CellContentDoubleClick += PatientANT_CellContentDoubleClick;
            // 
            // BtnADDant
            // 
            BtnADDant.Location = new Point(282, 116);
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
            comboBox1.DropDownHeight = 22;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownWidth = 151;
            comboBox1.IntegralHeight = false;
            comboBox1.ItemHeight = 25;
            comboBox1.Location = new Point(59, 119);
            comboBox1.Margin = new Padding(4);
            comboBox1.MaxDropDownItems = 5;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 33);
            comboBox1.TabIndex = 10;
            // 
            // btnCREERant
            // 
            btnCREERant.Location = new Point(13, 622);
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
            textBox1.Location = new Point(13, 566);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 32);
            textBox1.TabIndex = 12;
            // 
            // dataGridViewAntecedents
            // 
            dataGridViewAntecedents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAntecedents.Location = new Point(197, 553);
            dataGridViewAntecedents.Name = "dataGridViewAntecedents";
            dataGridViewAntecedents.RowHeadersWidth = 51;
            dataGridViewAntecedents.RowTemplate.Height = 29;
            dataGridViewAntecedents.Size = new Size(300, 188);
            dataGridViewAntecedents.TabIndex = 14;
            dataGridViewAntecedents.CellContentDoubleClick += dataGridViewAntecedents_CellContentDoubleClick;
            // 
            // dataGridViewAllergies
            // 
            dataGridViewAllergies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllergies.Location = new Point(559, 553);
            dataGridViewAllergies.Name = "dataGridViewAllergies";
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
            comboBoxAllergies.DropDownHeight = 22;
            comboBoxAllergies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAllergies.DropDownWidth = 151;
            comboBoxAllergies.IntegralHeight = false;
            comboBoxAllergies.ItemHeight = 25;
            comboBoxAllergies.Location = new Point(59, 209);
            comboBoxAllergies.Margin = new Padding(4);
            comboBoxAllergies.MaxDropDownItems = 5;
            comboBoxAllergies.Name = "comboBoxAllergies";
            comboBoxAllergies.Size = new Size(215, 33);
            comboBoxAllergies.TabIndex = 18;
            // 
            // BtnADDall
            // 
            BtnADDall.Location = new Point(282, 209);
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
            textBox2.Size = new Size(161, 32);
            textBox2.TabIndex = 21;
            // 
            // button5
            // 
            button5.Location = new Point(960, 622);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(161, 36);
            button5.TabIndex = 20;
            button5.Text = "Créer Allergie";
            button5.UseVisualStyleBackColor = true;
            // 
            // PatientALL
            // 
            PatientALL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientALL.Location = new Point(598, 203);
            PatientALL.Margin = new Padding(4);
            PatientALL.Name = "PatientALL";
            PatientALL.RowHeadersWidth = 51;
            PatientALL.RowTemplate.Height = 29;
            PatientALL.Size = new Size(377, 155);
            PatientALL.TabIndex = 22;
            // 
            // PatientInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1163, 864);
            Controls.Add(PatientALL);
            Controls.Add(textBox2);
            Controls.Add(button5);
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
        private Button button5;
        private DataGridView PatientALL;
    }
}