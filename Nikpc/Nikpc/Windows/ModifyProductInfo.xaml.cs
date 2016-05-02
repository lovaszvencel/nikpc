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
        Controllers.ProductController pc;
        public ModifyProductInfo(Product product, bool editable = true)
        {
            pac = new ProductAdministrationController();
            pc = new ProductController();
            p = product;
            this.DataContext = product;
            InitializeComponent();

            nikpcEntities1 db = new nikpcEntities1();
            var c = from akt in db.ProductCategory
                    where akt.Id == p.CategoryID
                    select akt;
            if (!editable)
            {
                productNameTxt.Background = Brushes.Transparent;
                productNameTxt.BorderBrush = Brushes.Transparent;
                checkBox.IsEnabled = false;
                productPriceTxt.Background = Brushes.Transparent;
                productPriceTxt.BorderBrush = Brushes.Transparent;
                productStockTxt.Background = Brushes.Transparent;
                productStockTxt.BorderBrush = Brushes.Transparent;
                productDetailsTxt.Background = Brushes.Transparent;
                productDetailsTxt.BorderBrush = Brushes.Transparent;
                filePathTxt.Background = Brushes.Transparent;
                filePathTxt.BorderBrush = Brushes.Transparent;
                browseButton.Visibility = Visibility.Hidden;
                modifyProductButton.Visibility = Visibility.Hidden;
                label.Visibility = Visibility.Hidden;
                addcartButton.Visibility = Visibility.Visible;
                comboBox.Visibility = Visibility.Hidden;
                categoryLabel.Content = c.First().Name;
                categoryLabel.Visibility = Visibility.Visible;
            }
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

        private void addToCartButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.p.Available == false)
            {
                MessageBox.Show("Ez a termék sajnos nem elérhető!");
            }
            else if (this.p.Stock <= 0)
            {
                MessageBox.Show("Ez a termék sajnos elfogyott!");
            }
            else
            {
                pc.AddProductToCart(this.p);
                MessageBox.Show("Kosárhoz adva!");
                Close();
            }
        }
    }
}
