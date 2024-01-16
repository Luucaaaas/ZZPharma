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
            txtNom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPrenom = new TextBox();
            button1 = new Button();
            cmbSexe = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(22, 88);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 49);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 46);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 47);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(202, 85);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(125, 27);
            txtPrenom.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(53, 153);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbSexe
            // 
            cmbSexe.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexe.FormattingEnabled = true;
            cmbSexe.Items.AddRange(new object[] { "Homme", "Femme" });
            cmbSexe.Location = new Point(370, 84);
            cmbSexe.Name = "cmbSexe";
            cmbSexe.Size = new Size(151, 28);
            cmbSexe.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(207, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(549, 285);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cmbSexe);
            Controls.Add(button1);
            Controls.Add(txtPrenom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNom);
            Name = "Patient";
            Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}