using Chapter2.Shared;
using System;
using System.Net.Sockets;
using System.Net.WebSockets;
namespace NullableValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; - compile error

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());


            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address
            {
                Building = null,
                Street = null,
                City = "London",
                Region = null
            };

            // check that the varirable is not null before using it
            if (thisCouldBeNull != null ) {
                int length = thisCouldBeNull.ToString().Length;
            }

            string authorName = null;

            // the following throws a NullReferenceException
            //int x = authorName.Length;

            // instead of throwing an exception, null is assigned to y
            int? y = authorName?.Length;

            // result will be 3 if authorName?.Length is null
            var result = authorName?.Length ?? 3;
            Console.WriteLine(result);
        }
    }
}
