using System;
using System.Globalization;

namespace DividindoXPorY
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;
            double divisao = 0.0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                String[] vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {   
                    divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                
            }
            Console.ReadLine();
        }
    }
}
