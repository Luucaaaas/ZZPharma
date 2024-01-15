using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ZZinventory
{

    internal class MedicamentDataAcess 
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<Medicament> Medicament = new List<Medicament> ();

        public void AddMedicamentToDB(Medicament Medicament)  
        {
            this.Medicament.Add (Medicament); 
        }

        public List<Medicament> getMedicamentList() { return this.Medicament; } 



        public List<Medicament> getMedicamentListFromDB()
        {
            this.Medicament = new List<Medicament> ();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_med, contre_indication  FROM Medicament";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.Medicament.Add(new Medicament(reader["libelle_med"].ToString(), reader["contre_indication"].ToString()));
                        };
                    }

                }
                conn.Close();

            }
            return this.Medicament;
        }

        public int addMedicamentToDB(Medicament Medicament)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Medicament (libelle_med,contre_indication) VALUES (@libelle_med, @contre_indication)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle_med", Medicament.libelle_med);
                    command.Parameters.AddWithValue("@contre_indication", Medicament.contre_indication);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
    }
}