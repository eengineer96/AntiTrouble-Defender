using AntiTrouble_Defender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace AntiTrouble_Defender_Test
{
    public class DefenderDatabaseTest
    {

        [WpfTheory]
        [InlineData("Ismeretlen", -1)]
        [InlineData("Szilveszter", 10)]
        public void GetUserID_test(string username, int expected)
        {
            DefenderDatabase db = new DefenderDatabase();
            int result = db.GetUserID(username);
            Assert.Equal(result, expected);
        }


        [WpfTheory]
        [InlineData("Teszt Elek", 3, 5, true)]
        public void InsertLogEntries_test(string username, int infected, int cleared, bool expected)
        {
            DefenderDatabase db = new DefenderDatabase();
            bool result = db.InsertLogEntries(username, infected, cleared);
            Assert.True(result == expected);
        }


        [WpfTheory]
        [InlineData(true)]
        public void GetLogEntries_test(bool expected)
        {
            DefenderDatabase db = new DefenderDatabase();
            List<string> logs = db.GetLogEntries();
            Assert.True((logs != null) == expected);
        }

    }
}
