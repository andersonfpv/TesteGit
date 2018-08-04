using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x;
            double valorInicial = 0;
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            Char ch = char.Parse(Console.ReadLine());
            if (ch == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new Conta(numero, nome, valorInicial);
            }
            else
            {
                x = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Conta criada: ");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositar(dep);
            Console.WriteLine();
            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.WriteLine("Digite um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.sacar(saq);
            Console.WriteLine();
            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
