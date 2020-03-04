using System;
using System.Collections.Generic;
using System.Text;

namespace CommandSolution.Commands
{
    public class Calculator
    {
        private int _curr;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }

            Console.WriteLine("Current value = {0,3} (given {1} {2})", _curr, @operator, operand);
        }
    }
}
