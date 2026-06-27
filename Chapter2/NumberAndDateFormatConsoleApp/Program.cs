using System;

namespace NumberAndDateFormatConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ahmed");

            Console.WriteLine("Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);
            Console.ReadKey();
        }
    }
}