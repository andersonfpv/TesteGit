using System;
using System.Globalization;

namespace Funcionario
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto, desconto;

        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public void aumentarsalario(double porcentagem)
        {
            salarioBruto = salarioBruto + (salarioBruto  * porcentagem / 100);
        }

        public override string ToString()
        {
            return nome
                + ", R$ "
                + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture); ;
        }
    }
}
