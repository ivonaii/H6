using System;
using System.Collections.Generic;
using System.Text;

namespace H6._02
{
    public class Airplane : Passenger, Military
    {   
        public string Model { get; set; }

        public int MaximumSpeed { get; set; }
        public int MaxPassengers { get; set; }

        public void Boarding(int passengers)
        {
            if (passengers > MaxPassengers)
            {
                Console.WriteLine("The airplane will not leave.");
            }
            else 
            {
                Console.WriteLine("The airplane will depart.");
            }
        }

        public void Power()
        {

            Console.WriteLine("The maximum speed of {0} is {1} and its maximum  passenger capacity is {2}.",
                Model, MaximumSpeed, MaxPassengers);
        }

        public Airplane(string model, int maximumspeed, int maxpassengers)
        {
            Model = model;
            MaximumSpeed = maximumspeed;
            MaxPassengers = maxpassengers;
        }   

    }
}
