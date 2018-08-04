using System;

namespace ExercicioMatriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0;
            int[,] A;

            n = int.Parse(Console.ReadLine());
            A = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                String[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[n];
            Console.Write("SOMA DOS POSITIVOS: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] > 0)
                    {
                        soma = soma + A[i,j];
                    }
                }
            }
            Console.Write(soma);
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i, i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
