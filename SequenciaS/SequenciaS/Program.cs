using System;
using System.Globalization;

namespace SequenciaS
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1.0;

            for (int i = 2; i <= 100; i++)
            {
                s += 1.0 / (double)i;
            }
            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
