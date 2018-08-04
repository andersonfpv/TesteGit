using System;

namespace Ij2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 9; i = i + 2)
            {
                for (j = 7; j >= 5; j--)
                {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
            }
            Console.ReadLine();
        }
    }
}
