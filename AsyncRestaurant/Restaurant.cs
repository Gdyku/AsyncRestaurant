using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncRestaurant
{
    class Restaurant
    {
        public Restaurant(int tables, int cooks, int waiters)
        {
            NumberOfTables = tables;
            NumberOfWaiters = waiters;
            NumberOfCooks = cooks;
        }
        public int NumberOfTables { get; set; }
        public int NumberOfWaiters { get; set; }
        public int NumberOfCooks { get; set; }
    }
}
