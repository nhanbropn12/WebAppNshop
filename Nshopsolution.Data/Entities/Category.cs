using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
   public class Category
    {
      public int  Id { set; get; }
      public int SortOrder { set; get; }
        public int  IsShowOnHome { set; get; }
        public int?  ParentId { set; get; }
        public int  Status { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
