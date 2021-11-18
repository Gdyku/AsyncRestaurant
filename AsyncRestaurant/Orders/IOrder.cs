using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders
{
    interface IOrder
    {
        bool IsReady { get; }
        int Table { get; }
        long TimeToCook { get; }
        Task Cook(CancellationToken cancellationToken);
        Task Deliver();
    }
}
