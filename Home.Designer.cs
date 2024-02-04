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
            btnINC = new Button();
            panelUP = new Panel();
            button2 = new Button();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            panelUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnPatients
            // 
            resources.ApplyResources(btnPatients, "btnPatients");
            btnPatients.Cursor = Cursors.Hand;
            btnPatients.Name = "btnPatients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnOrdo
            // 
            resources.ApplyResources(btnOrdo, "btnOrdo");
            btnOrdo.Cursor = Cursors.Hand;
            btnOrdo.Name = "btnOrdo";
            btnOrdo.UseVisualStyleBackColor = true;
            btnOrdo.Click += btnOrdo_Click;
            // 
            // btnmedica
            // 
            resources.ApplyResources(btnmedica, "btnmedica");
            btnmedica.Cursor = Cursors.Hand;
            btnmedica.Name = "btnmedica";
            btnmedica.UseVisualStyleBackColor = true;
            btnmedica.Click += btnmedica_Click;
            // 
            // btnINC
            // 
            resources.ApplyResources(btnINC, "btnINC");
            btnINC.Cursor = Cursors.Hand;
            btnINC.Name = "btnINC";
            btnINC.UseVisualStyleBackColor = true;
            btnINC.Click += btnINC_Click;
            // 
            // panelUP
            // 
            panelUP.BackColor = Color.FromArgb(19, 70, 104);
            panelUP.Controls.Add(button2);
            panelUP.Controls.Add(pictureBox5);
            panelUP.Controls.Add(label2);
            panelUP.Cursor = Cursors.SizeAll;
            resources.ApplyResources(panelUP, "panelUP");
            panelUP.Name = "panelUP";
            panelUP.MouseDown += panelUP_MouseDown;
            panelUP.MouseMove += panelUP_MouseMove;
            panelUP.MouseUp += panelUP_MouseUp;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 70, 104);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = Color.White;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            pictureBox5.MouseDown += pictureBox5_MouseDown;
            pictureBox5.MouseMove += pictureBox5_MouseMove;
            pictureBox5.MouseUp += pictureBox5_MouseUp;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.MouseDown += label2_MouseDown;
            label2.MouseMove += label2_MouseMove;
            label2.MouseUp += label2_MouseUp;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            ControlBox = false;
            Controls.Add(panelUP);
            Controls.Add(btnINC);
            Controls.Add(btnmedica);
            Controls.Add(btnOrdo);
            Controls.Add(btnPatients);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            panelUP.ResumeLayout(false);
            panelUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPatients;
        private Button btnOrdo;
        private Button btnmedica;
        private Button btnINC;
        private Panel panelUP;
        private Button button2;
        private PictureBox pictureBox5;
        private Label label2;
    }
}