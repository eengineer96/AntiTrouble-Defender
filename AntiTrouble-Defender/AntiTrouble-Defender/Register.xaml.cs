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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }


        public void Button_Regisztracio(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sikeres regisztráció!", "Sikeres regisztráció", MessageBoxButton.OK);
            this.Close();
        }

        public void Button_Vissza(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void JelszoValtozas(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sikeres jelszóváltoztatás!", "Sikeres jelszóváltoztatás", MessageBoxButton.OK);
            this.Close();
        }
    }
}
