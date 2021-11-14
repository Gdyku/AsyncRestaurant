using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders.Dishes
{
    class Jajecznica : IDish
    {
        public Jajecznica(int number, string name)
        {
            Number = number;
            Name = name;
        }
        public int Number { get; set; }
        public string Name { get; set; }
        public TimeSpan? WaitingTime { get; set; }

        public async Task Preparing()
        {
            await PrzygotowanieBułki();
            await Smazenie();

            Console.WriteLine("Jajecznica gotowa do podania");
        }

        private async Task RozbicieJaj()
        {
            Console.WriteLine("Rozbijanie jaj");
            await Task.Delay(1000);
            Console.WriteLine("jajka rozbite");
        }

        public async Task KrojenieCebuli()
        {
            Console.WriteLine("Krojenie cebuli");
            await Task.Delay(1000);
            Console.WriteLine("Cebula pokrojona");
        }

        public async Task PrzygotowanieBułki()
        {
            Console.WriteLine("Pokrojenie i posmarowanie bułki");
            await Task.Delay(2000);
            Console.WriteLine("Bułka gotowa");
        }

        public async Task Smazenie()
        {
            await RozbicieJaj();
            await KrojenieCebuli();
            Console.WriteLine("Podgrzewanie masła");
            await Task.Delay(1000);
            Console.WriteLine("Podsmażenie cebuli");
            await Task.Delay(1000);
            Console.WriteLine("Dodanie jaj na patelnie");
            await Task.Delay(3000);
        }
    }
}
