using System;
using System.Collections.Generic;

namespace EITCeridianCodeChallengeJMTE
{
    internal class Program
    {

        /// <summary>
        /// Main method for testing
        /// </summary>
        /// <param name="args">any parameter valid</param>
        static void Main(string[] args)
        {
            // Getting parameters from prompt
            object[] parameters = GetParameters();

            // Names parameter
            string[] names = (parameters[0] as List<string>).ToArray();

            // Ordering parameters
            string[] ordering = parameters[1].ToString().Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, ordering);

            // Displaying parameter ordering
            foreach (string value in ordering)
            { Console.Write($"{value} "); }
            Console.WriteLine();
            Console.WriteLine();

            // Displaying result reordered
            foreach (string name in result)
            { Console.WriteLine(name); }

            Console.ReadKey();
        }

        /// <summary>
        /// Get the parameters from prompt console
        /// </summary>
        /// <returns>An array of names and ordering</returns>
        private static object[] GetParameters()
        {
            List<string> names = new List<string>();

            Console.WriteLine("Please provide the ordering and names to be sorted...");
            Console.WriteLine();

            Console.WriteLine("First of all provide the ordering, for example 3,2,5,1,4");
            Console.WriteLine();

            string ordering = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Now provide the names to be ordered... For example 'Carlos Fernando Jose Gonzalez Belmont' ...");
            Console.WriteLine("Type as many set of names as needed by pressing ENTER for every set, when you are done, type 'end' and press ENTER...");
            Console.WriteLine();

            string name = string.Empty;
            while (!name.Equals("end"))
            {
                name = Console.ReadLine();

                if (!name.Equals("end"))
                { names.Add(name); }
            }
            Console.WriteLine();

            object[] result = new object[] { names, ordering };
            return result;
        }

    }
}
