using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders.Dishes
{
    class Hamburger : Order
    {
        public Hamburger(int timeToCook, int table) : base(timeToCook, table)
        { 
        }

        public override async Task Cook(CancellationToken cancellationToken)
        {
            //await SliceBun(cancellationToken);
            //await BeatMeat(cancellationToken);
            await AssemblyBurger(cancellationToken);

            Console.WriteLine($"Stolik {Table}. Hamburger gotowa do podania");
            IsReady = true;
        }

        public override async Task Deliver()
        {
            Console.WriteLine($"Kelner niesie Hamburgera do stolika {Table}...");
            await Task.Delay(3000);
            Console.WriteLine($"Zamówienie ze stolika {Table} zostało zrealizowane");
        }

        private Task SliceBun(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Krojenie bułki...");
            return Task.Delay(1000, cancellationToken);
        }

        private Task BeatMeat(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Przygotowanie kotleta...");
            return Task.Delay(5000, cancellationToken);
        }

        private Task AssemblyBurger(CancellationToken cancellationToken)
        {
            Task.WhenAll(SliceBun(cancellationToken), BeatMeat(cancellationToken));

            Console.WriteLine($"Stolik {Table}. Składanie burgera...");
            return Task.Delay(2000, cancellationToken);
        }
    }
}
