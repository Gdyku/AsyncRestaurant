using AsyncRestaurant.Logic;
using AsyncRestaurant.Orders;
using AsyncRestaurant.Orders.Dishes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncRestaurant
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Ile stolików mamy w restauracji?");
            int tables = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ile kucharzy pracuje w restauracji?");
            int cooks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ilu kelnerów pracuje w restauracji");
            int waiters = Convert.ToInt32(Console.ReadLine());
            var restaurant = new Restaurant(tables, waiters, cooks);

            var orderList = new List<IOrder>();
            while(true)
            {
                Console.WriteLine("Dodaj kolejne zamówienie\n1. Hamburger\n2. Jajecznica\n3. Ryba z Frytkami\n4. Schabowy z ziemniakami");
                int order = Convert.ToInt32(Console.ReadLine());

                SetTables:
                Console.WriteLine("Jaki numer stolika?");
                int tableNumber = Convert.ToInt32(Console.ReadLine());
                if(tableNumber > restaurant.TablesCount)
                {
                    Console.WriteLine("Nie ma takiego stolika w restauracji, wpisz jeszcze raz");
                    goto SetTables;
                }

                Console.WriteLine("Jak długo możesz czekać na zamówienie?");
                int maxWaitingTime = Convert.ToInt32(Console.ReadLine());
                switch (order)
                {
                    case 1:
                        {
                            orderList.Add(new Hamburger(maxWaitingTime, tableNumber));
                        }
                        break;
                    case 2:
                        {
                            orderList.Add(new Jajecznica(maxWaitingTime, tableNumber));
                        }
                        break;
                    case 3:
                        {
                            orderList.Add(new RybaZFrytkami(maxWaitingTime, tableNumber));
                        }
                        break;
                    case 4:
                        {
                            orderList.Add(new SchabowyIZiemniaki(maxWaitingTime, tableNumber));
                        }
                        break;
                }

                Console.WriteLine("Do you want to add next item?\n1. Yes\n2. No");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                    continue;
                else
                    break;
            }

            restaurant.OrderList = orderList;
            var runSimulation = new RestaurantLogic(restaurant);
            await runSimulation.StartCooking();
        }
    }
}
