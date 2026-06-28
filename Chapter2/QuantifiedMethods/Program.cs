using System;
using System.Linq;
using System.Reflection;

namespace QuantifiedMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loop through the assemblies that this app references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                // Load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));

                // Declare a variable to count the number of methods
                int methodCount = 0;

                // Loop through all of the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    // Add up the counts of methods
                    methodCount += t.GetMethods().Length;
                }

                // Output the count of types and their methods
                Console.WriteLine("{0:0} types with {1: 0} methods in {2} assembly.", a.DefinedTypes.Count(), methodCount, r.Name);
                Console.ReadKey();
            }
        }
    }
}
