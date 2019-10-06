using System;
using System.Text.RegularExpressions;

using Business.Exceptions;
using Business.Interfaces;

using ConsoleApp.Interfaces;

namespace ConsoleApp.Process
{
    public class ReadNumbersForCalculation : IRead
    {
        private IOperation<int, int> _sumInt;

        public ReadNumbersForCalculation(IOperation<int, int> sumInt)
        {
            _sumInt = sumInt;
        }

        public bool Execute()
        {
            string number = string.Empty;
            var regexNumberOnly = new Regex(@"^[0-9]+$");


            #region First Number
            Console.WriteLine("Please type the first number to add and press ENTER.");
            number = Console.ReadLine();

            if (!regexNumberOnly.IsMatch(number))
                throw new OperationException("Given number is not valid.");

            var firstNumber = int.Parse(number);
            #endregion

            #region Second Number
            Console.WriteLine("Please type the second number and press ENTER for the result.");
            number = Console.ReadLine();

            if (!regexNumberOnly.IsMatch(number))
                throw new OperationException("Given number is not valid.");

            var secondNumber = int.Parse(number);
            #endregion

            var result = _sumInt.Operate(firstNumber, secondNumber);
            Console.WriteLine(string.Format("Result of addition operation for numbers '{0}' and '{1}' is {2}.", firstNumber, secondNumber, result));

            return true;
        }
    }
}
