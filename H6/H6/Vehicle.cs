using System;
using System.Collections.Generic;
using System.Text;

namespace H6
{
    public abstract class Vehicle
    {
        public abstract string Brand{ get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        public void Info()
        {
            Console.WriteLine("This is {0}, model {1} and the type of the vehicle is {2}.", Brand, Model, Type);
        }

        public abstract void Broke();

    }
}
