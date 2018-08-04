using System;


namespace TipoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, alcool, gasolina, diesel;
            alcool = 0;
            gasolina = 0;
            diesel = 0;
            do
            {
                opcao = 0;
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    alcool = alcool + 1;
                }

                if (opcao == 2)
                {
                    gasolina = gasolina + 1;
                }

                if (opcao == 3)
                {
                    diesel = diesel + 1;
                }

                if (opcao != 4)
                {
                    
                }

            } while (opcao != 4);
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

            Console.ReadLine();
        }
    }
}
