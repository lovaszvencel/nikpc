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
    /// Interaction logic for ModifyingOrderListWindow.xaml
    /// </summary>
    public partial class ModifyingOrderListWindow : Window
    {
        OrderController oc;

        public ModifyingOrderListWindow()
        {
            oc = new OrderController();
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (orderList.SelectedItem != null)
            {
                if (MessageBox.Show("Biztosan törli?", "Figyelmeztetés", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    oc.DeleteOrder((Order)orderList.SelectedItem);
                    MessageBox.Show("Sikeres törlés!");
                }
            }
            else
            {
                MessageBox.Show("Jelöljön ki egy elemet!");
            }

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
