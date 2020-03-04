using FactoryMethodSolution.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConcreteVeiculoFactory();

            var moto = factory.GetVehicle("Heavy");
            moto.Limit(300);

            var carro = factory.GetVehicle("Average");
            carro.Limit(250);

            var caminhonete = factory.GetVehicle("Light");
            caminhonete.Limit(180);
        }
    }
}
