using System;

using Autofac.Features.Indexed;

using ConsoleApp.Interfaces;

using static ConsoleApp.Configuration.AutofacSetup;

namespace ConsoleApp.Process
{
    public class Calculate : ICalculate
    {
        public IIndex<Key, IRead> _readIndexedInstances;
        public Calculate(IIndex<Key, IRead> readIndexedInstances)
        {
            _readIndexedInstances = readIndexedInstances;
        }

        public bool Execute()
        {
            ConsoleMenu.Load();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            var selection = Console.ReadKey().Key;
            Console.WriteLine();

            if (selection == ConsoleKey.D1 || selection == ConsoleKey.NumPad1)
                _readIndexedInstances[Key.ReadTextForRepetation].Execute();
            else if (selection == ConsoleKey.D2 || selection == ConsoleKey.NumPad2)
                _readIndexedInstances[Key.ReadNumbersForRepetation].Execute();
            else if (selection == ConsoleKey.D3 || selection == ConsoleKey.NumPad3)
                _readIndexedInstances[Key.ReadNumbersForCalculation].Execute();
            else
                Execute();

            return true;
        }
    }
}
