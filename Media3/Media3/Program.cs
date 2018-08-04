using System;
using System.Globalization;

namespace Media3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media, valorExame, mediaExame;

            String[] vet = Console.ReadLine().Split(' ');

            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10;

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Media: " + media.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno em exame.");

                String[] vet2 = Console.ReadLine().Split(' ');
                valorExame = double.Parse(vet2[0], CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + valorExame);
                mediaExame = (media + valorExame) / 2;
                

                if (mediaExame > 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1"), CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1"), CultureInfo.InvariantCulture);
                }
                
            }
            Console.ReadLine();
        }
    }
}
