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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }


        public void Button_Bejelentkezes(object sender, RoutedEventArgs e)
        {
            MainWindow fokepernyo = new MainWindow();
            fokepernyo.Show();
        }

        public void Button_Regisztracio(object sender, RoutedEventArgs e)
        {
            Register regisztracio = new Register();
            regisztracio.Show();
        }
    }
}
