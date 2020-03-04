using FactoryMethodSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSolution.Models
{
    public class PickupTruck : IVehicle
    {
        public void Limit(int limit)
        {
            Console.WriteLine("Limit of velocity Pickup Truck: " + limit);
        }
    }
}
