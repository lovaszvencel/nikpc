//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nikpc
{
    using System;
    using System.Collections.Generic;
    
    public class ProductInCart
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public ProductInCart(Product product)
        {
            Product = product;
            Quantity = 1;
        }


    }
    
    public partial class User
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return Name + " (" + Username + ")";
        }
        public List<ProductInCart> Cart = new List<ProductInCart>();
    }
}
