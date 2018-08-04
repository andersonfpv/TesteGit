using System;

namespace FibonacciFacil
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, A, B, C;
            N = int.Parse(Console.ReadLine());
            A = 0; B = 1;
            if (N == 1)
            {
                Console.Write(A);
            }
            else if (N == 2)
            {
                Console.Write(A + " " + B);
            }
            else if (N > 2 && N < 46)
            {
                Console.Write(A + " " + B);
                for (i = 3; i <= N; i++)
                {
                    C = A + B;
                    Console.Write(" " + C);
                    A = B;
                    B = C;
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
