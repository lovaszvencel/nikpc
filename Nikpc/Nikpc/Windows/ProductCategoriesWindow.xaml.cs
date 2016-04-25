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
    /// Interaction logic for ProductCategoriesWindow.xaml
    /// </summary>
    public partial class ProductCategoriesWindow : Window
    {
        ProductCategoryController pcc;
        public ProductCategoriesWindow()
        {
            InitializeComponent();
            pcc = new ProductCategoryController();
        }

        private void newCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (categoryNameTxt.Text != "")
            {
                pcc.AddCategory(categoryNameTxt.Text);
                MessageBox.Show("A kategóriát sikeresen felvettük!", "Új kategória felvétele", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Írj be egy kategória nevet!", "Nincs név megadva", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void deleteCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (categoriesList.SelectedItem != null)
            {
                pcc.DeleteCategory(categoriesList.SelectedItem as ProductCategory);
                MessageBox.Show("A kategóriát sikeresen töröltük!", "Kategória törlése", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Válassz ki egy kategóriát!", "Nincs kategória kiválasztva", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void modifyCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (categoriesList.SelectedItem != null)
            {
                pcc.ModifyCategory(categoryNameTxt.Text, categoriesList.SelectedItem as ProductCategory);                
                categoriesList.ItemsSource = null;
                categoriesList.ItemsSource = Controllers.ProductCategoryController.AllCategories;
                MessageBox.Show("A kategóriát sikeresen módosítottuk!", "Kategória módosítása", MessageBoxButton.OK, MessageBoxImage.Information);
                categoryNameTxt.Text = "";
            }
            else
                MessageBox.Show("Válassz ki egy kategóriát!", "Nincs kategória kiválasztva", MessageBoxButton.OK, MessageBoxImage.Warning);            
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
