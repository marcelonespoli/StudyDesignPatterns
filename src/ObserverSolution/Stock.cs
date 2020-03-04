﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSolution
{
    public abstract class Stock
    {
        private double _price;
        private readonly List<IInvestor> _investors = new List<IInvestor>();

        protected Stock(string symbol, double price)
        {
            Symbol = symbol;
            _price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        private void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol { get; private set; }
    }
}