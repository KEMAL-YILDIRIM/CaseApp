using System;

using Business.Logic;

using ConsoleApp.Interfaces;

namespace ConsoleApp.Process
{
    public class ReadTextCalculation : ICalculate
    {
        public bool Execute()
        {
            Console.WriteLine("Please type the desired text and press Enter.");
            var givenText = Console.ReadLine().Trim();

            Console.WriteLine("Please type the letter to find out the number of repetations.");
            var letter = Console.ReadKey().KeyChar;

            var result = new Letter().FindNumberOfRepetations(givenText.ToCharArray(), letter);
            Console.WriteLine(string.Format("Letter '{0}' is repeated {1} times in the given text.", letter, result));
            return true;
        }
    }
}
