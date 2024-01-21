using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;



namespace ZZinventory
{
    public partial class Ordonance : Form
    {
        private string connectionString;



        public class PatientItem
        {
            public int Id { get; set; }
            public string Nom { get; set; }

            public PatientItem(int id, string nom)
            {
                Id = id;
                Nom = nom;
            }

            public override string ToString()
            {
                return Nom;
            }
        }

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

        public class MedecinItem
        {
            public int Id { get; set; }
            public string Nom { get; set; }

            public MedecinItem(int id, string nom)
            {
                Id = id;
                Nom = nom;
            }

            public override string ToString()
            {
                return Nom;
            }
        }

        public Ordonance()
        {
            connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
            InitializeComponent();
            LoadPatients();
            LoadMedicment();
            LoadMedecin();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void LoadPatients()
        {

            string query = "SELECT id_p, nom_p FROM Patient";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idPatient = reader.GetInt32("id_p");
                        string libellePatient = reader.GetString("nom_p");
                        comboBoxPatients.Items.Add(new PatientItem(idPatient, libellePatient));
                    }
                    reader.Close();
                }
            }
        }

        private void LoadMedicment()
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
                        comboBoxMED.Items.Add(new MedicamentItem(idMedicament, libelleMedicament));
                    }
                    reader.Close();
                }
            }
        }

        private void LoadMedecin()
        {
            string query = "SELECT id_m, nom_m FROM Medecin";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idMedecin = reader.GetInt32("id_m");
                        string nomMedecin = reader.GetString("nom_m");
                        comboBoxMedecin.Items.Add(new MedecinItem(idMedecin, nomMedecin));
                    }
                    reader.Close();
                }
            }
        }

        private void buttonAjouterOrdonnance_Click(object sender, EventArgs e)
        {
            PatientItem selectedPatient = comboBoxPatients.SelectedItem as PatientItem;
            MedecinItem selectedMedecin = comboBoxMedecin.SelectedItem as MedecinItem;
            MedicamentItem selectedMedicament = comboBoxMED.SelectedItem as MedicamentItem;

            string posologie = textBoxPosologie.Text;
            string dureeTraitement = textBoxDureeTraitement.Text;
            string instructionSpecifique = textBoxInstruction.Text;

            if (selectedPatient != null && selectedMedecin != null && selectedMedicament != null &&
                !string.IsNullOrEmpty(posologie) && !string.IsNullOrEmpty(dureeTraitement))
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string query = "INSERT INTO ordonnance (posologie, duree_traitement, instruction_specifique, id_m, id_p, id_med) " +
                                       "VALUES (@posologie, @dureeTraitement, @instructionSpecifique, @idMedecin, @idPatient, @idMedicament)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@posologie", posologie);
                        command.Parameters.AddWithValue("@dureeTraitement", dureeTraitement);
                        command.Parameters.AddWithValue("@instructionSpecifique", instructionSpecifique);
                        command.Parameters.AddWithValue("@idMedecin", selectedMedecin.Id);
                        command.Parameters.AddWithValue("@idPatient", selectedPatient.Id);
                        command.Parameters.AddWithValue("@idMedicament", selectedMedicament.Id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ordonnance ajoutée avec succès !");
                            // Effacer les valeurs saisies
                            textBoxPosologie.Text = string.Empty;
                            textBoxDureeTraitement.Text = string.Empty;
                            textBoxInstruction.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'ajout de l'ordonnance.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les informations nécessaires.");
            }
            GeneratePDF(posologie, dureeTraitement, instructionSpecifique, selectedPatient.Nom, selectedMedecin.Nom, selectedMedicament.Libelle);
        }





        private void GeneratePDF(string posologie, string dureeTraitement, string instructionSpecifique, string nomPatient, string nomMedecin, string libelleMedicament)
        {
            // Obtenir le chemin du dossier "Téléchargements" de l'utilisateur
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";

            // Créer un nouveau document PDF
            Document document = new Document();

            // Générer un nom de fichier unique
            string uniqueFileName = Guid.NewGuid().ToString() + " Ordonance.pdf";

            // Spécifier le chemin de sortie du fichier PDF en utilisant le nom de fichier unique
            string outputPath = downloadsPath + uniqueFileName;

            // Créer un écrivain PDF
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

            // Ouvrir le document
            document.Open();

            // Créer le contenu de l'ordonnance
            Paragraph ordonnanceContent = new Paragraph();
            ordonnanceContent.Alignment = Element.ALIGN_LEFT;
            ordonnanceContent.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f);

            ordonnanceContent.Add("Posologie: " + posologie + "\n");
            ordonnanceContent.Add("Durée du traitement: " + dureeTraitement + "\n");
            ordonnanceContent.Add("Instructions spécifiques: " + instructionSpecifique + "\n");
            ordonnanceContent.Add("Patient: " + nomPatient + "\n");
            ordonnanceContent.Add("Médecin: " + nomMedecin + "\n");
            ordonnanceContent.Add("Médicament: " + libelleMedicament + "\n");

            // Ajouter le contenu de l'ordonnance au document
            document.Add(ordonnanceContent);

            // Fermer le document
            document.Close();

            // Afficher un message de réussite avec le nom du fichier unique
            MessageBox.Show("Le fichier PDF de l'ordonnance a été généré avec succès et enregistré sous le nom : " + uniqueFileName);
        }


    }



}