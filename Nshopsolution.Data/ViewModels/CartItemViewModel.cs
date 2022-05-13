using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.ViewModels
{
    public class CartItemViewModel
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public double price { get; set; }//Originprice - Originprice * discount 
        public int Quantity { get; set; }
        public double ToTalPrice => Quantity * price;
    }
}
