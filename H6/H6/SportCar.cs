using System;
using System.Collections.Generic;
using System.Text;

namespace H6
{
    public class SportCar : Car
    {
        public override double Volume { get; set; }
        public override string Brand { get; set; }

        public override void WheelChange(int wheelsize)
        {
            if (WheelSize == wheelsize)
            {
                Console.WriteLine("The wheel is successfully cahnged.");
            }
            else
            {
                Console.WriteLine("The wheel size does not match.");
            }
        }
        public SportCar(string brand, string model, string type, double volume, int seats, int wheelsize, 
            int horsepower, double price)
        {
             Brand = brand;
             Model = model;
             Type = type;
             Volume = volume;
             Seats = seats;
             WheelSize = wheelsize;
             HorsePower = horsepower;
             Price = price;
        }

        public override void Broke()
        {
            Console.WriteLine("The car wheel has gone.");
        }
    }


}
