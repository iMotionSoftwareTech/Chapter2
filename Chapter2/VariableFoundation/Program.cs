using System;

namespace VariableFoundation
{
    /// <summary>
    /// The Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // let the heightInMetres variable become equal to the value of 1.98
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof (heightInMetres)} has the value {heightInMetres}.");

            /* Char data type 
             * with values */
            char letter = 'A';
            char digit = '1';
            char symbol = '$';
            //char userChoice = GetKeyStroke();

            /* String data types 
             * with values */
            string firstName = "Bob";
            string lastName = "Smith";
            string phoneNumber = "(215) 555-4526";

            // assigning a string returned from the function call
            //string address = GetAddressFromDatabase(id: 563);

            // Verbatim Strings
            string fullNameWithTabSeperator = "Bob\tSmith";
            string filePath = @"C:\televisions\sony\bravia.txt";
        }
    }
}