using System;

namespace SomaDeImparesConsecutivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, soma;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                String[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                soma = 0;
                if (x < y)
                {
                    
                    for (int c = x + 1; c < y; c++)
                    {
                        
                        if (c % 2 != 0)
                        {
                            soma += c;    
                        }
                    }
                    Console.WriteLine(soma);
                }
                else
                {
                    for (int c = y + 1; c < x; c++)
                    {
                        
                        if (c % 2 != 0)
                        {
                            soma += c;                          
                        }                      
                    }
                    Console.WriteLine(soma);
                }
            }
            
            Console.ReadLine();
        }
    }
}
