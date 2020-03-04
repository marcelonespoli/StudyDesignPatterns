using System;
using System.Collections.Generic;
using System.Text;

namespace MortageFacade.Assembly
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Validate credit for: " + c.Name);
            return true;
        }
    }
}
