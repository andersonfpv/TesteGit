﻿using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x != 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.Write("EVEN ");
                    }
                    else
                    {
                        Console.Write("ODD ");
                    }

                    if (x > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
            Console.ReadLine();
        }
    }
}
