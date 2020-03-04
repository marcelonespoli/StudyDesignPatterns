using CommandSolution2.Interfaces;
using CommandSolution2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandSolution2.Commands
{
    public class ProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly PriceAction _priceAction;
        private readonly int _amount;

        public bool IsCommandExecuted { get; private set; }

        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public void ExecuteAction()
        {
            if (_priceAction == PriceAction.Increase)
            {
                _product.IncreasePrice(_amount);
                IsCommandExecuted = true;
                return;
            }
            
            _product.DecreasePrice(_amount);            
        }

        public void UndoAction()
        {
            if (!IsCommandExecuted)
                return;

            if (_priceAction == PriceAction.Increase)
            {
                _product.DecreasePrice(_amount);
                return;
            }

            _product.IncreasePrice(_amount);
        }
    }
}
