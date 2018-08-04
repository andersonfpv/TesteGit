using System;

namespace RestoDaDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = y + 1; i < x; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
