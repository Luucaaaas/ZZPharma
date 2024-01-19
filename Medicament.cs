using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ZZinventory
{
    public partial class Medicament : Form
    {
        private string connectionString;

        public Medicament()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
            ChargerMedicaments();
            this.Activated += Medicament_activated;

            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                if (column.Name == "id_med")
                {
                    column.Visible = false;
                }
                else if (column.Name == "libelle_med")
                {
                    column.HeaderText = "Libellé";
                }
                else if (column.Name == "contre_indication")
                {
                    column.HeaderText = "Contre-indication";
                }
            }
        }

        private void Medicament_activated(object sender, EventArgs e)
        {
            ChargerMedicaments();
        }

        private void ChargerMedicaments()
        {
            string query = "SELECT id_med, libelle_med, contre_indication FROM Medicament";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void AjouterMedicament(string libelleMed, string contreIndication)
        {
            string query = "INSERT INTO Medicament (libelle_med, contre_indication) VALUES (@libelleMed, @contreIndication)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@libelleMed", libelleMed);
                    command.Parameters.AddWithValue("@contreIndication", contreIndication);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }



        private void btnADDmed_Click(object sender, EventArgs e)
        {
            string libelleMed = txtmed.Text;
            string contreIndication = txtcntrIndi.Text;

            if (string.IsNullOrEmpty(libelleMed) || string.IsNullOrEmpty(contreIndication))
            {
                MessageBox.Show("Veuillez remplir tous les champs du formulaire.", "Champ(s) manquant(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Le médicament a été ajouté avec succès.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AjouterMedicament(libelleMed, contreIndication);

            ChargerMedicaments();

            txtmed.Text = string.Empty;
            txtcntrIndi.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string id = row.Cells["id_med"].Value.ToString();
                string libelle = row.Cells["libelle_med"].Value.ToString();
                string contreIndication = row.Cells["contre_indication"].Value.ToString();

                MedicamentInfo medicamentInfoForm = new MedicamentInfo(id, libelle, contreIndication);
                medicamentInfoForm.Show();
            }
        }

    }
}