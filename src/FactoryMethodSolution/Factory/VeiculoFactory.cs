using FactoryMethodSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSolution.Factory
{
    public abstract class VeiculoFactory
    {
        public abstract IVehicle GetVehicle(string categoria);
    }
}
