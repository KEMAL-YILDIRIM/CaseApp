using System;
using System.Linq;
using System.Text.RegularExpressions;

using Business.Exceptions;
using Business.Interfaces;

using ConsoleApp.Interfaces;

namespace ConsoleApp.Process
{
    public class ReadNumbersForRepetation : IRead
    {
        private ICount<int> _number;
        public ReadNumbersForRepetation(ICount<int> number)
        {
            _number = number;
        }
        public bool Execute()
        {
            Console.WriteLine("Please type the numbers and press Enter.");
            var givenText = Console
                .ReadLine()
                .Trim();

            var regexNumberOnly = new Regex(@"^[0-9]+$");
            if (!regexNumberOnly.IsMatch(givenText))
                throw new CountException("Given numbers are not valid.");

            var numbers = givenText
                .Select(n => int.Parse(n.ToString()))
                .ToList();


            Console.WriteLine("Please type the specific number to find out the number of repetations.");
            var letter = Console
                .ReadKey()
                .KeyChar
                .ToString();
            var number = int.Parse(letter);

            var result = _number.FindNumberOfRepetations(numbers, number);
            Console.WriteLine(string.Format("Number '{0}' is repeated {1} times in the given numbers.", letter, result));

            return true;
        }
    }
}
