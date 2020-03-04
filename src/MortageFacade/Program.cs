using MortageFacade.Facade;
using System;

namespace MortageFacade.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facade
            var mortgage = new Mortgage();

            // Assess customer loan eligibility
            var customer = new Customer("Brian Fox");
            var eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name + " was " + (eligible ? "Approved" : "Rejected"));
        }
    }
}
