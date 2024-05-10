using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SQLite;

namespace AntiTrouble_Defender
{
    public class DefenderDatabase
    {
        private static readonly string connectionString = "Server=127.0.0.1;Database=Defender; User ID=root;Password=;";

        private void CloseConnection(SQLiteConnection connection)
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
