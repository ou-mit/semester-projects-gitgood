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

namespace TACalender
{
    /// <summary>
    /// Interaction logic for AdminPassword.xaml
    /// </summary>
    public partial class AdminPassword : Window
    {
        const string username = "aackerman";
        const string password = "MISAdmin";

        public AdminPassword()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usernameAttempt = txtUsername.Text;
            string passwordAttempt = txtPassword.Text;

            if (usernameAttempt != username || passwordAttempt != password) 
            { 
                txtWrongCredentials.Visibility = Visibility.Visible;
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                txtWrongCredentials.Visibility = Visibility.Hidden;
                MessageBox.Show("You're in");
            }
        }
    }
}
