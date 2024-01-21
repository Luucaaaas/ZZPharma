namespace ZZinventory
{
    partial class MedicamentInfo
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
            btnmod = new Button();
            txtmed = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContreIndication = new TextBox();
            txtLibelleMed = new TextBox();
            SuspendLayout();
            // 
            // btnmod
            // 
            btnmod.Location = new Point(104, 232);
            btnmod.Margin = new Padding(3, 2, 3, 2);
            btnmod.Name = "btnmod";
            btnmod.Size = new Size(82, 22);
            btnmod.TabIndex = 0;
            btnmod.Text = "button1";
            btnmod.UseVisualStyleBackColor = true;
            btnmod.Click += btnmod_Click;
            // 
            // txtmed
            // 
            txtmed.AutoSize = true;
            txtmed.Location = new Point(125, 28);
            txtmed.Name = "txtmed";
            txtmed.Size = new Size(38, 15);
            txtmed.TabIndex = 1;
            txtmed.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 60);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 157);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // txtContreIndication
            // 
            txtContreIndication.Location = new Point(93, 184);
            txtContreIndication.Margin = new Padding(3, 2, 3, 2);
            txtContreIndication.Name = "txtContreIndication";
            txtContreIndication.Size = new Size(110, 23);
            txtContreIndication.TabIndex = 4;
            // 
            // txtLibelleMed
            // 
            txtLibelleMed.Location = new Point(104, 86);
            txtLibelleMed.Margin = new Padding(3, 2, 3, 2);
            txtLibelleMed.Name = "txtLibelleMed";
            txtLibelleMed.Size = new Size(110, 23);
            txtLibelleMed.TabIndex = 5;
            // 
            // MedicamentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtLibelleMed);
            Controls.Add(txtContreIndication);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtmed);
            Controls.Add(btnmod);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MedicamentInfo";
            Text = "MedicamentInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnmod;
        private Label txtmed;
        private Label label2;
        private Label label3;
        private TextBox txtContreIndication;
        private TextBox txtLibelleMed;
        private ComboBox cmbAllergies;
        private ComboBox cmbAntecedents;
        private ComboBox cmbMedicaments;
        private Button btnCREERinc;
    }
}