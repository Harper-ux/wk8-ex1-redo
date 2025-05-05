using System;
using System.IO;

namespace wk8_ex1_redo
{
    internal class Program
    {
        static int CountWords(string filename) // Count the number of words in a file
        {
            // Check if the file exists
            if (string.IsNullOrEmpty(filename))
            {
                Console.WriteLine("Filename cannot be null or empty."); // Check if the filename is null or empty
                return 0; // Return 0 if the filename is invalid
            }
            // Read the file and count the words
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found."); // Check if the file exists
                return 0; // Return 0 if the file does not exist
            }
            string content = File.ReadAllText(filename); // Read the content of the file
            string[] words = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries); // Split the content into words using space, newline, and carriage return as delimiters
            return words.Length; // Return the number of words
        }


        static void Main(string[] args)
        {
            string filename = "sample.txt"; // Specify the filename

            if (!File.Exists(filename)) // Check if the file exists
            {
                File.WriteAllText(filename, "this is a sample text file. it contains some for counting."); // Create a sample file if it does not exist
            }

            int wordCount = CountWords(filename); // Call the CountWords method to count the words in the file

            // Display the word count  
            Console.WriteLine($"Total of words in '{filename}': {wordCount}"); // Print the total number of words
        }
    }
}
