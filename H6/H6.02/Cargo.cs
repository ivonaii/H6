using System;
using System.Collections.Generic;
using System.Text;

namespace H6._02
{
    public interface Cargo
    {
        public int MaxCapacity { get; set; }

        public void LoadingWithGoods();

    }
}
