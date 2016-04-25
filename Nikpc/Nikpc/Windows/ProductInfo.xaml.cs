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
    /// Interaction logic for ProductInfo.xaml
    /// </summary>
    public partial class ProductInfo : Window
    {
        Controllers.ProductController pc;
        Product product;

        public ProductInfo(Product product)
        {
            InitializeComponent();
            this.DataContext = product;
            this.product = product;
            pc = new Controllers.ProductController();
        }

        private void addToCartButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.product.Available == false)
            {
                MessageBox.Show("Ez a termék sajnos nem elérhető!");
            }
            else if (this.product.Stock <= 0)
            {
                MessageBox.Show("Ez a termék sajnos elfogyott!");
            }
            else
            {
                pc.AddProductToCart(this.product);
                MessageBox.Show("Kosárhoz adva!");
                Close();
            }
        }
    }
}
