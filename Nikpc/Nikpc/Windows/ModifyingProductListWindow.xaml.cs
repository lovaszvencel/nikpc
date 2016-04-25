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
    /// Interaction logic for ModifyingProductListWindow.xaml
    /// </summary>
    public partial class ModifyingProductListWindow : Window
    {
        ProductAdministrationController pac;
        public ModifyingProductListWindow()
        {
            pac = new ProductAdministrationController();
            InitializeComponent();
            this.productList.DataContext = pac;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            NewProduct np = new NewProduct();
            np.Show();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {

        }

        private void ModifyClick(object sender, RoutedEventArgs e)
        {

        }

        private void AddClick(object sender, RoutedEventArgs e)
        {

        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
