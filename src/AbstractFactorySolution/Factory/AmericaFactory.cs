using AbstractFactorySolution.Carnivores;
using AbstractFactorySolution.Herbivores;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySolution.Factory
{
    public class AmericaFactory : ContinenteFactory
    {
        public override Herbivore GetHerbivore()
        {
            return new Rabbit();
        }
        public override Carnivore GetCarnivore()
        {
            return new Wolf();
        }
    }
}
