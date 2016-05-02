using Nikpc.Classes;
using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class CartController : IProductViewHandler, IProductListViewHandler
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
            if (UserController.currentUser.Cart != null)
            {
                foreach (var item in UserController.currentUser.Cart)
                {
                    ProductList.Add(item.Product);
                }
            }
        }
    }
}
