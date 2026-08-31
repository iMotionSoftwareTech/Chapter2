using System;

namespace StoringNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positive whole number
            // including 0
            uint naturalNumber = 23;

            // integer means negative or positive whole number
            // including 0
            int integerNumber = -23;

            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point
            double anotherRealNumber = 2.3; // double literal

            // three variables that store the nunmber 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            // check the three variables have the same value
            // both statements out true
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            // Checking the size of numbered data types
            Console.WriteLine($"byte uses {sizeof(byte)} bytes and can store numbers in the range {byte.MinValue:N0} to {byte.MaxValue:N0}.");
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
            Console.WriteLine($"long uses {sizeof(long)} bytes and can store numbers in the range {long.MinValue:N0} to {long.MaxValue:N0}.");
            Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers in the range {float.MinValue:N0} to {float.MaxValue:N0}.");

            // comparing double and decimal types
            Console.WriteLine("using doubles:");
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equal to 0.3");
            }

            Console.WriteLine("using decimals:");
            decimal c = 0.1M; // M suffix means a decimal literal value
            decimal d = 0.2M;

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does not equal to 0.3");
            }

            /* NOTE
             * Use int for whole numbers
             * Use double for real numbers
             * Use decimal for money, CAD drawings, general engineering
             * Never compare double values using the equality operator ==
             */

            Console.WriteLine($"{nameof(double.NaN)} means not a number.");
            Console.WriteLine($"{nameof(double.Epsilon)} is the smallest positive number that can be stored in a double.");
            Console.WriteLine($"{nameof(double.PositiveInfinity)} means an infinitely large number.");
        }
    }
}
