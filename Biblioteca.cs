using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2_Tema
{
    internal class Biblioteca
    {
        public static Carte CitesteCarte()
        {
            Console.WriteLine("Introduceti titlul cartii:");
            string titlu = Console.ReadLine();

            Console.WriteLine("Introduceti autorul cartii:");
            string autor = Console.ReadLine();

            Console.WriteLine("Introduceti anul publicarii:");
            int anPublicatie = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti valabilitatea cartii (true/false):");
            bool valabilitate = bool.Parse(Console.ReadLine());
            return new Carte(titlu, autor, anPublicatie, valabilitate);
        }

        public void StergeCarte(Carte carte)
        {

        }

        public void CautaCarte(string criteriu)
        {

        }

        public void AfiseazaCarti()
        {

        }
    }
}
