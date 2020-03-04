using AbstractFactorySolution.Carnivores;
using AbstractFactorySolution.Factory;
using AbstractFactorySolution.Herbivores;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySolution
{
    public class Animals
    {
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;

        public Animals(ContinenteFactory factory)
        {
            _carnivore = factory.GetCarnivore();
            _herbivore = factory.GetHerbivore();
        }

        public void HuntFood()
        {
            _carnivore.Devour(_herbivore);
        }
    }
}
