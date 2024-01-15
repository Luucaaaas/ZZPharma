namespace ZZinventory
{
    partial class ZZhome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZZhome));
            ZZboutonConnect = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ZZboutonConnect
            // 
            ZZboutonConnect.AutoSize = true;
            ZZboutonConnect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ZZboutonConnect.BackgroundImageLayout = ImageLayout.None;
            ZZboutonConnect.Cursor = Cursors.Hand;
            ZZboutonConnect.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ZZboutonConnect.Location = new Point(172, 552);
            ZZboutonConnect.Margin = new Padding(1, 4, 1, 4);
            ZZboutonConnect.MaximumSize = new Size(1143, 375);
            ZZboutonConnect.MinimumSize = new Size(116, 39);
            ZZboutonConnect.Name = "ZZboutonConnect";
            ZZboutonConnect.RightToLeft = RightToLeft.No;
            ZZboutonConnect.Size = new Size(116, 39);
            ZZboutonConnect.TabIndex = 0;
            ZZboutonConnect.Text = "Ajouter ";
            ZZboutonConnect.UseVisualStyleBackColor = true;
            ZZboutonConnect.Click += ZZboutonConnect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 33);
            pictureBox1.Margin = new Padding(1, 4, 1, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(28, 312);
            textBox1.Margin = new Padding(1, 4, 1, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(435, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(28, 405);
            textBox2.Margin = new Padding(1, 4, 1, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(435, 23);
            textBox2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(525, 13);
            dataGridView1.Margin = new Padding(1, 4, 1, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(422, 478);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 280);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 6;
            label1.Text = "Nom";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 377);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 7;
            label2.Text = "Description";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 455);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(435, 33);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ZZhome
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 550);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ZZboutonConnect);
            Controls.Add(pictureBox1);
            Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ZZhome";
            Text = "ZZInventory - Home";
            Load += ZZhome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button ZZboutonConnect;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
    }
}