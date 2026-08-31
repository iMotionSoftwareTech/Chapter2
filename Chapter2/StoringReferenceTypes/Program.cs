using System;

namespace StoringReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Object */
            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object

            Console.WriteLine($"{name} is {height} meters tall.");

            // int length1 = name.Length; - Gives compiler error
            int length2 = ((string)name).Length;
            Console.WriteLine($"{name} has {length2} characters.");

            /* Dynamic type */
            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";

            // this compiles but would throw an exception at a run-time
            // if you later store a data type that does not have a 
            // property names Length
            int length = anotherName.Length;
            Console.WriteLine($"{anotherName} has {length} characters.");
        }
    }
}
