using AbstractFactorySolution.Herbivores;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySolution.Carnivores
{
    public class Wolf : Carnivore
    {
        public override void Devour(Herbivore h)
        {
            Console.WriteLine(GetType().Name + " devour " + h.GetType().Name);
        }
    }
}
