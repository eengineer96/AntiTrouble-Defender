using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


namespace AntiTrouble_Defender_Test
{
    public class RegisterWindowTest
    {
        Register register = new Register();

        [WpfTheory]
        [InlineData("password", "password", Visibility.Hidden)]
        [InlineData("password", "password1", Visibility.Visible)]
        public void JelszoValtozas_ShouldBeExpectedVisibility(string password, string password2, Visibility expectedVisibility)
        {
            PasswordBox jelszo = register.getJelszo();
            PasswordBox jelszoUjra = register.getJelszoUjra();
            jelszo.Password = password;
            jelszoUjra.Password = password2;


            var visibility = register.getVisibility();
            visibility.Should().Be(expectedVisibility);
        }

    }
}

