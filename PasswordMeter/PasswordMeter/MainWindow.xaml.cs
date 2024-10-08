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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordMeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Input velden: userNameTextBox en passwordTextBox
        /// Output veld: resultTextBlock
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();
        }

        private void passwordMeterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                resultTextBlock.Text = "Je moet een wachtwoord en gebruikersnaam ingeven.";
                return;
            }

            int passwordStrengt = 0;
            int bevatcijfer = 0;

            if (!password.Contains(username))
            {
                passwordStrengt++;
            }

            if (password.Length >= 10)
            {
                passwordStrengt++;
            }

            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            foreach (char character in password.ToCharArray())
            {
                if (char.IsDigit (character))
                {
                    hasDigit = true;
                }

                if (char.IsUpper(character))
                {
                    hasUpper = true;
                }

                if (char.IsLower(character))
                {
                    hasLower = true;
                }
                if (hasDigit)
                {
                    passwordStrengt++;
                }
                if (hasUpper)
                {
                    passwordStrengt++;
                }
                if (hasLower)
                {
                    passwordStrengt++;
                }

                if (passwordStrengt > 4)
                {
                    resultTextBlock.Text = "Je wachtwoord is onbreekbaar.";
                }

                if (passwordStrengt == 4)
                {
                    resultTextBlock.Text = "Je wachtwoord is sterk.";
                }

                if (passwordStrengt <= 3)
                {
                    resultTextBlock.Text = "Je wachtwoord is niet sterk";
                }
                

                


                    
                
            }
        }
    }
}
