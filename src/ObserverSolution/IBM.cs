using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSolution
{
    public class IBM : Stock
    {
        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }
}
