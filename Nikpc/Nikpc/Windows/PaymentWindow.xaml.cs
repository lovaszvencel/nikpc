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
        nikpcEntities1 db = new nikpcEntities1();
        int? fullPrice;

        public PaymentWindow()
        {
            InitializeComponent();
            Init();
            pc = new ProductController();
            chosenProductList.DataContext = UserController.currentUser.Cart;
        }

        private void Init()
        {
            fullPrice = 0;

            foreach (var item in UserController.currentUser.Cart)
            {
                fullPrice += item.Product.Price * item.Quantity;
            }
        }

        private void payButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in UserController.currentUser.Cart)
            {
                pc.ReserveProduct(item);
            }
            MessageBox.Show("Sikeres rendelés!");
            Close();
        }
    }
}
