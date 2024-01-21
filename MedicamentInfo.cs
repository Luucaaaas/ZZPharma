using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZZinventory
{
    public partial class MedicamentInfo : Form
    {
        private string medicamentId;
        private string connectionString;

        public MedicamentInfo(string id, string libelle, string contreIndication)
        {
            InitializeComponent();
            medicamentId = id;
            txtLibelleMed.Text = libelle;
            txtContreIndication.Text = contreIndication;
            connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        }




        private void btnmod_Click(object sender, EventArgs e)
        {
            string nouveauLibelle = txtLibelleMed.Text;
            string nouvelleContreIndication = txtContreIndication.Text;

            string query = "UPDATE Medicament SET libelle_med = @Libelle, contre_indication = @ContreIndication WHERE id_med = @Id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Libelle", nouveauLibelle);
                    command.Parameters.AddWithValue("@ContreIndication", nouvelleContreIndication);
                    command.Parameters.AddWithValue("@Id", medicamentId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Les informations du médicament ont été modifiées avec succès dans la base de données.");
        }
    }
}