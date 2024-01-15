using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZinventory
{
    internal class AntecedentDataAcess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<Antecedent> Antecedent = new List<Antecedent>();



        public List<Antecedent> getMedicamentList() { return this.Antecedent; }



        public List<Antecedent> getAntecedentListFromDB()
        {
            this.Antecedent = new List<Antecedent>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_a, libelle_a, FROM Antecedent";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.Antecedent.Add(new Antecedent(reader["id_a"].ToString(), reader["libelle_a"].ToString()));
                        };
                    }

                }
                conn.Close();

            }
            return this.Antecedent;
        }

        public int addAntecedenttToDB(Medicament Medicament)
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
