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
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        ProductController pc;
        CartController cc;
        nikpcEntities1 db = new nikpcEntities1();

        public PaymentWindow(Object price)
        {
            pc = new ProductController();
            cc = new CartController();
            InitializeComponent();
            this.DataContext = price.ToString();
            chosenProductList.DataContext = cc;
        }

        private void payButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in UserController.currentUser.Cart)
            {
                pc.ReserveProduct(item);
            }
            
            UserController.currentUser.Cart = new List<ProductInCart>();

            MessageBox.Show("Sikeres rendelés!");
            Close();
        }
    }
}
