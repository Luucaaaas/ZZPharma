namespace ZZinventory
{
    partial class Medicament
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtmed = new TextBox();
            txtcntrIndi = new TextBox();
            btnADDmed = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(345, 65);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(262, 141);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 68);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 152);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 2;
            label2.Text = "contre indication\t";
            // 
            // txtmed
            // 
            txtmed.Location = new Point(60, 95);
            txtmed.Margin = new Padding(3, 2, 3, 2);
            txtmed.Name = "txtmed";
            txtmed.Size = new Size(110, 23);
            txtmed.TabIndex = 3;
            // 
            // txtcntrIndi
            // 
            txtcntrIndi.Location = new Point(38, 200);
            txtcntrIndi.Margin = new Padding(3, 2, 3, 2);
            txtcntrIndi.Name = "txtcntrIndi";
            txtcntrIndi.Size = new Size(110, 23);
            txtcntrIndi.TabIndex = 4;
            // 
            // btnADDmed
            // 
            btnADDmed.Location = new Point(188, 202);
            btnADDmed.Margin = new Padding(3, 2, 3, 2);
            btnADDmed.Name = "btnADDmed";
            btnADDmed.Size = new Size(126, 22);
            btnADDmed.TabIndex = 6;
            btnADDmed.Text = "Créer Medicament";
            btnADDmed.UseVisualStyleBackColor = true;
            btnADDmed.Click += btnADDmed_Click;
            // 
            // button1
            // 
            button1.Location = new Point(577, 11);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(111, 22);
            button1.TabIndex = 7;
            button1.Text = "Retour Accueil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Medicament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(btnADDmed);
            Controls.Add(txtcntrIndi);
            Controls.Add(txtmed);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Medicament";
            Text = "Medicament";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtmed;
        private TextBox txtcntrIndi;
        private Button btnBACKhome;
        private Button btnADDmed;
        private Button button1;
    }
}