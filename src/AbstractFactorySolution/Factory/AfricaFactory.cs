using AbstractFactorySolution.Carnivores;
using AbstractFactorySolution.Herbivores;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySolution.Factory
{
    public class AfricaFactory : ContinenteFactory
    {
        public override Herbivore GetHerbivore()
        {
            return new Gazelle();
        }
        public override Carnivore GetCarnivore()
        {
            return new Lion();
        }
    }
}
