using System;
using System.IO;
using System.Xml;

namespace InferringValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Inferring Values */
            var population = 66_000_000; // 66 Million in the UK
            var weight = 1.88; // In Kg
            var price = 4.99M; // In Pounds sterlinf
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true; // Booleans have value of true or false

            // good use of var because it avoid the repeated type
            // as shown in the more verbose second statement
            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();

            // bad use of var because we cannot tell the type, so we
            // should use a specific type declaration as shown in
            // the second statement
            /*var file1 = File.CreateText(@"C:\something.txt");
            StreamWriter file2 = File.CreateText(@"C:\something.txt");*/

            /* Getting default value types */
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

            /* Arrays */
            string[] names; // can reference any array of strings 

            // allocating memory for four strings in an array
            names = new string[4];

            // storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            // looping through items
            for (int i = 0; i < names.Length; i++) 
            {
                // output the item at index position i
                Console.WriteLine(names[i]);
            }
        }
    }
}
