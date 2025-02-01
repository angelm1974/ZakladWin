using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaklad;

namespace ZakladWin
{
    public static class DataBase
    {
        public static void Initialize()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Zaklad.db"))
            {
                var command_file = File.ReadAllText("skrypt.sql");

                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = command_file;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AddClient(Klient klient)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Zaklad.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO klient (imie, nazwisko, telefon) VALUES (@Imie, @Nazwisko, @Telefon)";
                    cmd.Parameters.AddWithValue("@Imie", klient.Imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", klient.Nazwisko);
                    cmd.Parameters.AddWithValue("@Telefon", klient.Telefon);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Klient> GetClients()
        {
            List<Klient> clients = new List<Klient>();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Zaklad.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "SELECT * FROM klient where deleted = 0";
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Klient klient = new Klient();
                            klient.Imie = reader["imie"].ToString();
                            klient.Nazwisko = reader["nazwisko"].ToString();
                            klient.Telefon = reader["telefon"].ToString();
                            clients.Add(klient);
                        }
                    }
                }
            }
            return clients;
        }   

        public static void DeleteClient(Klient klient)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Zaklad.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "UPDATE klient SET deleted = 1 WHERE imie = @Imie AND nazwisko = @Nazwisko AND telefon = @Telefon";
                    cmd.Parameters.AddWithValue("@Imie", klient.Imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", klient.Nazwisko);
                    cmd.Parameters.AddWithValue("@Telefon", klient.Telefon);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void deleteForeverClient(Klient klient)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Zaklad.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "DELETE FROM klient WHERE imie = @Imie AND nazwisko = @Nazwisko AND telefon = @Telefon";
                    cmd.Parameters.AddWithValue("@Imie", klient.Imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", klient.Nazwisko);
                    cmd.Parameters.AddWithValue("@Telefon", klient.Telefon);
                    cmd.ExecuteNonQuery();
                }
            }
        }   
    }



}
