using System;

namespace FatorialSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, multiplica = 1;

            n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                multiplica *= i;
                
            }
            Console.WriteLine(multiplica);
            Console.ReadLine();
        }
    }
}
