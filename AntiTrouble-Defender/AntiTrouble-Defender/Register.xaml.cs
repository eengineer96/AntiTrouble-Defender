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

        public async void Button_Regisztracio(object sender, RoutedEventArgs e)
        {
            string userName = Felhasznalonev.Text;
            string password = Jelszo.Password;

            if (Jelszo.Password != JelszoUjra.Password)
            {
                Egyeznek.Visibility = Visibility.Visible;
            }
            else
            {
                bool success = await RegisterUser(userName, password);

                if (success)
                {
                    MessageBox.Show("User registered successfully!");
                    Felhasznalonev.Clear();
                    Jelszo.Clear();
                    JelszoUjra.Clear();
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
        public async Task<bool> RegisterUser(string userName, string password)
        {
            string apiUrl = "http://localhost/API/registration.php";

            UserRegistrationData registrationData = new UserRegistrationData();
            registrationData.userName = userName;
            registrationData.password = password;

            using (HttpClient client = new HttpClient())
            {
                string jsonData = JsonConvert.SerializeObject(registrationData);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    dynamic result = JsonConvert.DeserializeObject(responseContent);

                    if (result.error == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(result.message.ToString());
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("An error occurred while registering the user.");
                    return false;
                }
            }
        }
    }
}
