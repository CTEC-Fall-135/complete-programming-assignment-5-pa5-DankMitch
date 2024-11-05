/* Author: Dank Mitchell
   Date: 2 Nov 2024
   Assignment: PA5 Stacks and Queues
*/

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TASK 2 - Stack
            // Declare and initialize stack with 1-5
            // Create array
            int[] simpleArray = new int[] { 1, 2, 3, 4, 5 };

            // Pass into stack
            Stack<int> stackOfNumbers = new Stack<int>(simpleArray);

            // Use enumerator to print each with foreach loop
            Console.WriteLine($"Printing the Stack");

            foreach (int i in stackOfNumbers)
            {
                Console.WriteLine($"\t{i}");
            }

            // Print peek of top member in stack
            Console.Write($"\nTop of Stack: {stackOfNumbers.Peek()} \n");

            // Write a loop that pops elements off the stack and prints each
            Console.WriteLine($"\nPrinting the Stack");

            for (int i = stackOfNumbers.Count; i > 0; i--)
            {
                Console.WriteLine($"\t{stackOfNumbers.Pop()}"); 
            }

            #endregion

            #region TASK 2 - Queue
            // Declare a queue
            Queue<int> myFirstQueue = new Queue<int>();

            // Use loop to initialize queue with 1-5
            for (int i = 1; i <= 5; i++)
            {
                myFirstQueue.Enqueue(i);
            }

            // Use foreach loop to print out members/numbers in queue
            Console.WriteLine($"\nPrint the Queue");

            foreach (int i in myFirstQueue)
            {
                Console.WriteLine($"\t{i}");
            }
            
            // Print top of stack using peek
            Console.WriteLine($"\nTop of Queue: {myFirstQueue.Peek()}\n");

            // Write loop that dequeues from stack and prints each
            Console.WriteLine($"Dequeue and Print Values");

            for (int i = myFirstQueue.Count; i > 0; i--)
            {
                Console.WriteLine($"\t{myFirstQueue.Dequeue()}");
            }
            #endregion

        }
    }
}
