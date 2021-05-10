using System;
using System.Collections.Generic;
using System.Text;

namespace H6._02
{
    public class Ship : Cargo, Military
    {
        public int MaxCapacity { get; set; }
        public int MaximumSpeed { get; private set; }

        public void LoadingWithGoods()
        {
            Console.WriteLine("The main products with whitch the ship is loaded are fruits.");
        }

        public void Power()
        {
            Console.WriteLine("The maximum speed of the ship is {0} and its maximum  passenger capacity is {1}!",
                MaximumSpeed, MaxCapacity);
        }

        public Ship(int maxcapacity, int maximumspeed)
        {
            MaximumSpeed = maximumspeed;
            MaxCapacity = maxcapacity;
        }
    }
}
