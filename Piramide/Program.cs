using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracao de variaveis
            string lines;
            int n;
            int asterisks;
            int spaces;
            // solicitacao de numero de linhas
            Console.WriteLine("Let's make a pyramid! How many lines");
            lines = Console.ReadLine();
            n = Convert.ToInt32(lines);
            // impressao da piramide
            for (int i = 0; i < n; ++i)
            {
                asterisks = i * 2 + 1;
                spaces = n - i - 1;

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write("-");
                }

                for (int j = 0; j < asterisks; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write("-");
                }

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write("-");
                }

                for (int j = 0; j < asterisks; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write("-");
                }

                Console.WriteLine();
            }
        }
    }
}
