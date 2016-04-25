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
            UserController.currentUser=uc.LogInAuthentication(userNameTxt.Text, passwordTxt.Password);
            if (userNameTxt.Text == "" || passwordTxt.Password == "")
            {
                MessageBox.Show("Nem adta meg a belépési adatait!", "Hiányos adatok", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (UserController.currentUser != null && UserController.currentUser.Type != "admin")
            {
                ProductListWindow plw = new ProductListWindow();
                plw.Show();
                this.Close();
            }
            else if (UserController.currentUser != null)
            {
                AdminWindow aw = new AdminWindow();
                aw.Show();
                var users = from i in db.User
                            select i;
                foreach (User u in users)
                {
                    if (!u.Id.Equals(UserController.currentUser.Id))
                        UserController.AllUsers.Add(u);
                }
                this.Close();
            }
            else
            {
                if (MessageBoxResult.Yes == MessageBox.Show("Sikertelen bejelentkezés!\nBelép vendégként?", "Sikertelen", MessageBoxButton.YesNo))
                {
                    ProductListWindow plw = new ProductListWindow();
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

        private void enterAsQuestClick(object sender, RoutedEventArgs e)
        {
            ProductListWindow plw = new ProductListWindow();
            plw.Show();
            this.Close();
        }
    }
}
