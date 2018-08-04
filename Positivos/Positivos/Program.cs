using System;

namespace Positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            int c = 0;

            for (int i=0; i<6; i++)
            {
                n = double.Parse(Console.ReadLine());
                if (n > 0.0)
                {
                    c++;
                }
            }
            Console.WriteLine(c + " valores positivos");
            Console.ReadLine();
        }
    }
}
