using System;
using System.Collections.Generic;
using System.Text;

namespace H6._02
{
    public class Train : Passenger, Cargo
    {
        public int MaxPassengers { get; set; }
        public int MaxCapacity { get; set; }

        public void Boarding(int passengers)
        {
            if (passengers > MaxPassengers)
            {
                Console.WriteLine("The train will not leave the train station.");
            }
            else
            {
                Console.WriteLine("The train will depart.");
            }
        }

        public void LoadingWithGoods()
        {
            Console.WriteLine("The products with witch the train is loaded are coal, animal products and tobacco products."); ;
        }

        public Train(int maxpassengers, int maxcapacity)
        {
            MaxPassengers = maxpassengers;
            MaxCapacity = maxcapacity;
        }
    }
}
