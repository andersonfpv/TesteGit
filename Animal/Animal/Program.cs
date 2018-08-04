using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string classe, grupo, subGrupo;

            classe = Console.ReadLine();
            grupo = Console.ReadLine();
            subGrupo = Console.ReadLine();

            if (classe == "vertebrado" && grupo == "ave" && subGrupo == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (classe == "vertebrado" && grupo == "ave" && subGrupo == "onivoro")
            {
                Console.WriteLine("pomba");
            }
            else if (classe == "vertebrado" && grupo == "mamifero" && subGrupo == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (classe == "vertebrado" && grupo == "mamifero" && subGrupo == "herbivoro")
            {
                Console.WriteLine("vaca");
            }
            else if (classe == "invertebrado" && grupo == "inseto" && subGrupo == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (classe == "invertebrado" && grupo == "inseto" && subGrupo == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            else if (classe == "invertebrado" && grupo == "anelideo" && subGrupo == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else
            {
                Console.WriteLine("minhoca");
            }
            Console.ReadLine();
        }
    }
}
