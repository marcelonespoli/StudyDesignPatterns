using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSolution
{
    public class Investor : IInvestor
    {
        private readonly string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notify {0} what {1} " +
              "have price changed for {2:C}", _name, stock.Symbol, stock.Price);
        }

        public Stock Stock { get; set; }
    }
}
