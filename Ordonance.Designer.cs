namespace ZZinventory
{
    partial class Ordonance
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
            comboBoxPatients = new ComboBox();
            button1 = new Button();
            comboBoxMED = new ComboBox();
            comboBoxMedecin = new ComboBox();
            textBoxPosologie = new TextBox();
            textBoxDureeTraitement = new TextBox();
            textBoxInstruction = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAjouterOrdonnance = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBoxPatients
            // 
            comboBoxPatients.FormattingEnabled = true;
            comboBoxPatients.Location = new Point(42, 112);
            comboBoxPatients.Name = "comboBoxPatients";
            comboBoxPatients.Size = new Size(121, 23);
            comboBoxPatients.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(626, 12);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 1;
            button1.Text = "Retour Accueil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxMED
            // 
            comboBoxMED.FormattingEnabled = true;
            comboBoxMED.Location = new Point(232, 112);
            comboBoxMED.Name = "comboBoxMED";
            comboBoxMED.Size = new Size(121, 23);
            comboBoxMED.TabIndex = 2;
            // 
            // comboBoxMedecin
            // 
            comboBoxMedecin.FormattingEnabled = true;
            comboBoxMedecin.Location = new Point(440, 130);
            comboBoxMedecin.Name = "comboBoxMedecin";
            comboBoxMedecin.Size = new Size(121, 23);
            comboBoxMedecin.TabIndex = 3;
            // 
            // textBoxPosologie
            // 
            textBoxPosologie.Location = new Point(42, 229);
            textBoxPosologie.Name = "textBoxPosologie";
            textBoxPosologie.Size = new Size(100, 23);
            textBoxPosologie.TabIndex = 4;
            // 
            // textBoxDureeTraitement
            // 
            textBoxDureeTraitement.Location = new Point(270, 229);
            textBoxDureeTraitement.Name = "textBoxDureeTraitement";
            textBoxDureeTraitement.Size = new Size(100, 23);
            textBoxDureeTraitement.TabIndex = 5;
            // 
            // textBoxInstruction
            // 
            textBoxInstruction.Location = new Point(461, 229);
            textBoxInstruction.Name = "textBoxInstruction";
            textBoxInstruction.Size = new Size(100, 23);
            textBoxInstruction.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 201);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Posologie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 188);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 8;
            label2.Text = "DureeTraitement";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 202);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "Instruction";
            // 
            // buttonAjouterOrdonnance
            // 
            buttonAjouterOrdonnance.Location = new Point(239, 376);
            buttonAjouterOrdonnance.Name = "buttonAjouterOrdonnance";
            buttonAjouterOrdonnance.Size = new Size(212, 23);
            buttonAjouterOrdonnance.TabIndex = 10;
            buttonAjouterOrdonnance.Text = "Ajouter Ordonnance";
            buttonAjouterOrdonnance.UseVisualStyleBackColor = true;
            buttonAjouterOrdonnance.Click += buttonAjouterOrdonnance_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 76);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "Patient";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(467, 112);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 12;
            label5.Text = "Medecin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 94);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 13;
            label6.Text = "Medicament";
            // 
            // Ordonance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonAjouterOrdonnance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxInstruction);
            Controls.Add(textBoxDureeTraitement);
            Controls.Add(textBoxPosologie);
            Controls.Add(comboBoxMedecin);
            Controls.Add(comboBoxMED);
            Controls.Add(button1);
            Controls.Add(comboBoxPatients);
            Name = "Ordonance";
            Text = "Ordonance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPatients;
        private Button button1;
        private ComboBox comboBoxMED;
        private ComboBox comboBoxMedecin;
        private TextBox textBoxPosologie;
        private TextBox textBoxDureeTraitement;
        private TextBox textBoxInstruction;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAjouterOrdonnance;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}