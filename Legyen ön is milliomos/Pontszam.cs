using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Legyen_ön_is_milliomos
{
    class Pontszam
    {
        public void createDatabase()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS pontszam (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nev VARCHAR(1000) NOT NULL,
                    pont INTEGER NOT NULL,
                    mod VARCHAR(1000) NOT NULL
                )";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.db"))
            {
                    conn.Open();
                using (var oCmd = new SQLiteCommand(sql, conn))
                {
                    oCmd.ExecuteNonQuery();
                }
            }
        }

        public void insertRow(string name, int score, string mod)
        {
            string sql = @"INSERT INTO pontszam (nev, pont, mod)
                VALUES (@nev, @pont, @mod)";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString: "Data Source=mydb.db"))
            {
                using (var oCmd = new SQLiteCommand(sql, conn))
                {
                    conn.Open();
                    oCmd.Parameters.AddWithValue("@nev", name);
                    oCmd.Parameters.AddWithValue("@pont", score);
                    oCmd.Parameters.AddWithValue("@mod", mod);
                    oCmd.ExecuteNonQuery();
                }
            }
        }

        public void deletetRow(int id)
        {          
            string sql = @"DELETE FROM pontszam WHERE id = @id";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.db"))
            {
                    conn.Open();
                using (var oCmd = new SQLiteCommand(sql, conn))
                {                   
                    oCmd.Parameters.AddWithValue("@id", id);
                    oCmd.ExecuteNonQuery();
                }
            }
        }

        public List<string> select()
        {
            List<string> sor = new List<string>();
            string sql = @"SELECT * FROM pontszam";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.db"))
            {
                using (var oCmd = new SQLiteCommand(sql, conn))
                {
                    conn.Open();
                    using (SQLiteDataReader rdr = oCmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int id = rdr.GetInt32(0);
                            string name = rdr.GetString(1);
                            int scoree = rdr.GetInt32(2);
                            string mod = rdr.GetString(3);
                            sor.Add(Convert.ToString(id) + ';' + name + ';' + scoree + ';' + mod);
                        }
                    }
                }
            }

            return sor;
        }
    }
}
