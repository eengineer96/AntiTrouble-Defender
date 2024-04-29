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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AntiTrouble_Defender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string felhasznalonev)
        {
            InitializeComponent();
            Udvozles.Text = "Üdv, " + felhasznalonev + "!";
        }


        private void Vizsgalat(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void Megjeloles(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void Kilepes(object sender, RoutedEventArgs e)
        {
            // TODO
        }

    }
}
