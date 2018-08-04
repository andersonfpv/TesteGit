using System;
using System.Globalization;

namespace VariasNotasComValidacao
{
    class Program
    {
        static void Main(string[] args)
        {

            double nota , soma;
            int x, opcao;
            do
            {
                nota = 0.0;
                soma = 0.0;
                x = 0;
                opcao = 0;

                while (x < 2)
                {
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (nota >= 0 && nota <= 10)
                    {
                        x++;
                        soma += nota;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }


                }
                Console.WriteLine("media = " + (soma * 0.5).ToString("F2", CultureInfo.InvariantCulture));

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                } while (opcao != 1 && opcao != 2);
            } while (opcao != 2);
            Console.ReadLine();
        }
    }
}
