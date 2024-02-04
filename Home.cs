using System;
using System.Configuration;
using System.Windows.Forms;


namespace ZZinventory
{

    public partial class Home : Form
    {
        private bool isDragging = false;
        private Point dragStartPoint;

        public Home()
        {
            InitializeComponent();
        }




        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patient Patient = new Patient();
            Patient.Show();
            this.Hide();
        }

        private void btnOrdo_Click(object sender, EventArgs e)
        {
            Ordonance Ordonance = new Ordonance();
            Ordonance.Show();
            this.Hide();
        }

        private void btnmedica_Click(object sender, EventArgs e)
        {
            Medicament Medicament = new Medicament();
            Medicament.Show();
            this.Hide();
        }

        private void btnINC_Click(object sender, EventArgs e)
        {
            incompatible incompatible = new incompatible();
            incompatible.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point screenPoint = PointToScreen(e.Location);
                Location = new Point(screenPoint.X - dragStartPoint.X, screenPoint.Y - dragStartPoint.Y);
            }
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            {
                isDragging = false;
            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            {
                isDragging = true;
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point screenPoint = PointToScreen(e.Location);
                Location = new Point(screenPoint.X - dragStartPoint.X, screenPoint.Y - dragStartPoint.Y);
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            {
                isDragging = false;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                isDragging = true;
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void panelUP_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }
        private void panelUP_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point screenPoint = PointToScreen(e.Location);
                Location = new Point(screenPoint.X - dragStartPoint.X, screenPoint.Y - dragStartPoint.Y);
            }
        }

        private void panelUP_MouseUp(object sender, MouseEventArgs e)
        {
            {
                isDragging = false;
            }
        }
    }
}
