using System;
using System.Globalization;

namespace SequenciaS2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1.0, x = 2.0;
            int i;

            for (i = 3; i <= 39; i += 2)
            {
                s += i / x;
                x *= 2;
            }
            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
