using AsyncRestaurant.Orders;
using AsyncRestaurant.Orders.Dishes;
using System;
using System.Collections.Generic;

namespace AsyncRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tables we have in restaurant?");
            int tables = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cooks are working in restaurant");
            int cooks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many waiters are working in restaurant");
            int waiters = Convert.ToInt32(Console.ReadLine());
            var restaurant = new Restaurant(tables, cooks, waiters);

            var menu = new List<IDish>()
            {
                new Jajecznica(1, "Jajecznica"),
                new SchabowyIZiemniaki(2, "Schabowy z ziemniakami"),
                new RybaZFrytkami(3, "Ryba z frytkami"),
                new Hamburger(4, "Hamburger")
            };

            List<Order> orders = new List<Order>();
            while(true)
            {
                Console.WriteLine("Add order to list");
                var order = new Order();
                Console.WriteLine("Set table number");
                order.Table.Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Set dish id/number");
                order.Dish.Number = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
