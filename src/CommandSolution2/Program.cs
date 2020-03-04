using CommandSolution2.Commands;
using CommandSolution2.Interfaces;
using CommandSolution2.Models;
using System;

namespace CommandSolution2
{
    class Program
    {
        static void Main(string[] args)
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);

            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 25));

            Console.WriteLine(product);
            Console.WriteLine();


            modifyPrice.UndoActions();
            Console.WriteLine(product);
        }

        private static void Execute(Product product, ModifyPrice modifyPrice, ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
