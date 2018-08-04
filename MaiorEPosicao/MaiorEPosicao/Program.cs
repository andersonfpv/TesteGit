using System;

namespace MaiorEPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, maior = 0, posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            Console.ReadLine();
        }
    }
}