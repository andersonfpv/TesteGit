using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;

            r = new Retangulo();

            Console.WriteLine("Digite os valores do retângulo: ");
            Console.Write("Digite a largura do retângulo: ");
            r.largura = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.Write("Digite a altura do retângulo: ");
            r.altura = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.WriteLine("AREA = " + r.area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + r.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r.diagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
