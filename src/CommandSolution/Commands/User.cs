using CommandSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandSolution.Commands
{
    public class User
    {
        // Initializers
        private readonly Calculator _calculator = new Calculator();
        private readonly List<ICommander> _commands = new List<ICommander>();
        private int _current;

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            var command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();

            // Add command to undo list
            _commands.Add(command);
            _current++;
        }

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Return {0} levels ", levels);
            
            // Perform redo operations
            for (var i = 0; i < levels; i++)
            {
                if (_current >= _commands.Count - 1) continue;
                var command = _commands[_current++];
                command.Execute();
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            // Perform undo operations
            for (var i = 0; i < levels; i++)
            {
                if (_current <= 0) continue;
                var command = _commands[--_current];
                command.UnExecute();
            }
        }
    }
}
