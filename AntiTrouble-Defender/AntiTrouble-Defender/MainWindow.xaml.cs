﻿using System;
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
using static AntiTrouble_Defender.DefenderDatabase;
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
            bool virus = false;
            string mappa = MappaMegnyitas();
            if (mappa != "")
            {
                DirectoryInfo dinfo = new DirectoryInfo(mappa);
                string karantenUtvonal = mappa + "_quarantine";
                FileInfo[] fajlok = dinfo.GetFiles("*", SearchOption.AllDirectories);
                foreach (FileInfo fajl in fajlok)
                {
                    Lista.Items.Add(fajl.Name);
                    string hash = HashKodGeneralas(fajl.FullName);
                    if (HashKodVizsgalat(hash) == true)
                    {
                        KarantenbaHelyezes(fajl, karantenUtvonal);
                        virus = true;
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }         
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
            return "";
        }


        private string HashKodGeneralas(string utvonal)
        {
            MD5 md5 = MD5.Create();
            FileStream stream = File.OpenRead(utvonal);
            byte[] hash = md5.ComputeHash(stream);
            stream.Close();
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }


        private bool HashKodVizsgalat(string hash)
        {
            DefenderDatabase db = new DefenderDatabase();
            if (db.IsVirus(hash))
            {
                Lista.Items.Add("Vírus észlelve!");
                return true;
            }
            Lista.Items.Add("A fájl nem vírus!");
            return false;
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
                if (HashKodMegjeloles(hash, fajl.Name))
                {
                    Lista.Items.Add("A fájl sikeresen megjelölve!");
                }
                else
                {
                    Lista.Items.Add("Hiba történt a fájl adatbázisba írása során! Próbálja újra!");
                }

            }
        }


        private bool HashKodMegjeloles(string hash, string fajlnev)
        {
            DefenderDatabase db = new DefenderDatabase();
            bool eredmeny = db.InsertHashKod(hash, fajlnev);
            return eredmeny;
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
