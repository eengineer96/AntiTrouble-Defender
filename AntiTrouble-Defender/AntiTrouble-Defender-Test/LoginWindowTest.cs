﻿using AntiTrouble_Defender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace AntiTrouble_Defender_Test
{
    public class LoginWindowTest
    {
        Login login = new Login();

        [WpfTheory]
        [InlineData("Szilveszter", "Antiv1rus", true)]
        public void Login_test(string username, string password, bool expected)
        {
            TextBox felhasznalonev = login.getFelhasznalonev();
            PasswordBox jelszo = login.getJelszo();
            felhasznalonev.Text = username;
            jelszo.Password = password;
            Button bejelentkezes = login.getBejelentkezes();
            bejelentkezes.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));

            bool result = Login.IsWindowOpen<MainWindow>();
            Assert.Equal(result, expected);
        }


        [WpfTheory]
        [InlineData(false, false)]
        [InlineData(true, true)]
        public void RegisterButton_test(bool click, bool expected)
        {
            Button regisztracio = login.getRegisztracio();
            if (click)
            {
                regisztracio.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
            bool result = Login.IsWindowOpen<MainWindow>();
            Assert.Equal(result, expected);
        }
    }
}
