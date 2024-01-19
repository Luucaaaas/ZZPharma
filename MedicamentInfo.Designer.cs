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
            button1 = new Button();
            txtmed = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContreIndication = new TextBox();
            txtLibelleMed = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(121, 346);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtmed
            // 
            txtmed.AutoSize = true;
            txtmed.Location = new Point(159, 21);
            txtmed.Name = "txtmed";
            txtmed.Size = new Size(50, 20);
            txtmed.TabIndex = 1;
            txtmed.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 114);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 245);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // txtContreIndication
            // 
            txtContreIndication.Location = new Point(196, 264);
            txtContreIndication.Name = "txtContreIndication";
            txtContreIndication.Size = new Size(125, 27);
            txtContreIndication.TabIndex = 4;
            // 
            // txtLibelleMed
            // 
            txtLibelleMed.Location = new Point(26, 150);
            txtLibelleMed.Name = "txtLibelleMed";
            txtLibelleMed.Size = new Size(125, 27);
            txtLibelleMed.TabIndex = 5;
            // 
            // MedicamentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLibelleMed);
            Controls.Add(txtContreIndication);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtmed);
            Controls.Add(button1);
            Name = "MedicamentInfo";
            Text = "MedicamentInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label txtmed;
        private Label label2;
        private Label label3;
        private TextBox txtContreIndication;
        private TextBox txtLibelleMed;
    }
}