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
        DefenderDatabase db = new DefenderDatabase();

        [WpfTheory]
        [InlineData("Teszt Elek", 9)]
        [InlineData("Szilveszter", 10)]
        public void GetUserID_test(string username, int expected)
        {
            int result = db.GetUserID(username);
            Assert.Equal(result, expected);
        }
    }
}
