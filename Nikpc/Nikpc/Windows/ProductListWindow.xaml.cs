using Nikpc.Controllers;
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

namespace Nikpc.Windows
{
    public partial class ProductListWindow : Window
    {
        ProductAdministrationController pac;
        //UserControllerben egy static currentUser van helyette
        public ProductListWindow()
        {
            //UserController.currentUser = user; --> megcsinálja a loginwindowban
            pac = new ProductAdministrationController();
            InitializeComponent();
            productList.DataContext = pac; 
        }

        private void DataClick(object sender, RoutedEventArgs e)
        {
            ModifyingMyDataWindow mmdw = new ModifyingMyDataWindow();
            mmdw.Show();
        }
    }
}
