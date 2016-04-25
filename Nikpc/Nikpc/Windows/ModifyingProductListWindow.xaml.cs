﻿using Nikpc.Controllers;
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

        private void modifyButton_Click(object sender, RoutedEventArgs e)
        {
            if (productList.SelectedItem != null)
            {
                ModifyProductInfo mpw = new ModifyProductInfo(productList.SelectedItem as Product);
                mpw.Show();
            }
            else
                MessageBox.Show("Válassz egy terméket!");
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (productList.SelectedItem != null)
            {
                pac.DeleteProduct(productList.SelectedItem as Product);
                MessageBox.Show("A terméket sikeresen töröltük!", "Temék törlése", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Válassz ki egy terméket!", "Nincs termék kiválasztva", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
