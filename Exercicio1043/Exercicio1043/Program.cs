using System;
using System.Globalization;


namespace Exercicio1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, perimetro, area;
           
            String[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            perimetro = a + b + c;
            area = ((a + b) / 2) * c;

            if ((Math.Abs(b - c) < a && (a <b + c)) && ((Math.Abs(a - c) < b) && (b < a + c)) && ((Math.Abs(a - b) < c) && (c < a + b)))
            {
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1"), CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine("Area = " + area.ToString("F1"), CultureInfo.InvariantCulture);
            }
            Console.ReadLine();

        }
    }
}
