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
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows;



namespace Sales_Platform
{
    internal class Connect
    {
        public static MySqlConnection ConnectieSql()
        {
            string connectionStr = "server=localhost;user=root;database=seller_platform;port=3306";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            conn.Open();
            return conn;
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNieuwContract_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnNieuweSalesAgent_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnTeamBekijken_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
    
}
