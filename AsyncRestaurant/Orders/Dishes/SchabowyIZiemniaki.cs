using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders.Dishes
{
    class SchabowyIZiemniaki : Order
    {
        public SchabowyIZiemniaki(int timeToCook, int table) : base(timeToCook, table)
        {
        }

        public override async Task Cook(CancellationToken cancellationToken)
        {
            await BoilingPotatoes(cancellationToken);
            await MakingChop(cancellationToken);
            await MakingSalad(cancellationToken);

            Console.WriteLine($"Stolik {Table}. Schabowy z ziemniakami gotowa do podania");
            IsReady = true;
        }

        public override async Task Deliver()
        {
            Console.WriteLine($"Kelner niesie schabowego z ziemniakami do stolika nr. {Table}...");
            await Task.Delay(3000);
            Console.WriteLine($"Zamówienie ze stolika nr.{Table} zostało zrealizowane");
        }

        private Task  BoilingPotatoes(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Obranie i gotowanie ziemniaków...");
            return Task.Delay(5000, cancellationToken);
        }
        private Task MakingChop(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Rozbicie i przygotowanie kotleta...");
            return Task.Delay(5000, cancellationToken);
        }
        private Task MakingSalad(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Stolik {Table}. Przygotowanie sałatki...");
            return Task.Delay(3000, cancellationToken);
        }
    }
}
