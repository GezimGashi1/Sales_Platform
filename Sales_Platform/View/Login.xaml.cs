using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sales_Platform.View;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sales_Platform.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState= WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            int sellerID;
            if (!int.TryParse(txtSellerID.Text, out sellerID))
            {
                MessageBox.Show("Invalid Seller ID. Please enter a valid numeric ID.");
                return;
            }

            string password = txtPassword.Password;

            using (MySqlConnection connection = Connect.ConnectieSql())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Wachtwoord FROM account WHERE SellerID = @SellerID", connection);
                cmd.Parameters.AddWithValue("@SellerID", sellerID);

                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Seller ID not found.");
                }
                if (result.ToString() == password)
                {
                    // Create an instance of MainWindow
                    var mainWindow = new MainWindow();

                    // Display MainWindow
                    mainWindow.Show();

                    // Close the current login window
                    this.Close();
                }



                else
                {
                    MessageBox.Show("Incorrect password. Please try again.");
                }
            }
        }


    private void txtSellerID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
