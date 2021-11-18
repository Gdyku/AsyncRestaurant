using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders.Dishes
{
    class Jajecznica : Order
    {
        public Jajecznica(int timeToCook, int table)
            : base(timeToCook, table)
        {
        }

        public override async Task Cook(CancellationToken cancellationToken)
        {
            //await BreakingEggs(cancellationToken);
            //await SlicingOnion(cancellationToken);
            await SlicingBun(cancellationToken);
            await Frying(cancellationToken);

            Console.WriteLine($"Stolik {Table}. Jajecznica gotowa do podania");
            IsReady = true;
        }

        public override async Task Deliver()
        {
            Console.WriteLine($"Kelner niesie Hamburgera do stolika {Table}...");
            await Task.Delay(3000);
            Console.WriteLine($"Zamówienie ze stolika {Table} zostało zrealizowane");
        }

        private Task BreakingEggs(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Rozbijanie jaj...");
            return Task.Delay(1000, cancellationToken);
        }

        private Task SlicingOnion(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Krojenie cebuli...");
            return Task.Delay(1000, cancellationToken);
        }

        private Task SlicingBun(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Krojenie bułki...");
            return Task.Delay(1000, cancellationToken);
        }

        private Task Frying(CancellationToken cancellationToken)
        {
            Task.WhenAll(BreakingEggs(cancellationToken), SlicingOnion(cancellationToken));

            Console.WriteLine($"Stolik {Table}. Smażenie jajecznicy...");
            return Task.Delay(5000, cancellationToken);
        }
    }
}
