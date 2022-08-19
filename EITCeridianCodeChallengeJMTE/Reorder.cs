using System;
using System.Collections.Generic;
using System.Linq;

namespace EITCeridianCodeChallengeJMTE
{
    public class Reorder
    {

        /// <summary>
        /// Reorder the words inside each name
        /// </summary>
        /// <param name="names">Names array to be reordered</param>
        /// <param name="order">Order defined to apply</param>
        /// <returns>New names array</returns>
        public string[] ReorderNames(string[] names, string[] order)
        {
            // Result object
            List<string> result = new List<string>();

            try
            {
                // Validation for number of order parameters
                if (!order.Length.Equals(4))
                { throw new Exception("The number of order values is not valid."); }

                // Object to compare order parameters
                string[] validOrderValues = new string[] { "1", "2", "3", "4" };

                // Validate order parameters values
                if (order.Any(o => !validOrderValues.Any(v => v.Trim().Equals(o.Trim()))))
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
                        first = words[Convert.ToInt32(order[0]) - 1];
                        second = words[Convert.ToInt32(order[1]) - 1];
                        third = words[Convert.ToInt32(order[2]) - 1];
                        fourth = words[Convert.ToInt32(order[3]) - 1];
                    }
                    else
                    {
                        // Error message for uncompleted name
                        throw new Exception("Uncompleted words for this name.");
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
