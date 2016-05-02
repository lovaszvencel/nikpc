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
using System.Diagnostics;

namespace Nikpc.Windows
{
    public partial class ProductListWindow : Window
    {
        ProductController pc;
        public bool nAsc = true;
        public bool pAsc = true;
        public bool cAsc = true;
        public ProductListWindow()
        {
            InitializeComponent();
            pc = new ProductController();
            ProductController.Atmasol();
        }

        private void DataClick(object sender, RoutedEventArgs e)
        {
            ModifyingMyDataWindow mmdw = new ModifyingMyDataWindow();
            mmdw.Show();
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            pc.ViewSearchProduct(searchTxt.Text, categoryCB.SelectedItem as ProductCategory, priceFromTxt.Text==""?0:int.Parse(priceFromTxt.Text), priceToTxt.Text==""?0:int.Parse(priceToTxt.Text));
        }

        private void productList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ModifyProductInfo piw = new ModifyProductInfo((Product)productList.SelectedItem, false);
            piw.Show();
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            OrderPlacementWindow opw = new OrderPlacementWindow();
            opw.Show();
        }

        private void Name_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PriceLbl.Background = Brushes.White;
            CategoryLbl.Background = Brushes.White;
            if (nAsc)
                NameLbl.Background = Brushes.LightGreen;
            else
                NameLbl.Background = Brushes.PaleVioletRed;
            List<Product> rendezesi = new List<Product>();
            foreach (Product p in ProductController.FilteredProducts)
            {
                rendezesi.Add(p);
            }
            rendezesi.Sort(new Comparer<Product>("Name", nAsc));
            ProductController.FilteredProducts.Clear();
            foreach (Product p in rendezesi)
            {
                ProductController.FilteredProducts.Add(p);
            }
            productList.ItemsSource = null;
            productList.ItemsSource = ProductController.FilteredProducts;
            nAsc = !nAsc;
        }

        private void Price_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CategoryLbl.Background = Brushes.White;
            NameLbl.Background = Brushes.White;
            if (pAsc)
                PriceLbl.Background = Brushes.LightGreen;
            else
                PriceLbl.Background = Brushes.PaleVioletRed;
            List<Product> rendezesi = new List<Product>();
            foreach (Product p in ProductController.FilteredProducts)
            {
                rendezesi.Add(p);
            }
            rendezesi.Sort(new Comparer<Product>("Price", pAsc));
            ProductController.FilteredProducts.Clear();
            foreach (Product p in rendezesi)
            {
                ProductController.FilteredProducts.Add(p);
            }
            productList.ItemsSource = null;
            productList.ItemsSource = ProductController.FilteredProducts;
            pAsc = !pAsc;
        }

        private void Category_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PriceLbl.Background = Brushes.White;
            NameLbl.Background = Brushes.White;
            if (cAsc)
                CategoryLbl.Background = Brushes.LightGreen;
            else
                CategoryLbl.Background = Brushes.PaleVioletRed;
            List<Product> rendezesi = new List<Product>();
            foreach (Product p in ProductController.FilteredProducts)
            {
                rendezesi.Add(p);
            }
            rendezesi.Sort(new Comparer<Product>("Category", cAsc));
            ProductController.FilteredProducts.Clear();
            foreach (Product p in rendezesi)
            {
                ProductController.FilteredProducts.Add(p);
            }
            productList.ItemsSource = null;
            productList.ItemsSource = ProductController.FilteredProducts;
            cAsc = !cAsc;
        }
    }
    class Comparer<T> : IComparer<T>
    {
        string tipus = "";
        bool asc = true;
        public Comparer(string tipus, bool asc)
        {
            this.tipus = tipus;
            this.asc = asc;
        }
        public int Compare(T x, T y)
        {
            switch(tipus)
            {
                case "Name":{
                    if(asc) return (x as Product).Name.CompareTo((y as Product).Name);
                    else return (y as Product).Name.CompareTo((x as Product).Name);
                };

                case "Price":{
                    if (asc)
                        if ((x as Product).Price > (y as Product).Price)
                            return 1;
                        else if ((x as Product).Price == (y as Product).Price)
                            return 0;
                        else
                            return -1;
                    else
                        if ((x as Product).Price > (y as Product).Price)
                            return -1;
                        else if ((x as Product).Price == (y as Product).Price)
                            return 0;
                        else
                            return 1;
                };

                case "Category":{
                    if(asc)
                        if ((x as Product).CategoryID > (y as Product).CategoryID)
                            return 1;
                        else if ((x as Product).CategoryID == (y as Product).CategoryID)
                            return 0;
                        else
                            return -1;
                    else
                        if ((x as Product).CategoryID > (y as Product).CategoryID)
                            return -1;
                        else if ((x as Product).CategoryID == (y as Product).CategoryID)
                            return 0;
                        else
                            return 1;
                };
                default: return -5;
            }
        }
    }
}
