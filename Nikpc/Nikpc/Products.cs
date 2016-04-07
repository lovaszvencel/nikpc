//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nikpc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public Products()
        {
            this.OrderedProducts = new HashSet<OrderedProducts>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public bool Available { get; set; }
        public Nullable<double> RatingAverage { get; set; }
        public Nullable<int> OnSale { get; set; }
    
        public virtual ICollection<OrderedProducts> OrderedProducts { get; set; }
        public virtual ProductCategories ProductCategories { get; set; }
    }
}
