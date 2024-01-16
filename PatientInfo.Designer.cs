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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(23, 61);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(32, 133);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(125, 27);
            txtPrenom.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(205, 131);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbSexe
            // 
            cmbSexe.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexe.FormattingEnabled = true;
            cmbSexe.Items.AddRange(new object[] { "Homme", "Femme" });
            cmbSexe.Location = new Point(23, 201);
            cmbSexe.Name = "cmbSexe";
            cmbSexe.Size = new Size(151, 28);
            cmbSexe.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 38);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 5;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 110);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 6;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 178);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 7;
            label3.Text = "Sexe";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(363, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 8;
            // 
            // PatientInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 504);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbSexe);
            Controls.Add(button1);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Name = "PatientInfo";
            Text = "PatientInfo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtPrenom;
        private Button button1;
        private ComboBox cmbSexe;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
    }
}