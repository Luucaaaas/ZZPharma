namespace ZZinventory
{
    partial class incompatible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(incompatible));
            cmbMedicaments = new ComboBox();
            cmbAllergies = new ComboBox();
            cmbAntecedents = new ComboBox();
            btnCREERinc = new Button();
            button1 = new Button();
            chkAllergie = new CheckBox();
            chkAntecedent = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            Antecedents = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbMedicaments
            // 
            cmbMedicaments.Cursor = Cursors.Hand;
            cmbMedicaments.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicaments.FormattingEnabled = true;
            cmbMedicaments.Location = new Point(200, 287);
            cmbMedicaments.Margin = new Padding(3, 4, 3, 4);
            cmbMedicaments.Name = "cmbMedicaments";
            cmbMedicaments.Size = new Size(400, 28);
            cmbMedicaments.TabIndex = 0;
            // 
            // cmbAllergies
            // 
            cmbAllergies.FormattingEnabled = true;
            cmbAllergies.Location = new Point(93, 375);
            cmbAllergies.Margin = new Padding(3, 4, 3, 4);
            cmbAllergies.Name = "cmbAllergies";
            cmbAllergies.Size = new Size(297, 28);
            cmbAllergies.TabIndex = 1;
            // 
            // cmbAntecedents
            // 
            cmbAntecedents.FormattingEnabled = true;
            cmbAntecedents.Location = new Point(396, 375);
            cmbAntecedents.Margin = new Padding(3, 4, 3, 4);
            cmbAntecedents.Name = "cmbAntecedents";
            cmbAntecedents.Size = new Size(297, 28);
            cmbAntecedents.TabIndex = 2;
            // 
            // btnCREERinc
            // 
            btnCREERinc.Location = new Point(318, 442);
            btnCREERinc.Margin = new Padding(3, 4, 3, 4);
            btnCREERinc.Name = "btnCREERinc";
            btnCREERinc.Size = new Size(175, 31);
            btnCREERinc.TabIndex = 3;
            btnCREERinc.Text = "Créer l'incompatibilité";
            btnCREERinc.UseVisualStyleBackColor = true;
            btnCREERinc.Click += btnCREERinc_Click;
            // 
            // button1
            // 
            button1.Location = new Point(822, 162);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(164, 36);
            button1.TabIndex = 5;
            button1.Text = "Retour Accueil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkAllergie
            // 
            chkAllergie.AutoSize = true;
            chkAllergie.Location = new Point(93, 343);
            chkAllergie.Margin = new Padding(3, 4, 3, 4);
            chkAllergie.Name = "chkAllergie";
            chkAllergie.Size = new Size(226, 24);
            chkAllergie.TabIndex = 6;
            chkAllergie.Text = "Acivé pour l'ajout d'un Antecedent ";
            chkAllergie.UseVisualStyleBackColor = true;
            // 
            // chkAntecedent
            // 
            chkAntecedent.AutoSize = true;
            chkAntecedent.Location = new Point(396, 343);
            chkAntecedent.Margin = new Padding(3, 4, 3, 4);
            chkAntecedent.Name = "chkAntecedent";
            chkAntecedent.Size = new Size(226, 24);
            chkAntecedent.TabIndex = 7;
            chkAntecedent.Text = "Acivé pour l'ajout d'un Antecedent ";
            chkAntecedent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 263);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 8;
            label1.Text = "Medicaments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 319);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 9;
            label2.Text = "Allergies";
            // 
            // Antecedents
            // 
            Antecedents.AutoSize = true;
            Antecedents.Location = new Point(396, 319);
            Antecedents.Name = "Antecedents";
            Antecedents.Size = new Size(79, 20);
            Antecedents.TabIndex = 10;
            Antecedents.Text = "Antecedents";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, -50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(664, 12);
            button2.Name = "button2";
            button2.Size = new Size(108, 36);
            button2.TabIndex = 12;
            button2.Text = "Retour Accueil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // incompatible
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(Antecedents);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkAntecedent);
            Controls.Add(chkAllergie);
            Controls.Add(button1);
            Controls.Add(btnCREERinc);
            Controls.Add(cmbAntecedents);
            Controls.Add(cmbAllergies);
            Controls.Add(cmbMedicaments);
            Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(800, 550);
            MinimumSize = new Size(800, 550);
            Name = "incompatible";
            Text = "GSBPharma | Incompatible";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMedicaments;
        private ComboBox cmbAllergies;
        private ComboBox cmbAntecedents;
        private Button btnCREERinc;
        private Button button1;
        private CheckBox chkAllergie;
        private CheckBox chkAntecedent;
        private Label label1;
        private Label label2;
        private Label Antecedents;
        private PictureBox pictureBox1;
        private Button button2;
    }
}