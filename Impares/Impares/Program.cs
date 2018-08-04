using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            num = int.Parse(Console.ReadLine());
            if (num > 0 && num <= 1000)
            {

                for (int i = 0; i <= num; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);

                    }
                }
            }
            Console.ReadLine();
        }
    }
}
