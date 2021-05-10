using System;
using System.Collections.Generic;
using System.Text;

namespace H6
{
    interface SellingCar
    {
        public double Price { get; set; }

        void SellACar(Car car);
        
    }
}
