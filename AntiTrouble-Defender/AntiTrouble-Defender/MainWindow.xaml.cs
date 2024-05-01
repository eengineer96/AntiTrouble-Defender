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
using Microsoft.Win32;
using static AntiTrouble_Defender.Login;
using System.IO;
using System.Security.Cryptography;

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
            string mappa = MappaMegnyitas();
            Vizsgal(mappa);
        }


        private string MappaMegnyitas()
        {
            FolderBrowserDialog ablak = new FolderBrowserDialog();
            DialogResult eredmeny = ablak.ShowDialog();
            if (eredmeny.ToString() == "OK")
            {
                Lista.Items.Clear();
                string mappa = ablak.SelectedPath;
                Lista.Items.Add(mappa);
                return mappa;
            }
            return null;
        }


        private void Vizsgal(string mappa)
        {
            DirectoryInfo dinfo = new DirectoryInfo(mappa);
            string karantenUtvonal = mappa + "_quarantine";
            FileInfo[] fajlok = dinfo.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo fajl in fajlok)
            {
                Lista.Items.Add(fajl.Name);
                string hash = HashKodGeneralas(fajl.FullName);
                // TODO: Adatbázisból a vírusok hash kódjának lekérdezése
                // Ideiglenesen:
                if (fajl.Name.Contains(".txt"))
                {
                    KarantenbaHelyezes(fajl, karantenUtvonal);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }


        private string HashKodGeneralas(string utvonal)
        {
            MD5 md5 = MD5.Create();
            FileStream stream = File.OpenRead(utvonal);
            byte[] hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }


        private void KarantenbaHelyezes(FileInfo fajl, string karantenUtvonal)
        {
            if (!Directory.Exists(karantenUtvonal))
            {
                Directory.CreateDirectory(karantenUtvonal);
            }
            string celhely = Path.Combine(karantenUtvonal, fajl.Name);
            try
            {
                if (File.Exists(celhely))
                {
                    File.Delete(celhely);
                }
                /*
                 * Itt mindig kivételt kapok:
                 * "A folyamat nem éri el a fájlt, mert már másik folyamat használja."
                 * A HashKodGeneralas miatt lehet probléma
                 * 
                 */
                File.Move(fajl.FullName, celhely);
            }
            catch (IOException ex)
            {
                Lista.Items.Add("Hiba történt: " + ex.Message);
            }
        }



        private void Megjeloles(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ablak = new System.Windows.Forms.OpenFileDialog();
            DialogResult eredmeny = ablak.ShowDialog();
            if (eredmeny.ToString() == "OK")
            {
                Lista.Items.Clear();
                FileInfo fajl = new FileInfo(ablak.FileName);
                string karantenUtvonal = fajl + "_quarantine";
                Lista.Items.Add(fajl.Name);
                string hash = HashKodGeneralas(fajl.FullName);
                KarantenbaHelyezes(fajl, karantenUtvonal);
                // TODO: Adatbázisba a megjelölt fájl hash kódjának felvétele
            }
        }



        private void Elozmenyek(object sender, RoutedEventArgs e)
        {
            Scannings elozmenyek = new Scannings();
            elozmenyek.Show();
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


    }
}
