namespace ZZinventory
{
    public partial class ZZhome : Form
    {
        private MedicamentDataAcess dataAccess = new MedicamentDataAcess();
        public ZZhome()
        {
            InitializeComponent();
            updateDataGridView();

            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                dataGridView1.Columns["libelle_med"].HeaderText = "Nom Médicament";
                dataGridView1.Columns["contre_indication"].HeaderText = "Contre Indication";
            }
        }



        private void ZZboutonConnect_Click(object sender, EventArgs e)
        {
            Medicament Medicament = new Medicament(this.textBox1.Text, this.textBox2.Text);
            dataAccess.addMedicamentToDB(Medicament);
            int result = dataAccess.addMedicamentToDB(Medicament);
            if (result == 0)
            {
                MessageBox.Show("impossible d'ajouter le médicament");
            }
            else if (result > 0)
            {
                MessageBox.Show("Le médicament: " + this.textBox1.Text + " à bien été ajouté");
            }
            updateDataGridView();
        }
        public void updateDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = dataAccess.getMedicamentListFromDB();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ZZhome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = this.dataGridView1.Rows[e.RowIndex];
                string libelle_med = selectRow.Cells["libelle_med"].Value.ToString();
                string contre_indication = selectRow.Cells["contre_indication"].Value.ToString();

                FormDetails formDetails = new FormDetails(libelle_med, contre_indication);
                formDetails.Show();



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}