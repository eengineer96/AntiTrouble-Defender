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


        public class Felhasznalo
        {
            public string Felhasznalonev { get; set; }
            public string Jelszo { get; set; }
        }


        public void Bejelentkezes(object sender, RoutedEventArgs e)
        {
            if (!MezokKitoltve())
            {
                MessageBox.Show("Hiányzó adatok!\nA bejelentkezéshez adja meg " +
                                "a felhasználónevét és a jelszavát!",
                            "Bejelentkezési hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!FelhasznaloLetezik())
            {
                MessageBox.Show("Érvénytelen adatok!\nA megadott felhasználó " +
                                "nem szerepel a rendszer adatbázisában!",
                            "Bejelentkezési hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Felhasznalo felhasznalo = new Felhasznalo();
                felhasznalo.Felhasznalonev = Felhasznalonev.Text;
                MessageBox.Show("Sikeres bejelentkezés!\nÜdvözöljük, " + felhasznalo.Felhasznalonev + "!",
                            "Sikeres bejelentkezés", MessageBoxButton.OK);
                MainWindow fokepernyo = new MainWindow(felhasznalo.Felhasznalonev);
                fokepernyo.Show();
                this.Close();
            }

        }

        public void RegisztracioAblak(object sender, RoutedEventArgs e)
        {
            Register regisztracio = new Register();
            regisztracio.Show();
        }

        public bool MezokKitoltve()
        {
            if (Felhasznalonev.Text == "" || Jelszo.Password == "")
            {
                return false;
            }
            return true;
        }

        public bool FelhasznaloLetezik()
        {
            // TODO: Adatbázissal kommunikáló függvények hívása
            // Ideiglenesen:
            return true;
        }

    }
}
