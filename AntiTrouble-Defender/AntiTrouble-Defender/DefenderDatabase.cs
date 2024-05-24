using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AntiTrouble_Defender
{
    public class DefenderDatabase
    {
        private static readonly string connectionString = @"Data Source= Defender.db; Version=3; New= False;Compress= True";
        //private static readonly string connectionString = "Server=127.0.0.1;Database=Defender; User ID=root;Password=;";


        //Bejelentkezes
        public bool IsLogin(string username, string password)
        {
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string isLoginQuery = "SELECT COUNT(*) FROM UserSettings WHERE Username = @Name AND Password = @Pass";
                    using (SQLiteCommand cmd = new SQLiteCommand(isLoginQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", username);
                        cmd.Parameters.AddWithValue("@Pass", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        Console.WriteLine(count);
                        return count == 1;

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Fail: " + e.Message);
                    return false;
                }
                finally 
                { 
                    connection.Close(); 
                }
            }
        }

        //Regisztracio
        public bool Registration(string Username, string Password)
        {
            bool ok = true;
            if (GetUserID(Username) != -1)
            {
                return false;
            }
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string registrationQuery = "INSERT INTO `UserSettings` (`ScanPath`, `Username`, `Password`) VALUES ('', @Name, @Pass)";
                    using(SQLiteCommand cmd = new SQLiteCommand(registrationQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", Username);
                        cmd.Parameters.AddWithValue("@Pass", Password);
                        Console.WriteLine(registrationQuery);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    ok = false;
                }
                finally 
                { 
                    CloseConnection(connection); 
                }
                return ok;
            }
        }

        // UserID lekérdezése
        public int GetUserID(string username)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string getUserIDQuery = "SELECT UserID FROM UserSettings WHERE Username = @Name";

                    using (SQLiteCommand cmd = new SQLiteCommand(getUserIDQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", username);
                        int id = Convert.ToInt32(cmd.ExecuteScalar());

                        return id;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return -1;
                }
                finally
                {
                    CloseConnection(connection);
                }
            }
        }


        //virus-e
        public bool IsVirus(string hashKod)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string isVirusQuery = "SELECT COUNT(*) FROM Virus_Definitions WHERE Signature = @hashKod";

                    using (SQLiteCommand cmd = new SQLiteCommand(isVirusQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@hashKod", hashKod);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Ha a count ==1, akkor a hash megtalálható a Virus_Definitions táblában
                        return count ==1;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                finally
                {
                    CloseConnection(connection);
                }
            }
        }

        // Vírus beszúrása az adatbázisba
        public bool InsertHashKod(string hashKod, string virusName = "unknown", string virusType = "unknown")
        {
            bool ok = true;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertHashQuery = "INSERT INTO Virus_Definitions (VirusID, Signature, VirusName, VirusType) VALUES (NULL, @hashKod, @virusName, @virusType)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertHashQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@hashKod", hashKod);
                        cmd.Parameters.AddWithValue("@virusName", virusName);
                        cmd.Parameters.AddWithValue("@virusType", virusType);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    ok = false;
                }
                finally
                {
                    CloseConnection(connection);
                }
                return ok;
            }
        }

        // Log bejegyzés beszúrása az adatbázisba
        public bool InsertLogEntries(string Username, int InfectedFiles, int CleanedFiles)
        {
            bool ok = true;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertLogQuery = "INSERT INTO ScanLogs (UserID, ScanDate, InfectedFiles, CleanedFiles) VALUES (@UserID, @ScanDate, @InfectedFiles, @CleanedFiles)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertLogQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", GetUserID(Username));
                        cmd.Parameters.AddWithValue("@ScanDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@InfectedFiles", InfectedFiles);
                        cmd.Parameters.AddWithValue("@CleanedFiles", CleanedFiles);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    ok = false;
                }
                finally
                {
                    CloseConnection(connection);
                }
                return ok;
            }
        }

        // Log bejegyzések kiolvasása
        public List<string> GetLogEntries()
        {
            List<string> logEntries = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT LogID, UserID, ScanDate, InfectedFiles, CleanedFiles, ScanResult FROM ScanLogs";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string logEntry = $"{reader["LogID"]}\t{reader["UserID"]}\t{reader["ScanDate"]}\t{reader["InfectedFiles"]}\t{reader["CleanedFiles"]}\t{reader["ScanResult"]}";
                                logEntries.Add(logEntry);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    CloseConnection(connection);
                }
            }

            return logEntries;
        }

        //Kommunikacio zaras
        private void CloseConnection(SQLiteConnection connection)
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
