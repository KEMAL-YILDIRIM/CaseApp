using System;

using ConsoleApp.Interfaces;


namespace ConsoleApp.Process
{
    public class Calculate : ICalculate
    {
        public bool Execute()
        {
            ConsoleMenu.Load();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            var selection = Console.ReadKey().Key;
            Console.WriteLine();

            if (selection == ConsoleKey.D1 || selection == ConsoleKey.NumPad1)
                new ReadTextCalculation().Execute();
            else if (selection == ConsoleKey.D2 || selection == ConsoleKey.NumPad2)
                new ReadNumberCalculation().Execute();
            else if (selection == ConsoleKey.D3 || selection == ConsoleKey.NumPad3)
                new ReadOperationCalculation().Execute();
            else
                Execute();

            return true;
        }
    }
}
