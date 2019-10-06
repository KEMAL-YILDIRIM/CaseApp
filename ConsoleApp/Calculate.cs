using System;

using ConsoleApp.Interfaces;

namespace ConsoleApp
{
    public class Calculate : ICalculate
    {
        public bool Execute()
        {
            Menu();

            var selection = Console.ReadKey().Key;
            switch (selection)
            {
                case ConsoleKey.NumPad1:
                    break;
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.NumPad3:
                    break;
                default:
                    break;
            }
            return true;
        }

        private static void Menu()
        {
            Console.WriteLine(@"
1-) Find the repetation of a letter in a text.
2-) Find the repetation of a number in an array of numbers.
3-) Find the result of an addition for two numbers.
Please press the number of the process.");
        }
    }
}
