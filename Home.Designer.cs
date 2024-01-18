namespace ZZinventory
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnPatients = new Button();
            btnOrdo = new Button();
            btnmedica = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPatients
            // 
            btnPatients.Location = new Point(334, 282);
            btnPatients.Margin = new Padding(2, 3, 2, 3);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(131, 37);
            btnPatients.TabIndex = 0;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnOrdo
            // 
            btnOrdo.Location = new Point(200, 282);
            btnOrdo.Margin = new Padding(2, 3, 2, 3);
            btnOrdo.Name = "btnOrdo";
            btnOrdo.Size = new Size(131, 37);
            btnOrdo.TabIndex = 1;
            btnOrdo.Text = "Ordonnances";
            btnOrdo.UseVisualStyleBackColor = true;
            btnOrdo.Click += btnOrdo_Click;
            // 
            // btnmedica
            // 
            btnmedica.Location = new Point(469, 282);
            btnmedica.Margin = new Padding(2, 3, 2, 3);
            btnmedica.Name = "btnmedica";
            btnmedica.Size = new Size(131, 37);
            btnmedica.TabIndex = 2;
            btnmedica.Text = "Médicaments";
            btnmedica.UseVisualStyleBackColor = true;
            btnmedica.Click += btnmedica_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, -50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(pictureBox1);
            Controls.Add(btnmedica);
            Controls.Add(btnOrdo);
            Controls.Add(btnPatients);
            Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "GSBPharma | Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPatients;
        private Button btnOrdo;
        private Button btnmedica;
        private PictureBox pictureBox1;
    }
}