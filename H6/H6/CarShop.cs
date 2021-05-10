using System;
using System.Collections.Generic;

namespace H6
{
    class CarShop
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            cars.Add(new SportCar("Ford", "Mustang", "sport car", 5.0, 5, 19, 460, 76538));
            cars.Add(new SportCar("Toyota", "Supra", "sport car", 3.0, 2, 19, 340, 42990));
            cars.Add(new SportCar("Nissan", "Silvia", "sport car", 2.0, 4, 18, 655, 71088));
            cars.Add(new SportCar("Nissan", "GT-R", "sport car", 3.8, 5, 20, 480, 70000));
            cars.Add(new SportCar("Hyundai", "i20", "regular car", 1.1, 5, 15, 75, 10241));

            foreach (var sportcar in cars) 
            {
                sportcar.FullCharacteristics();
            }

            cars[3].Broke();
            cars[1].SellACar(cars[1]);
        }
    }
}
