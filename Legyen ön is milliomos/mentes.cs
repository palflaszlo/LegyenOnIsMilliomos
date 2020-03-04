using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;

namespace Legyen_ön_is_milliomos
{
    class mentes
    {

        public void createDatabase()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS mentesek (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nev VARCHAR(1000) NOT NULL,
                    pont INTEGER NOT NULL,
                    szint INTEGER NOT NULL,
                    sor INTEGER NOT NULL
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

        public void insertRow(string name, int score, int szintt, int sorr)
        {
            string sql = @"INSERT INTO mentesek (nev, pont, szint, sor)
                VALUES (@nev, @pont, @szint, @sor)";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.db"))
            {
                using (var oCmd = new SQLiteCommand(sql, conn))
                {
                    conn.Open();
                    oCmd.Parameters.AddWithValue("@nev", name);
                    oCmd.Parameters.AddWithValue("@pont", score);
                    oCmd.Parameters.AddWithValue("@szint", szintt);
                    oCmd.Parameters.AddWithValue("@sor", sorr);
                    oCmd.ExecuteNonQuery();
                }
            }
        }

        public string select()
        {
            string sor = "";
            string sql = @"SELECT * FROM mentesek ORDER BY id DESC";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.db"))
            {
                    conn.Open();
                using (var oCmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader rdr = oCmd.ExecuteReader())
                    {
                        rdr.Read();
                        int id = rdr.GetInt32(0);
                        string name = rdr.GetString(1);
                        int scoree = rdr.GetInt32(2);
                        int szinttt = rdr.GetInt32(3);
                        int sorrr = rdr.GetInt32(4);
                        sor = Convert.ToString(id) + ';' + name + ';' + scoree + ';' + szinttt + ';' + sorrr;
                    }
                }
            }
            
            return sor;
        }
    }
}
