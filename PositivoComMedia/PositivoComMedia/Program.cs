using System;
using System.Globalization;

namespace PositivoComMedia
{
    class Program
    {
        static void Main(string[] args)
        {

            double n , media, soma = 0.0;
            int c = 0;
            
            for (int i = 0; i < 6; i++)
            {
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n > 0.0)
                {
                    c++;
                    soma += n;
                }
                
            }

            media = soma / c;
            Console.WriteLine(c + " valores positivos");
            Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
