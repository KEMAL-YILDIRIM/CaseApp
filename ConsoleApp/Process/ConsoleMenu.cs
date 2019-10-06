using System;

namespace ConsoleApp.Process
{
    public static class ConsoleMenu
    {
        public static void Load()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine(@"
Please select the process by pressing the number.

1-) Find the repetation of a letter in a typed text.
2-) Find the repetation of a number in a typed array of numbers.
3-) Find the result of an addition for two numbers.

");
        }
    }
}
