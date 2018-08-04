using System;
using System.Globalization;
namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            double pctgem;
            Funcionario f;
            f = new Funcionario();

            Console.Write("Nome: ");
            f.nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            f.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do Funcionario: " +f);


            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem: ");
            pctgem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.aumentarsalario(pctgem);

            Console.WriteLine();
            Console.WriteLine("Dados do Funcionario: " + f);

            Console.ReadLine();
        }
    }
}
