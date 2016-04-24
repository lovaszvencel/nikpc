using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Nikpc.Windows
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "server=pharmindex.hu;uid=NIKadmin;" + "pwd=NIKpassword;database=nikpc;";;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow rw = new RegistrationWindow();
            rw.Show();
        }
    }
}
