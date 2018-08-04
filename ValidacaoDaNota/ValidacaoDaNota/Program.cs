using System;
using System.Globalization;

namespace ValidacaoDaNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, soma = 0.0;
            int c = 0;

            while(c<2)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(nota >= 0 && nota <= 10)
                {
                    c++;
                    soma += nota;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
                
                
            }
            Console.WriteLine("media = " + (soma * 0.5).ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
