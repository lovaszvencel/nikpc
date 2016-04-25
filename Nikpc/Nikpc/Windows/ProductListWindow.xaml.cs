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
using System.Diagnostics;

namespace Nikpc.Windows
{
    public partial class ProductListWindow : Window
    {
        ProductController pc;
        //UserControllerben egy static currentUser van helyette
        public ProductListWindow()
        {
            //UserController.currentUser = user; --> megcsinálja a loginwindowban
            InitializeComponent();
            pc = new ProductController();
        }

        private void DataClick(object sender, RoutedEventArgs e)
        {
            ModifyingMyDataWindow mmdw = new ModifyingMyDataWindow();
            mmdw.Show();
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            pc.ViewSearchProduct(searchTxt.Text, categoryCB.SelectedItem as ProductCategory, priceFromTxt.Text==""?0:int.Parse(priceFromTxt.Text), priceToTxt.Text==""?0:int.Parse(priceToTxt.Text));
        }

        private void productList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ProductInfo piw = new ProductInfo((Product)productList.SelectedItem);
            piw.Show();
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            OrderPlacementWindow opw = new OrderPlacementWindow();
            opw.Show();
        }
    }
}
