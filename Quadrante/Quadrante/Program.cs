﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            String[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while(x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
    }
}
