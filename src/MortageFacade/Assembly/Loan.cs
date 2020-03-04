using System;
using System.Collections.Generic;
using System.Text;

namespace MortageFacade.Assembly
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Verify Loans for: " + c.Name);
            return true;
        }
    }
}
