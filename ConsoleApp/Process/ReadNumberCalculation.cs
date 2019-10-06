using System;
using System.Linq;

using Business.Logic;

using ConsoleApp.Interfaces;

namespace ConsoleApp.Process
{
    public class ReadNumberCalculation : ICalculate
    {
        public bool Execute()
        {
            Console.WriteLine("Please type the numbers and press Enter.");
            var givenText = Console
                .ReadLine()
                .Trim();
            var numbers = givenText
                .Select(n => int.Parse(n.ToString()))
                .ToList();


            Console.WriteLine("Please type the specific number to find out the number of repetations.");
            var letter = Console
                .ReadKey()
                .KeyChar
                .ToString();
            var number = int.Parse(letter);

            var result = new Number().FindNumberOfRepetations(numbers, number);
            Console.WriteLine(string.Format("Number '{0}' is repeated {1} times in the given numbers.", letter, result));

            return true;
        }
    }
}
