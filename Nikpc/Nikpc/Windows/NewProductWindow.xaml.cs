using Nikpc.Controllers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class NewProductWindow : Window
    {
        ProductAdministrationController pac;
        public NewProductWindow()
        {
            pac = new ProductAdministrationController();
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            pac.AddProduct(new Product()
            {
                Name = productNameTxt.Text,
                OnSale = 0,
                Price = int.Parse(productPriceTxt.Text),
                Details = productDetailsTxt.Text,
                Stock = int.Parse(productStockTxt.Text),
                ImageURL = filePathTxt.Text,
                RatingAverage = 0,
                CategoryID = comboBox.SelectedItem != null ? (comboBox.SelectedItem as ProductCategory).Id : 0,
                Available = checkBoxAvailable.IsChecked.Value
            });
            this.Close();
        }
    }
}
