﻿using Nikpc.Classes;
using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class CartController : Bindable, IProductViewHandler, IProductListViewHandler
    {
        nikpcEntities1 db = new nikpcEntities1();
        public ObservableCollection<Product> ProductList { get; set; }

        public CartController()
        {
            ProductList = new ObservableCollection<Product>();
            Feltolt();
        }

        private void Feltolt()
        {
            foreach (var item in UserController.currentUser.Cart)
            {
                ProductList.Add(item.Product);
            }
        }

        public void AddProductRating(int value, string review)
        {
            throw new NotImplementedException();
        }

        public void OpenProductImage(Product product)
        {
            throw new NotImplementedException();
        }

        public void AddProductToCart(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductFromCart(Product product)
        {
            throw new NotImplementedException();
        }

        public void ViewSearchProduct(string productName, ProductCategory productCategory, int priceFrom, int priceTo, bool available)
        {
            throw new NotImplementedException();
        }

        public void ListAddProductToCart(Product product)
        {
            throw new NotImplementedException();
        }

        public void ListDeleteProductFromCart(Product product)
        {
            throw new NotImplementedException();
        }

        public void ViewSortProducts(string sortByParameter, bool ascending)
        {
            throw new NotImplementedException();
        }
    }
}
