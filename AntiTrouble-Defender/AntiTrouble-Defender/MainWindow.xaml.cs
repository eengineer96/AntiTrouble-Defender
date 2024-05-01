using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using static AntiTrouble_Defender.Login;

namespace AntiTrouble_Defender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Felhasznalo felhasznalo;

        public MainWindow(Felhasznalo felhasznalo)
        {
            InitializeComponent();
            this.felhasznalo = felhasznalo;
            Udvozles.Text = "Üdv, " + felhasznalo.Felhasznalonev + "!";
        }

        private void Vizsgalat(object sender, RoutedEventArgs e)
        {
            // TODO
            MappaMegnyitas();
        }

        private void MappaMegnyitas()
        {

            using (var dialog3 = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result3 = dialog3.ShowDialog();
            }


        }



        private void Megjeloles(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void Kilepes(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Biztosan ki akar lépni?",
            "Megerősítés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                felhasznalo = null;
                this.Close();
            }
        }

        private void Button_Vizsgalat(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Megjeloles(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Kilepes(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Elozmenyek(object sender, RoutedEventArgs e)
        {

        }
    }
}
