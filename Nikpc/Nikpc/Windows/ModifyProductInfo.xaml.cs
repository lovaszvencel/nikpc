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
    /// Interaction logic for ModifyProductInfo.xaml
    /// </summary>
    public partial class ModifyProductInfo : Window
    {
        ProductAdministrationController pac;
        Product p;
        public ModifyProductInfo(Product product)
        {
            pac = new ProductAdministrationController();
            InitializeComponent();
            p = product;
            this.DataContext = product;
        }

        private void modifyProductButton_Click(object sender, RoutedEventArgs e)
        {
            pac.ModifyProduct(p, new Product()
            {
                Name = productNameTxt.Text,
                OnSale = 0,
                Price = int.Parse(productPriceTxt.Text),
                Details = productDetailsTxt.Text,
                Stock = int.Parse(productStockTxt.Text),
                ImageURL = filePathTxt.Text,
                RatingAverage = 0,
                CategoryID = comboBox.SelectedItem != null ? (comboBox.SelectedItem as ProductCategory).Id : 0,
                Available = checkBox.IsChecked.Value
            });
            MessageBox.Show("A módosítás sikeres!");
            this.Close();
        }
    }
}
