using System;
using System.Collections.Generic;
using System.Linq;
using static System.Security.Cryptography.MD5;
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
            using (var ablak = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult eredmeny = ablak.ShowDialog();
                if (eredmeny.ToString() == "OK")
                {
                    Lista.Items.Clear();
                    string mappa = ablak.SelectedPath;
                    Lista.Items.Add(mappa);
                    return mappa;
                }
                return null;
            }
        }


        private void Vizsgal(string mappa)
        {
            DirectoryInfo dinfo = new DirectoryInfo(mappa);
            FileInfo[] fajlok = dinfo.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo fajl in fajlok)
            {
                Lista.Items.Add(fajl.Name);
                string utvonal = mappa + "/" + fajl.Name;
                Lista.Items.Add(HashKodGeneralas(utvonal));
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


        private void KarantenbaHelyezes()
        {

        }



        private void Megjeloles(object sender, RoutedEventArgs e)
        {
            // TODO
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
