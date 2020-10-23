using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSys.entities.enums
{
    enum OrderStatus : int
    {
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERD = 3
    }
}
