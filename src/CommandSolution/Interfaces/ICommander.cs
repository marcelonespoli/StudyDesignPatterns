using System;
using System.Collections.Generic;
using System.Text;

namespace CommandSolution.Interfaces
{
    public interface ICommander
    {
        void Execute();
        void UnExecute();
    }
}
