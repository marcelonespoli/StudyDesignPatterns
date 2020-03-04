using MortageFacade.Assembly;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortageFacade.Facade
{
    public class Mortgage
    {
        private readonly Bank _bank;
        private readonly Loan _loan;
        private readonly Credit _credit;

        public Mortgage()
        {
            _bank = new Bank();
            _loan = new Loan();
            _credit = new Credit();
        }

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} check approve for loan of: {1:C} \n", cust.Name, amount);

            var eligible = true;

            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
