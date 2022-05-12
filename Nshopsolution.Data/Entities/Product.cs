using Nshopsolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
   public class Product
    {
        
        public Guid idproduct { get; set; }

        public string IdCategory { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }//Số lượng hàng
        public decimal OriginalPrice { get; set; }//Giá gốc
        /*public int QuantityOfComment*/
        public Rate Rating { get; set; }//đánh giá sản phẩm
        public string Specifications { get; set; }//chi tiết sản phẩm
        /*public int soluongdaban*/
        public string ImageProduct { get; set; }
        /*IDcửa hàng
         id hãng
        id danh mục*/
        public int Warranty { get; set; }//thời gian bảo hành
        public Category Category { get; set; }
    }
}
