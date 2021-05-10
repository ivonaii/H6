using System;
using System.Collections.Generic;

namespace H6._02
{
    class Program
    {
        static void Main(string[] args)
        {
            var military = new List<Military>();
            military.Add(new Ship(200, 80));
            military.Add(new Airplane("MiG-15", 1075, 0));
            foreach (var militaryVehicle in military)
            {
                militaryVehicle.Power();
            }

            var passengerss = new List<Passenger>();
            passengerss.Add(new Airplane("A380", 945, 853));
            passengerss.Add(new Train(1182, 4440));
            foreach (var pass in passengerss)
            {
                pass.Boarding(1000);
            }

            var caargo = new List<Cargo>();
            caargo.Add(new Ship(80000, 30));
            caargo.Add(new Train(1182, 4440));
            foreach (var carg in caargo)
            {
                carg.LoadingWithGoods();
            }
                
        }
    }
}
