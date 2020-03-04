using AbstractFactorySolution.Herbivores;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySolution.Carnivores
{
    public abstract class Carnivore
    {
        public abstract void Devour(Herbivore h);
    }
}
