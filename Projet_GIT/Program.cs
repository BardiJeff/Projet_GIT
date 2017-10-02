using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnes personne1 = new Personnes();
            Console.WriteLine(personne1.Identite());

            Personnes personne2 = new Personnes("\nUrthaler", "Stephan");
            Console.WriteLine(personne2.Identite());

            Console.ReadKey();
        }
    }
}
