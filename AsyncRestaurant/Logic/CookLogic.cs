using AsyncRestaurant.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static AsyncRestaurant.Logic.RestaurantLogic;

namespace AsyncRestaurant.Logic
{
    class CookLogic
    {
        public Task CookMeal(IOrder order, OrderReady orderReadyEvent)
        {
            var cancellationToken = new CancellationTokenSource(TimeSpan.FromSeconds(order.TimeToCook));

            return Task.Run(async () =>
            {
                cancellationToken.Token.ThrowIfCancellationRequested();

                await order.Cook(cancellationToken.Token);
            }, cancellationToken.Token).ContinueWith(c =>
            {
                orderReadyEvent(order);
            });
        }
    }
}
