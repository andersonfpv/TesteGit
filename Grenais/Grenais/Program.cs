using System;

namespace Grenais
{
    class Program
    {
        static void Main(string[] args)
        {
            int grenais = 0, golsInter = 0, golsgremio = 0, inter = 0, gremio = 0, empate = 0, opcao = 0;

            String[] vet = Console.ReadLine().Split(' ');
            golsInter = int.Parse(vet[0]);
            golsgremio = int.Parse(vet[1]);

            do
            {
                if (golsInter > golsgremio)
                {
                    inter = inter + 1;
                }

                if (golsgremio > golsInter)
                {
                    gremio = gremio + 1;
                }

                if (golsInter == golsgremio)
                {
                    empate = empate + 1;
                }
                grenais++;

                if (opcao == 1)
                {
                    vet = Console.ReadLine().Split(' ');
                    golsInter = int.Parse(vet[0]);
                    golsgremio = int.Parse(vet[1]);

                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());

            } while (opcao != 2);


            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empate);

            if (inter > gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (inter < gremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

            Console.ReadLine();
        }
    }
}
