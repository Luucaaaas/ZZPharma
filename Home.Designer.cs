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
            pictureBox2 = new PictureBox();
            btnINC = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnPatients
            // 
            btnPatients.Location = new Point(280, 284);
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
            btnOrdo.Location = new Point(146, 284);
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
            btnmedica.Location = new Point(415, 284);
            btnmedica.Margin = new Padding(2, 3, 2, 3);
            btnmedica.Name = "btnmedica";
            btnmedica.Size = new Size(131, 37);
            btnmedica.TabIndex = 2;
            btnmedica.Text = "Médicaments";
            btnmedica.UseVisualStyleBackColor = true;
            btnmedica.Click += btnmedica_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-25, 256);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(852, 5);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnINC
            // 
            btnINC.Location = new Point(550, 284);
            btnINC.Margin = new Padding(2, 3, 2, 3);
            btnINC.Name = "btnINC";
            btnINC.Size = new Size(131, 37);
            btnINC.TabIndex = 12;
            btnINC.Text = "Incompatibilité";
            btnINC.UseVisualStyleBackColor = true;
            btnINC.Click += btnINC_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(btnINC);
            Controls.Add(pictureBox2);
            Controls.Add(btnmedica);
            Controls.Add(btnOrdo);
            Controls.Add(btnPatients);
            Font = new Font("News Gothic Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "GSBPharma | Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPatients;
        private Button btnOrdo;
        private Button btnmedica;
        private PictureBox pictureBox2;
        private Button btnINC;
    }
}