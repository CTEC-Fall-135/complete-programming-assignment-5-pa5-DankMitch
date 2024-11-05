/* Author: Dank Mitchell
   Date: 2 Nov 2024
   Assignment: PA5 Dictionary
*/

namespace DictionaryUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use initialization syntax to create a dictionary with three entries
            // Declare string myFirstDictionary
            Dictionary<int, string> myFirstDictionary = new Dictionary<int, string>
            {
                { 1, "one" },
                { 2 , "two" },
                { 3 , "three" }
            };

            // Use add method to add 99, "ninety-nine"
            myFirstDictionary.Add(99, "ninety-nine");

            // Use enumerator to print out both key and value for each item in dictionary
            Console.WriteLine($"Printing the dictionary using KeyValuePair type");

            foreach (KeyValuePair<int, string> kvp in myFirstDictionary)
            {
                Console.WriteLine($"\tKey: {kvp.Key}\tValue: {kvp.Value}");
            }

            // Reassign the value of 99 to "99" using indexing
            Console.WriteLine("\nPrinting value of 99");

            myFirstDictionary[99] = "99";
            Console.WriteLine($"\t{myFirstDictionary[99]}");

            // Remove item 2 and print updated dictionary
            myFirstDictionary.Remove(2);

            Console.WriteLine($"\nPrinting the updated dictionary");

            // Print using implicit type var
            foreach (var kvp in myFirstDictionary)
            {
                Console.WriteLine($"\tKey: {kvp.Key}\tValue: {kvp.Value}");
            }
            


        }
    }
}
