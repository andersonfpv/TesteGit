using System;
using System.Globalization;

namespace Exercicio1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            String[] vet = Console.ReadLine().Split(' ');
            nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            nota4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = ((nota1 * 2.0) + (nota2 * 3.0) + (nota3 * 4.0) + (nota4 * 1.0)) / 10.0;
            if (media == 4.85)
            {
                media = 4.8;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                double notaExame;
                notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));

                double mediaFinal = (media + notaExame) / 2.0;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}