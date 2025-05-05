using System;
using System.IO;

namespace wk8_ex1_redo
{
    internal class Program
    {
        static int CountWords(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return 0;
            }

            string content = File.ReadAllText(filename);
            string[] words = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        static void Main(string[] args)
        {
            string filename = "sample.txt";

            if (!File.Exists(filename))
            {
                File.WriteAllText(filename, "this is a sample text file. it contains some for counting.");
            }

            int wordCount = CountWords(filename);

            // Display the word count  
            Console.WriteLine($"Total of words in '{filename}': {wordCount}");
        }
    }
}
