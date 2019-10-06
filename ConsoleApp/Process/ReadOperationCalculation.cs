using System;

using Business.Logic;

using ConsoleApp.Interfaces;

namespace ConsoleApp.Process
{
    public class ReadOperationCalculation : ICalculate
    {
        public bool Execute()
        {
            Console.WriteLine("Please type the first number to add.");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please type the second number for the result.");
            var secondNumber = int.Parse(Console.ReadLine());

            var result = new SumInt().Operate(firstNumber, secondNumber);
            Console.WriteLine(string.Format("Result of addition operation for numbers '{0}' and {1} is {2}.", firstNumber, secondNumber, result));

            return true;
        }
    }
}
