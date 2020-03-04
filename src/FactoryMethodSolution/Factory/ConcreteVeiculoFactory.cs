using FactoryMethodSolution.Interfaces;
using FactoryMethodSolution.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSolution.Factory
{
    public class ConcreteVeiculoFactory : VeiculoFactory
    {
        public override IVehicle GetVehicle(string category)
        {
            switch (category)
            {
                case "Heavy":
                    return new PickupTruck();
                case "Average":
                    return new Car();
                case "Light":
                    return new Motorcycle();
                default:
                    throw new ApplicationException(string.Format("Veiculo '{0}' cannot be created", category));
            }
        }
    }
}
