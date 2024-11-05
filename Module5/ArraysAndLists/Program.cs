/* Author: Dank Mitchell
   Date: 2 Nov 2024
   Assignment: PA5 Arrays and Lists
*/

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TASK 1 - Simply Array
            // Declare simple array of 5
            int[] simpleArray = new int[5];

            // Print heading for array
            Console.WriteLine($"Printing int Array");

            // Use for loop to initalize to numbers 11-15 
            for (int i = 0; i<simpleArray.Length; i++)
            {
                simpleArray[i] = i+11;
            }

            // Use a foreach loop to print out values (with tab)
            foreach(int i in simpleArray)
            {
                Console.WriteLine($"\t{i}");
            }
            #endregion

            #region TASK 1 - List<T> 
            // Create a list of int
            List<int> myListArray = new List<int>();

            // Print heading for array
            Console.WriteLine($"\nPrinting int List");

            // Use for loop to initalize to numbers 21-25
            for (int i = 21; i <= 25; i++)
            {
                myListArray.Add(i);
            }

            // Use foreach loop to print out values 
            foreach(int i in myListArray)
            {
                Console.WriteLine($"\t{i}");
            }

            // Update values in list to 31-35
            for (int i = 0; i < myListArray.Count;i++)
            {
                myListArray[i] += 10;
            }

            // Print heading for array
            Console.WriteLine($"\nPrinting Updated List");

            // Use for loop and index i in myListArray to print
            for (int i = 0; i < myListArray.Count; i++)
            {
                Console.WriteLine($"\t{myListArray[i]}");
            }

            #endregion

        }
    }
}
