using System;

namespace SomaDeParesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma;

            x = int.Parse(Console.ReadLine());


            while (x != 0)
            {
                soma = 0;

                if (x % 2 == 0)
                {

                    for (int i = x; i < x + 10; i += 2)
                    {
                        soma = soma + i;
                    }

                    Console.WriteLine(soma);
                }
                else
                {
                    x = x + 1;
                    for (int i = x; i < x + 10; i += 2)
                    {
                        soma = soma + i;
                    }
                    Console.WriteLine(soma);
                }

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}