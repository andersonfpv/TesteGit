using System;

namespace SomaDeInteirosConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, s;

            String[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            n = int.Parse(vet[1]);

           
                for (int i = 1; i < n; i++)
                {
                    s = s + 1 + a;
                }
          
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
    
}
