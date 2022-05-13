using Nshopsolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
    public class Order//tham chiếu đến userId
    {
        public Guid OrderId { get; set; }//primary key
        public Guid UserId { get; set; }
        public DateTime CreateDay { get; set; }//ngày tạo
        public Status status { get; set; }//trạng thái của đơn hàng
        /*public double Total { get; set; }//tổng tiền*/
        public List<OrderDetail> OrderDetails { get; set; }
        public AppUser AppUser { get; set; }
    }
}
