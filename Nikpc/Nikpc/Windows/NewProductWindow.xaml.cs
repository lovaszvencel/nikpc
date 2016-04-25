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
        Product p;
        ProductAdministrationController pac;
        public NewProductWindow(Product p)
        {
            this.p = p;
            pac = new ProductAdministrationController();
            InitializeComponent();
        }

        private void modifyProductButton_Click(object sender, RoutedEventArgs e)
        {
            p.Name = productNameTxt.Text;
            p.Price = int.Parse(productPriceTxt.Text);
            p.Details = productDetailsTxt.Text;
            p.Available = checkBoxAvailable.IsChecked.Value;
            p.Stock = int.Parse(productPriceTxt.Text);
            this.Close();
        }
    }
}
