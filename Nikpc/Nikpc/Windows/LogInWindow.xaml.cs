using Nikpc.Controllers;
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
        UserController uc;
        nikpcEntities1 db = new nikpcEntities1();
        public LogInWindow()
        {
            InitializeComponent();
            var product = from i in db.Product
                          select i;
            foreach (var i in product)
                ProductController.productList.Add(i);

            uc = new UserController();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            User user = uc.LogInAuthentication(userNameTxt.Text, passwordTxt.Password);
            if (user != null)
            {
                ProductListWindow plw = new ProductListWindow(user);
                plw.Show();
                this.Close();
            }
            else
            {
                if (MessageBoxResult.Yes == MessageBox.Show("Sikertelen bejelentkezés!\nBelép vendégként?", "Sikertelen", MessageBoxButton.YesNo))
                {
                    ProductListWindow plw = new ProductListWindow(null);
                    plw.Show();
                    this.Close();
                }
            }

        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow rw = new RegistrationWindow();
            rw.Show();
        }
    }
}
