using System;

namespace ObserverSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("João"));
            ibm.Attach(new Investor("Maria"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }

    }


}
