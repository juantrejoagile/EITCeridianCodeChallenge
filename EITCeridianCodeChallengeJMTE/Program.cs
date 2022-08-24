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

            Console.WriteLine("Please provide the ordering expected and the names to be ordered...");
            Console.WriteLine();

            Console.WriteLine("First of all you must provide the ordering indicating how many words have to have each name, if it doesn't match");
            Console.WriteLine("you will get an error... The number of words can be dynamic from 1 to N");
            Console.WriteLine();

            Console.WriteLine("Provide the expected ordering like this, for example to enter 5 words name you should input 3,2,5,1,4 and press ENTER");
            Console.WriteLine();

            Console.Write("Ordering expected:  ");
            string ordering = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Provide each name to be ordered considering that the name have to be the same number of words provided in the");
            Console.WriteLine("ordering parameter...");
            Console.WriteLine();
            Console.WriteLine("For example for the ordering posted above we can enter 'Carlos Fernando Jose Gonzalez Belmont' ...");
            Console.WriteLine("Input names one by one pressing ENTER for every one, when you done, please type 'end' and ENTER...");
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
