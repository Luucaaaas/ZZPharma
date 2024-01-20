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

        public class MedicamentItem
        {
            public int Id { get; set; }
            public string Libelle { get; set; }

            public MedicamentItem(int id, string libelle)
            {
                Id = id;
                Libelle = libelle;
            }

            public override string ToString()
            {
                return Libelle;
            }
        }

        public class AntecedentItem
        {
            public int Id { get; set; }
            public string Libelle { get; set; }

            public AntecedentItem(int id, string libelle)
            {
                Id = id;
                Libelle = libelle;
            }

            public override string ToString()
            {
                return Libelle;
            }
        }

        public class AllergieItem
        {
            public int Id { get; set; }
            public string Libelle { get; set; }

            public AllergieItem(int id, string libelle)
            {
                Id = id;
                Libelle = libelle;
            }

            public override string ToString()
            {
                return Libelle;
            }
        }

        public MedicamentInfo(string id, string libelle, string contreIndication)
        {
            InitializeComponent();
            medicamentId = id;
            txtLibelleMed.Text = libelle;
            txtContreIndication.Text = contreIndication;
            connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
            RemplirComboBoxMedicaments();
            RemplirComboBoxAntecedents();
            RemplirComboBoxAllergies();
        }

        private void CreerIncompatibilite(int idAntecedent, int idAllergie, int idMedicament)
        {
            string query = "INSERT INTO incompatible (id_a, id_al, id_med) VALUES (@IdAntecedent, @IdAllergie, @IdMedicament)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdAntecedent", idAntecedent);
                    command.Parameters.AddWithValue("@IdAllergie", idAllergie);
                    command.Parameters.AddWithValue("@IdMedicament", idMedicament);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            MessageBox.Show("L'incompatibilité a été créée avec succès.");
        }

        private void RemplirComboBoxMedicaments()
        {
            string query = "SELECT id_med, libelle_med FROM Medicament";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idMedicament = reader.GetInt32("id_med");
                        string libelleMedicament = reader.GetString("libelle_med");
                        cmbMedicaments.Items.Add(new MedicamentItem(idMedicament, libelleMedicament));
                    }
                    reader.Close();
                }
            }
        }

        private void RemplirComboBoxAntecedents()
        {
            string query = "SELECT id_a, libelle_a FROM Antecedent";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idAntecedent = reader.GetInt32("id_a");
                        string libelleAntecedent = reader.GetString("libelle_a");
                        cmbAntecedents.Items.Add(new AntecedentItem(idAntecedent, libelleAntecedent));
                    }
                    reader.Close();
                }
            }
        }

        private void RemplirComboBoxAllergies()
        {
            string query = "SELECT id_al, libelle_al FROM Allergie";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idAllergie = reader.GetInt32("id_al");
                        string libelleAllergie = reader.GetString("libelle_al");
                        cmbAllergies.Items.Add(new AllergieItem(idAllergie, libelleAllergie));
                    }
                    reader.Close();
                }
            }
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

        private void btnCREERinc_Click(object sender, EventArgs e)
        {
            if (cmbMedicaments.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un médicament.");
                return;
            }

            bool hasAntecedent = cmbAntecedents.SelectedItem != null;
            bool hasAllergie = cmbAllergies.SelectedItem != null;

            if (!hasAntecedent && !hasAllergie)
            {
                MessageBox.Show("Veuillez sélectionner au moins un antécédent ou une allergie.");
                return;
            }

            MedicamentItem selectedMedicament = (MedicamentItem)cmbMedicaments.SelectedItem;
            int idMedicament = selectedMedicament.Id;

            int? idAntecedent = null;
            if (hasAntecedent)
            {
                AntecedentItem selectedAntecedent = (AntecedentItem)cmbAntecedents.SelectedItem;
                idAntecedent = selectedAntecedent.Id;
            }

            int? idAllergie = null;
            if (hasAllergie)
            {
                AllergieItem selectedAllergie = (AllergieItem)cmbAllergies.SelectedItem;
                idAllergie = selectedAllergie.Id;
            }

            CreerIncompatibilite(idAntecedent.GetValueOrDefault(), idAllergie.GetValueOrDefault(), idMedicament);

            MessageBox.Show("L'incompatibilité a été créée avec succès.");
        }
    }
}