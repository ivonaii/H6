using System;
using System.Collections.Generic;
using System.Text;

namespace H6
{
    public abstract class Car : Vehicle, SellingCar
    {
        public abstract double Volume { get; set; }

        public int Seats { get; set; }

        public int WheelSize { get; set; }
        public int HorsePower { get; set; }
        public double Price { get ; set; }

        public abstract void WheelChange(int wheelsize);

        public void FullCharacteristics()
        {
            Console.WriteLine("This car has {0}L engine capacity \n {1} seats \n {2}inch wheel size \n {3} hp \n {4}$",
                Volume, Seats, WheelSize, HorsePower, Price);
        }

        public void SellACar(Car car)
        {
             Console.WriteLine("This car has been sold for {0}", Price);
             car = null;
        }
    }
}
