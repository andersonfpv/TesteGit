using System;

namespace QuadradoEAoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                Console.Write(i * i + " ");
                Console.WriteLine(i * i * i);
            }
            Console.ReadLine();
        }
    }
}
