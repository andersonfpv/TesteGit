using System;


namespace TempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, tempoDeJogo;

            String[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if ((horaInicial > horaFinal))
            {
                tempoDeJogo = 24 - horaInicial + horaFinal;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");
            }
            else if (horaInicial < horaFinal)
            {
                tempoDeJogo = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");
            }
            else
            {
                tempoDeJogo = horaInicial - horaFinal + 24;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");
            }
            Console.ReadLine();
        }
    }
}
