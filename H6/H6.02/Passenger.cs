using System;
using System.Collections.Generic;
using System.Text;

namespace H6._02
{
    public interface Passenger
    {   
        public int MaxPassengers { get; set; }

        public void Boarding(int passengers);

    }
}
