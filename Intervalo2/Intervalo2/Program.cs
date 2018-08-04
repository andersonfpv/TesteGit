using System;

namespace Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, dentro = 0, fora = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
            Console.ReadLine();
        }
    }
}
