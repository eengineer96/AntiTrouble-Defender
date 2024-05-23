using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AntiTrouble_Defender
{
    /// <summary>
    /// Interaction logic for Scannings.xaml
    /// </summary>
    public partial class Scannings : Window
    {
        public Scannings()
        {
            DefenderDatabase DB = new DefenderDatabase();
            InitializeComponent();
            List<string> ScanList = DB.GetLogEntries();
            foreach (string item in ScanList)
            {
                ListBox.Items.Add(item);
            }
        }
        private void Button_Vissza(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
