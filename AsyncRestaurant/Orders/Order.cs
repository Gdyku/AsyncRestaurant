using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncRestaurant.Orders
{
    class Order
    {
        public Table Table { get; set; }
        public IDish Dish { get; set; }
        public TimeSpan? WaitingTime { get; set; }
    }
}
