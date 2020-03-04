using System;
using System.Collections.Generic;
using System.Text;

namespace MortageFacade.Assembly
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Validate account of: " + c.Name);
            return true;
        }

    }
}
