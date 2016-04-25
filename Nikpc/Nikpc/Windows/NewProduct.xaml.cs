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
    public partial class NewProduct : Window
    {
        ProductAdministrationController pac;
        public NewProduct()
        {
            pac = new ProductAdministrationController();
            InitializeComponent();
        }

        private void modifyProductButton_Click(object sender, RoutedEventArgs e)
        {
            pac.AddProduct(new Product
            {
                Name = productNameTxt.Text,
                Price = int.Parse(productPriceTxt.Text),
                Details = productDetailsTxt.Text,
                Available = checkBoxAvailable.IsChecked.Value,
                Stock = int.Parse(productPriceTxt.Text),
            });
            MessageBox.Show("Sikeres mentés!");
            this.Close();
        }
    }
}
