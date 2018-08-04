using System;


namespace SequenciaDeNumerosESoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, resultado;
            string[] vet;
            N = 1;
            M = 1;
            resultado = 0;

            while (M > 0 || N > 0)
            {
                vet = Console.ReadLine().Split(' ');
                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);
                resultado = 0;

                if (M > 0 && N > 0 && M < N)
                {
                    for (int i = M; i <= N; i++)
                    {
                        Console.Write(i + " ");
                        resultado = resultado + i;
                    }
                    Console.WriteLine("Sum=" + resultado);
                }
                else if (M > 0 && N > 0 && M > N)
                {
                    for (int i = N; i <= M; i++)
                    {
                        Console.Write(i + " ");
                        resultado = resultado + i;
                    }
                    Console.WriteLine("Sum=" + resultado);
                }
                else { M = 0; }
            }
        }
    }
}
