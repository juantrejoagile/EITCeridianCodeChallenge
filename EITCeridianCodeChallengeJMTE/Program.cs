using System;
using System.Collections.Generic;
using System.Linq;

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
            string[] names = new string[]
            {
                "Sonia Maria Wood Dempster",
                "Laruen Ana Eagles Beneke",
                "Juan Manuel Trejo Espinoza",
                "Thomas Runnes Andersen Kvarforth",
                "Thomas Runnes Andersen",
                "Thomas Runnes",
                "Thomas",
                ""
            };

            // Order parameters
            int[] order = new int[] { 2, 4, 1, 3 };

            // Calling method ready for production
            string[] result = ReorderNames(names, order);

            // Displaying parameter names
            foreach (string name in names)
            { Console.WriteLine(name); }

            // Displaying parameter order
            foreach (int value in order)
            { Console.Write($"{value} "); }
            Console.WriteLine();

            // Displaying result reordered
            foreach (string name in result)
            { Console.WriteLine(name); }

            Console.ReadKey();
        }

        /// <summary>
        /// Reorder the words inside each name
        /// </summary>
        /// <param name="names">Names array to be reordered</param>
        /// <param name="order">Order defined to apply</param>
        /// <returns>New names array</returns>
        public static string[] ReorderNames(string[] names, int[] order)
        {
            // Result object
            List<string> result = new List<string>();

            try
            {
                // Validation for number of order parameters
                if (!order.Length.Equals(4))
                { throw new Exception("The number of order values is not valid."); }

                // Object to compare order parameters
                int[] validOrderValues = new int[] { 1, 2, 3, 4 };

                // Validate order parameters values
                if (order.Any(o => !validOrderValues.Contains(o)))
                { throw new Exception("A order value is not valid."); }

                // Decompose words of name
                string[] words;
                string first;
                string second;
                string third;
                string fourth;

                // Iteration
                foreach (string name in names)
                {
                    first = string.Empty;
                    second = string.Empty;
                    third = string.Empty;
                    fourth = string.Empty;

                    // Split
                    words = name.Split(' ');
                    // If names are uncomplete can not be processed
                    if (words.Length.Equals(4))
                    {
                        // Construct new name using new order
                        first = words[order[0] - 1];
                        second = words[order[1] - 1];
                        third = words[order[2] - 1];
                        fourth = words[order[3] - 1];
                    }
                    else
                    {
                        // Error message for uncompleted name
                        first = "Uncompleted words for this name.";
                    }

                    // Filling result
                    result.Add($"{first} {second} {third} {fourth}");
                }
            }
            catch (Exception ex)
            {
                // Sending error to output
                result.Add(ex.Message);
            }

            // Sending result
            return result.ToArray();
        }

    }
}
