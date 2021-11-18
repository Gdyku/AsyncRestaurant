using AsyncRestaurant.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncRestaurant
{
    class Restaurant
    {
        public Restaurant(int tables, int waiters, int cooks)
        {
            TablesCount = tables;
            WaitersCount = waiters;
            CooksCount = cooks;
        }
        public int TablesCount { get; set; }
        public int WaitersCount { get; set; }
        public int CooksCount { get; set; }
        public IEnumerable<IOrder> OrderList { get; set; }
    }
}
