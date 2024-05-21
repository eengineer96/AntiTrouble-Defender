using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;

namespace AntiTrouble_Defender
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    /// teszt branch
    public partial class Register : Window
    {
        public Register()
        {
            Egyeznek.Visibility= Visibility.Hidden;
            InitializeComponent();
        }

        public class UserRegistrationData
        {
            public string userName { get; set; }
            public string password { get; set; }
        }

        public void Button_Regisztracio(object sender, RoutedEventArgs e)
        {
            string userName = Felhasznalonev.Text;
            string password = Jelszo.Password;
            DefenderDatabase DB = new DefenderDatabase();

            if (Jelszo.Password != JelszoUjra.Password)
            {
                Egyeznek.Visibility = Visibility.Visible;
            }
            else
            {
                bool success = DB.Registration(userName,password);

                if (success)
                {
                    MessageBox.Show("User registered successfully!");
                    Felhasznalonev.Clear();
                    Jelszo.Clear();
                    JelszoUjra.Clear();
                }
                else
                {
                    MessageBox.Show("Érvénytelen regisztráció!",
                            "Regisztrációs hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void Button_Vissza(object sender, RoutedEventArgs e)
        {
            Login newWindow = new Login();
            newWindow.Show();
            Close();
        }

        public void JelszoValtozas(object sender, RoutedEventArgs e)
        {
            if (Jelszo.Password != JelszoUjra.Password)
            {
                Egyeznek.Visibility = Visibility.Visible;
            }
            else
            {
                Egyeznek.Visibility = Visibility.Hidden;
            }
        }
     }
}
