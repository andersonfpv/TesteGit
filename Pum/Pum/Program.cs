using System;

namespace Pum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n*4; i += 4)
            {
                Console.Write(i + " ");
                Console.Write(i + 1 + " ");
                Console.Write(i + 2 + " ");
                Console.WriteLine("PUM");
            }
            Console.ReadLine();
        }
    }
}
