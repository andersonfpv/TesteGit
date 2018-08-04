using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImparesNegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, posit = 0, negat = 0, par = 0, imp = 0;

            for (int i = 0; i < 5; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    posit++;
                }
                if (n < 0)
                {
                    negat++;
                }
                if (n % 2 == 0)
                {
                    par++;
                }
                if (n % 2 != 0)
                {
                    imp++;
                }
            }
            Console.WriteLine(par + " valor(es) par(es)" );
            Console.WriteLine(imp + " valor(es) impar(es)");
            Console.WriteLine(posit + " valor(es) positivo(s)");
            Console.WriteLine(negat + " valor(es) negativo(s)");
            Console.ReadLine();
        }
    }
}
