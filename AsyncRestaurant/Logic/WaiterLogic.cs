using AsyncRestaurant.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncRestaurant.Logic
{
    class WaiterLogic
    {
        public Task DeliverMeal(IOrder order)
        {
            return Task.Run(async () =>
            {
                await order.Deliver();
            });
        }
    }
}
