using System;

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
            // Names parameter
            string[] names = args[0].Split(',');

            // Order parameters
            string[] order = args[1].Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            // Displaying parameter names
            foreach (string name in names)
            { Console.WriteLine(name); }

            // Displaying parameter order
            foreach (string value in order)
            { Console.Write($"{value} "); }
            Console.WriteLine();

            // Displaying result reordered
            foreach (string name in result)
            { Console.WriteLine(name); }

            Console.ReadKey();
        }

    }
}
