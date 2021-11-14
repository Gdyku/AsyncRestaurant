using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncRestaurant.Orders.Dishes
{
    class SchabowyIZiemniaki : IDish
    {
        public SchabowyIZiemniaki(int number, string name)
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

        private Task  GotowanieZiemniakow()
        {
            throw new NotImplementedException();
        }
        private Task PrzygotowanieKotleta()
        {
            throw new NotImplementedException();
        }
        private Task PrzygotowanieSurówki()
        {
            throw new NotImplementedException();
        }
    }
}
