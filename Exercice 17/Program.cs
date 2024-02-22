using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_17
{
    class Program
    {
        static void Main(string[] args)
        {//Saisie
            Console.Write("Entrez un nombre :");
            int nombre = int.Parse(Console.ReadLine());

            Console.Write("Trouvez la racine carré du nombre saisie :");
            int racine = int.Parse(Console.ReadLine());

            if (racine == Math.Sqrt(nombre))
            {
                Console.WriteLine("BRAVO ! MAMAN A DIT MON FILS 'BRAVO'");
            }
            else
            {
                Console.WriteLine("NOPE ! La réponse est " + Math.Sqrt(nombre));
            }
            Console.ReadLine();
        }
    }
}
