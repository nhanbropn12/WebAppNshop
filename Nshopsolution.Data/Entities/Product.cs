using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
        
    public class Product
    {
        public int Id { set; get; }
       public decimal  Price { set; get; }
        public decimal Originalprice { set; get; }

        public int  Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public String SeoAlias { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
