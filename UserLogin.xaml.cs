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

namespace ContractSystemClaimSystem3
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        // Login button click event
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            // Check if the email and password are correct (this is a placeholder for actual authentication logic)
            if (email == "mbalinkosi114.com" && password == "Mbali@17.")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                // Open the next window (e.g., the claims management window) after login
                StatusOrViewClaims1 statusOrViewClaims = new StatusOrViewClaims1();
                statusOrViewClaims.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
