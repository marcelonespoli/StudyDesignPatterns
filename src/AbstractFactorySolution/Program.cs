using AbstractFactorySolution.Factory;
using System;

namespace AbstractFactorySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var africa = new AfricaFactory();
            var animais = new Animals(africa);
            animais.HuntFood();

            var america = new AmericaFactory();
            animais = new Animals(america);
            animais.HuntFood();
        }
    }
}
