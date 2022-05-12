using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
    public class Category
    {
        public string IdCategory { get; set; }
        public string CategoryOfName { get; set; }

        public List<Product> Products { get; set; }
    }
}
