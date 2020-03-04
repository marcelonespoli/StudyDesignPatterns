using AbstractFactorySolution.Carnivores;
using AbstractFactorySolution.Herbivores;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySolution.Factory
{
    public abstract class ContinenteFactory
    {
        public abstract Herbivore GetHerbivore();
        public abstract Carnivore GetCarnivore();
    }
}
