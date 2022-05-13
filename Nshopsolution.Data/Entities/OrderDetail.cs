using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
    public class OrderDetail//tham chiếu đến User và Product
    {

        public Guid OrderDetailId { get; set; }//primary key
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
       /* public string ProductName { get; set; } đã có khi truy xuất qua idproduct
        public string Image { get; set; }*/
        public double price { get; set; }//Originprice - Originprice * discount 
        public int Quantity { get; set; }
        public double ToTalPrice => Quantity * price;
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
