using FactoryMethodSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSolution.Models
{
    public class Motorcycle : IVehicle
    {
        public void Limit(int limit)
        {
            Console.WriteLine("Limit of velocity Motorcycle: " + limit);
        }
    }
}
