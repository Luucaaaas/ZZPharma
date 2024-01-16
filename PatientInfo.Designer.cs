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
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            button1 = new Button();
            cmbSexe = new ComboBox();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(87, 173);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(262, 173);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(125, 27);
            txtPrenom.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(256, 266);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbSexe
            // 
            cmbSexe.FormattingEnabled = true;
            cmbSexe.Location = new Point(426, 186);
            cmbSexe.Name = "cmbSexe";
            cmbSexe.Size = new Size(151, 28);
            cmbSexe.TabIndex = 4;
            // 
            // PatientInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSexe);
            Controls.Add(button1);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Name = "PatientInfo";
            Text = "PatientInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtPrenom;
        private Button button1;
        private ComboBox cmbSexe;
    }
}