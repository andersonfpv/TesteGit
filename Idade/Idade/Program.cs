using System;
using System.Globalization;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, soma = 0, i = 0;
            double media;

            numero = int.Parse(Console.ReadLine());

            do
            {
                i = i + 1;
                soma += numero;
                numero = int.Parse(Console.ReadLine());

            } while(numero > 0);
            media = (double)soma / i;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
