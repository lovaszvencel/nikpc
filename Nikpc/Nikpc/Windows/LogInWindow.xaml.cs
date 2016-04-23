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
            if (string.IsNullOrWhiteSpace(userNameTxt.Text) || string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                MessageBox.Show("Kérjük adja meg a felhasználónevét és jelszavát is!");
            }
            else
            {
                NIKPC_DatabaseDataSet DB = new NIKPC_DatabaseDataSet();
                var user = DB.User.Single(x => x.Username == userNameTxt.Text);
                MessageBox.Show(user.Password);
            }
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow rw = new RegistrationWindow();
            rw.Show();
        }
    }
}
