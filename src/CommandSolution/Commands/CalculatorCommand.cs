using CommandSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CommandSolution.Commands
{
    public class CalculatorCommand : ICommander
    {
        private char _operator;
        private int _operand;
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public char Operator
        {
            set { _operator = value; }
        }

        public int Operand
        {
            set { _operand = value; }
        }

        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public void UnExecute()
        {
            _operator = Undo(_operator);
            _calculator.Operation(_operator, _operand);
        }

        private static char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }
    }
}
