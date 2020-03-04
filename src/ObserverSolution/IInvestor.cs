using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSolution
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
