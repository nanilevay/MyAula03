using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare the variables
            string sentence;
            char character;

            // ask the user for a string and then a character
            Console.WriteLine("Welcome! Please input a sentence.");
            sentence = Console.ReadLine();
            Console.WriteLine("Welcome! Please input a character.");
            character = Convert.ToChar(Console.ReadLine());

            // write out the string
            foreach (char c in sentence)
            {
                // check if one of the chars in the string is the the 
                // same as the character 
                if (c != character)
                {
                    Console.Write(c);
                    
                }
                else
                {
                    continue;
                }
                
            }
            Console.WriteLine();
        }

    }
}
