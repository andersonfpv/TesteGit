using System;
using System.Globalization;

namespace Experiencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, quantia = 0, sapo = 0, rato = 0, coelho = 0, soma = 0;
            double percentR = 0.0, percentS = 0.0, percentC = 0.0;
            char tipo;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                String[] vet = Console.ReadLine().Split(' ');
                quantia = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);

                if (tipo == 'R')
                {
                    rato += quantia;
                }
                else if (tipo == 'S')
                {
                    sapo += quantia;
                }
                else if (tipo == 'C')
                {
                    coelho += quantia;
                }
                soma = rato + sapo + coelho;
                percentS = ((double)sapo / soma) * 100.0;
                percentR = ((double)rato / soma) * 100.0;
                percentC = ((double)coelho / soma) * 100.0;

            }
            
            Console.WriteLine("Total: " + soma + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + percentC.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentR.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentS.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.ReadLine();
        }
    }
}
