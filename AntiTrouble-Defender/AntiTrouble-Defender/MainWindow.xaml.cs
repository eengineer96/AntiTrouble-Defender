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
using System.Windows.Shapes;
using Microsoft.Win32;
using static AntiTrouble_Defender.Login;
using System.IO;

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
            using (var ablak = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult eredmeny = ablak.ShowDialog();
                if (eredmeny.ToString() == "OK")
                {
                    Lista.Items.Add(eredmeny.ToString());
                }
            }


        }


        private void Vizsgalat()
        {
            DirectoryInfo dinfo = new DirectoryInfo("C:/");
            FileInfo[] fajlok = dinfo.GetFiles();
            foreach (FileInfo fajl in fajlok)
            {
                Lista.Items.Add(fajl.Name);
                System.Threading.Thread.Sleep(2000);
            }

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
