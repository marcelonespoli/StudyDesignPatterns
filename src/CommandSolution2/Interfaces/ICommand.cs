using System;
using System.Collections.Generic;
using System.Text;

namespace CommandSolution2.Interfaces
{
    public interface ICommand
    {
        void ExecuteAction();
        void UndoAction();
    }
}
