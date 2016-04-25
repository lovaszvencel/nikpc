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
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void modifyUsersButton_Click(object sender, RoutedEventArgs e)
        {
            ModifyingUserListWindow mulw = new ModifyingUserListWindow();
            mulw.Show();
        }

        private void modifyProductsButton_Click(object sender, RoutedEventArgs e)
        {
            ModifyingProductListWindow mplw = new ModifyingProductListWindow();
            mplw.Show();
        }

        private void productListButton_Click(object sender, RoutedEventArgs e)
        {
            ProductListWindow plw = new ProductListWindow();
            plw.Show();
        }
    }
}
