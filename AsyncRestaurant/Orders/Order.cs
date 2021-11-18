using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders
{
    public abstract class Order : IOrder
    {
        public bool IsReady { get; protected set; }

        public int Table { get; private set; }

        public long TimeToCook { get; private set; }

        public Order(int timeToCook, int table)
        {
            TimeToCook = timeToCook;
            Table = table;
        }

        public abstract Task Cook(CancellationToken cancellationToken);

        public abstract Task Deliver();
    }
}
