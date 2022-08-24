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
        /// <param name="ordering">Ordering defined to apply</param>
        /// <returns>New names array</returns>
        public string[] ReorderNames(string[] names, string[] ordering)
        {
            // Result object
            List<string> result = new List<string>();

            try
            {
                // Validation for names and ordering
                ValidateEntries(names, ordering);

                // Objects for decomposicion
                string[] words;
                StringBuilder newName;

                // Iteration
                foreach (string name in names)
                {
                    // Decomposing in words
                    words = name.Split(' ');
                    newName = new StringBuilder();

                    // Ordering by the array ordering into new Name
                    for (int item = 0; item < ordering.Length; item++)
                    { newName.AppendFormat("{0} ", words[Convert.ToInt32(ordering[item]) - 1]); }

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
        /// <param name="ordering">Ordering expected to validate names</param>
        /// <exception cref="Exception">The exception throwed if names and ordering does not match, or invalid ordering found</exception>
        private void ValidateEntries(string[] names, string[] ordering)
        {
            // Object to get integer value
            int orderValue;
            foreach (string value in ordering)
            {
                // Validate non integer value
                if (!int.TryParse(value, out orderValue))
                { throw new Exception($"ERROR: The ordering value {value} is not valid."); }

                // Validate non minus or major value than the consecutive expected in ordering
                if (orderValue < 1 ||
                    orderValue > ordering.Length)
                { throw new Exception($"ERROR: The ordering value {orderValue} is not valid."); }
            }

            // Object to get splited words of the name
            string[] words;
            foreach (string name in names)
            {
                words = name.Split(' ');

                // Validate quantity of words match ordering expected
                if (!words.Length.Equals(ordering.Length))
                { throw new Exception($"ERROR: The quantity of words [ {name} - {words.Length} ] doesn't match the ordering arguments."); }
            }
        }

    }
}
