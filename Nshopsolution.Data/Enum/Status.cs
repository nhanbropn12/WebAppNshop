using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Enum
{
    public enum Status
    {
        failed,//giao không thành công
        Canceled,//đơn hàng bị hủy
        Complete,//đơn hàng giao thành công
        Processing//đang xử lý

    }
}
