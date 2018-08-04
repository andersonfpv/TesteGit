using System;
using System.Globalization;

namespace MediasPonderadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double media = 0.0, valor1 = 0.0, valor2 = 0.0, valor3 = 0.0;
                String[] vet = Console.ReadLine().Split(' ');
                valor1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                valor2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                valor3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
            Console.ReadLine();
        }
    }
}
