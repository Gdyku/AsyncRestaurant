using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders.Dishes
{
    class Hamburger : IDish
    {
        public Hamburger(int number, string name)
        {
            Number = number;
            Name = name;
        }
        public int Number { get; set; }
        public string Name { get; set ; }
        public TimeSpan? WaitingTime { get; set; }

        public async Task Preparing()
        {
            await ZlozenieHamburgera();
        }

        private async Task RozcinanieBułki()
        {
            Console.WriteLine("Rozcinanie bułki...");
            await Task.Delay(1000);
            Console.WriteLine("Bułka rozcięta");
        }

        private async Task KrojenieWarzyw()
        {
            Console.WriteLine("Rozpoczęcie krojenia warzyw...");
            await Task.Delay(3000);
            Console.WriteLine("Warzywa skrojone");
        }

        private async Task PrzygotowanieBurgera()
        {
            Console.WriteLine("Przygotowanie mięsa do smażenia...");
            await Task.Delay(2000);
            Console.WriteLine("Smażenie burgera...");
            await Task.Delay(2000);
            Console.WriteLine("Burger gotowy");
        }

        private async Task ZlozenieHamburgera()
        {
            await RozcinanieBułki();
            await KrojenieWarzyw();
            await PrzygotowanieBurgera();

            Console.WriteLine("Rozpoczęcie składania hamburgera");
            await Task.Delay(2000);
            Console.WriteLine("Hamburger gotowy do podania");
        }
    }
}
