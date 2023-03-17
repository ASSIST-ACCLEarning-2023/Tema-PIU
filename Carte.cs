using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Tema
{
    internal class Carte
    {
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public int AnPublicatie { get; set; }
        public bool Valabilitate { get; set; }

        public Carte(string titlu, string autor, int anPublicatie, bool valabilitate)
        {
            Titlu = titlu;
            Autor = autor;
            AnPublicatie = anPublicatie;
            Valabilitate = valabilitate;
        }
    }
}