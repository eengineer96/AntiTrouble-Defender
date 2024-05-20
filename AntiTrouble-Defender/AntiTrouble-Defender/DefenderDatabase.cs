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
            using(SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string registrationQuery = "INSERT INTO `UserSettings` (`UserID`, `Username`, `Password`) VALUES (NULL, @Name, @Pass)";
                    using(SQLiteCommand cmd = new SQLiteCommand(registrationQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", Username);
                        cmd.Parameters.AddWithValue("@Pass", Password);

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

        //virus-e
        public bool IsVirus(string hashKod)
        {
            bool ok = true;
            using(SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string isVirusQuery = "SELECT CASE WHEN COUNT(*) > 0 THEN 'Vírus' ELSE 'Nem vírus' END " +
                                          "FROM Virus_Definitions WHERE Signature = @hashKod;";
                    
                    using(SQLiteCommand cmd = new SQLiteCommand(isVirusQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@hashKod", hashKod);
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

        public bool InsertHashKod(string hashKod)
        {
            bool ok = true;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) 
            {
                try
                {
                    connection.Open();
                    string insertHashQuery = "INSERT INTO Virus_Definitions (Signature) VALUES (@hashKod)";

                    using(SQLiteCommand cmd = new SQLiteCommand(insertHashQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@hashKod", hashKod);
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
