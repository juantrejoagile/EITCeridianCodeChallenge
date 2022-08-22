using System;
using System.Collections.Generic;
using System.Text;

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
                // Validation for names and order
                ValidateEntries(names, order);

                // Objects for decomposicion
                string[] words;
                StringBuilder newName;

                // Iteration
                foreach (string name in names)
                {
                    // Decomposing in words
                    words = name.Split(' ');
                    newName = new StringBuilder();

                    // Ordering by the array order into new Name
                    for (int item = 0; item < order.Length; item++)
                    { newName.AppendFormat("{0} ", words[Convert.ToInt32(order[item]) - 1]); }

                    // Filling result
                    result.Add(newName.ToString().Trim());
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

        /// <summary>
        /// Validate Entries to Ordering
        /// </summary>
        /// <param name="names">Names to be validated</param>
        /// <param name="order">Order expected to validate names</param>
        /// <exception cref="Exception">The exception throwed if names and order does not match, or invalid order found</exception>
        private void ValidateEntries(string[] names, string[] order)
        {
            // Object to get integer value
            int orderValue;
            foreach (string value in order)
            {
                // Validate non integer value
                if (!int.TryParse(value, out orderValue))
                { throw new Exception($"ERROR: The order value {value} is not valid."); }

                // Validate non minus or major value than the consecutive expected in order
                if (orderValue < 1 ||
                    orderValue > order.Length)
                { throw new Exception($"ERROR: The order value {orderValue} is not valid."); }
            }

            // Object to get splited words of the name
            string[] words;
            foreach (string name in names)
            {
                words = name.Split(' ');

                // Validate quantity of words match order expected
                if (!words.Length.Equals(order.Length))
                { throw new Exception($"ERROR: The quantity of words [ {name} - {words.Length} ] doesn't match the order arguments."); }
            }
        }

    }
}
