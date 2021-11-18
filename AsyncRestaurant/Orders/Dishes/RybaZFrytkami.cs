using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders.Dishes
{
    class RybaZFrytkami : Order
    {
        public RybaZFrytkami(int timeToCook, int table) : base(timeToCook, table)
        {
        }
        public override async Task Cook(CancellationToken cancellationToken)
        {
            await FryingChips(cancellationToken);
            await BakingFish(cancellationToken);
            await MakingSalad(cancellationToken);

            Console.WriteLine($"Stolik {Table}. Ryba z frytkami gotowa do podania");
            IsReady = true;
        }

        public override async Task Deliver()
        {
            Console.WriteLine($"Kelner niesie rybe z frytkami do stolika nr. {Table}...");
            await Task.Delay(3000);
            Console.WriteLine($"Zamówienie ze stolika nr.{Table} zostało zrealizowane");
        }


        private Task FryingChips(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Pieczenie frytek...");
            return Task.Delay(3000, cancellationToken);
        }

        private Task BakingFish(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Pieczenie ryby...");
            return Task.Delay(10000, cancellationToken);
        }

        private Task MakingSalad(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Robienie surówki...");
            return Task.Delay(4000, cancellationToken);
        }
    }
}