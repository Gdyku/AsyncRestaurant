using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders
{
    public interface IDish
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public TimeSpan? WaitingTime { get; set; }
        public Task Preparing();
    }
}
