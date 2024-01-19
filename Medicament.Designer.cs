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
            dataGridView1.Location = new Point(394, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 91);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 203);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // txtmed
            // 
            txtmed.Location = new Point(68, 127);
            txtmed.Name = "txtmed";
            txtmed.Size = new Size(125, 27);
            txtmed.TabIndex = 3;
            // 
            // txtcntrIndi
            // 
            txtcntrIndi.Location = new Point(44, 267);
            txtcntrIndi.Name = "txtcntrIndi";
            txtcntrIndi.Size = new Size(125, 27);
            txtcntrIndi.TabIndex = 4;
            // 
            // btnADDmed
            // 
            btnADDmed.Location = new Point(265, 270);
            btnADDmed.Name = "btnADDmed";
            btnADDmed.Size = new Size(94, 29);
            btnADDmed.TabIndex = 6;
            btnADDmed.Text = "button2";
            btnADDmed.UseVisualStyleBackColor = true;
            btnADDmed.Click += btnADDmed_Click;
            // 
            // button1
            // 
            button1.Location = new Point(188, 392);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Medicament
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnADDmed);
            Controls.Add(txtcntrIndi);
            Controls.Add(txtmed);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
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