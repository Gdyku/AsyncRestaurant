using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders.Dishes
{
    class RybaZFrytkami : IDish
    {
        public RybaZFrytkami(int number, string name)
        {
            Number = number;
            Name = name;
        }
        public int Number { get; set; }
        public string Name { get; set; }
        public TimeSpan? WaitingTime { get; set; }

        public Task Preparing()
        {
            throw new NotImplementedException();
        }

        private async Task PrzygotowanieFrytek()
        {
            Console.WriteLine("Pieczenie frytek...");
            await Task.Delay(3000);
            Console.WriteLine("Frytki upieczone");
        }

        private Task PrzygotowanieRyby()
        {
            Console.WriteLine("");
            
        }

        private Task PrzygotowanieSurówki()
        {
            throw new NotImplementedException();
        }
    }
}