/* Author: Dank Mitchell
   Date: 2 Nov 2024
   Assignment: PA5 LinkedList
*/

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Create Nursery Rhyme and print
            // Create string array of first line of Rock a bye baby
            string[] nurseryRhyme =
                {"rock", "a", "bye", "baby", "on", "the", "tree", "top"};

            // Use string as arg to a constructor creating a linked list
            LinkedList<string> rhyme = new LinkedList<string>(nurseryRhyme);

            // Print the rhyme on a single line
            Console.WriteLine($"Printing the list");
            Console.Write($"\t");

            foreach (string word in rhyme)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine($"\n");
            #endregion

            #region Use walk through to print
            // Create a node variable and walk the list to print out the values
            Console.WriteLine($"Printing the list by walking it");

            LinkedListNode<string> node = rhyme.First;
            Console.Write($"\t");
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.Write($"\n");
            #endregion

            #region Remove work from list
            // Remove "baby" from list
            rhyme.Remove("baby");

            // Print rhyme with baby removed on single line
            Console.WriteLine($"\nPrinting the updated list");
            Console.Write($"\t");

            LinkedListNode<string> nodeRemoved = rhyme.First;
            while (nodeRemoved != null)
            {
                Console.Write("{0} ", nodeRemoved.Value);
                nodeRemoved = nodeRemoved.Next;
            }
            Console.Write($"\n");
            #endregion

            #region Add word back to list
            // Add "baby" back in and print
            // Find bye and add baby after
            LinkedListNode<string> current = rhyme.Find("bye");
            rhyme.AddAfter(current, "baby");

            // Print nursery rhyme with baby added back in
            Console.WriteLine($"\nPrinting the updated list");
            Console.Write($"\t");

            LinkedListNode<string> nodeAdded = rhyme.First;
            while (nodeAdded != null)
            {
                Console.Write("{0} ", nodeAdded.Value);
                nodeAdded = nodeAdded.Next;
            }
            Console.Write($"\n");
            #endregion

        }
    }
}
