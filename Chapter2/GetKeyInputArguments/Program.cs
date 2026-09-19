using System;

namespace GetKeyInputArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* get key inputs */
            //Console.Write("Press any key combination: ");
            //ConsoleKeyInfo key = Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine(string.Format("Key: {0}, Char: {1}, Modifiers {2}", key.Key, key.KeyChar, key.Modifiers));
            //Console.WriteLine();
            //Console.WriteLine($"These are the {args.Length} arguments.");

            /* get arguments */
            //foreach (string arg in args)
            //{
            //    Console.WriteLine(arg);
            //}       
            if (args.Length < 4)
            {
                Console.WriteLine("You must specify two colours and dimensions, e.g.");
                Console.WriteLine("dotnet run red yellow 80 40");
                return;
            }

            var ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
            var BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);

            try
            {
                var WindowWidth = int.Parse(args[2]);
                var WindowHeight = int.Parse(args[3]);
            }
            catch (PlatformNotSupportedException)
            {
                Console.WriteLine("The current platform does not support setting the window size.");
            }
        }
    }
}
