using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Tema
{
    internal class Carte
    {
        private const char SEPARATOR = ';';
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public int AnPublicatie { get; set; }
        public bool Valabilitate { get; set; }
        public string Detinator { get; set; }

        public Carte()
        {
            Titlu = Autor = Detinator = string.Empty;
            AnPublicatie = 0;
            Valabilitate = false;
        }
        public Carte(string titlu, string autor, int anPublicatie, bool valabilitate, string detinator)
        {
            Titlu = titlu;
            Autor = autor;
            AnPublicatie = anPublicatie;
            Valabilitate = valabilitate;
            Detinator = detinator;
        }

        public static Carte CitesteCarteTastatura() ///// LAB_3 - citirea datelor de la tastatura;
        {
            Console.WriteLine("Introduceti titlul cartii:");
            string titlu = Console.ReadLine();

            Console.WriteLine("Introduceti autorul cartii:");
            string autor = Console.ReadLine();

            Console.WriteLine("Introduceti anul publicarii:");
            int anPublicatie = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti valabilitatea cartii (true/false):");
            bool valabilitate = bool.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti detinatorul cartii:");
            string detinator = Console.ReadLine();

            return new Carte(titlu, autor, anPublicatie, valabilitate, detinator);
        }

        public void CautaCarte(string criteriu)
        {

        }

        public void AfiseazaCarte() ///// LAB_3 - afisarea datelor de la tastatura;
        {
            string stringPentruAfisare = string.Format("Informatiile despre carte sunt urmatoarele:\n" +
                "Titlu: {0}\tAutor: {1}\tAn Publicatie: {2}\tValabilitate: {3}\tDetinator: {4}",
                GetTitlu(),
                GetAutor(),
                GetAnPublicatie(),
                GetValabilitate(),
                GetDetinator());
            Console.WriteLine(stringPentruAfisare);
        }

        public string GetTitlu()
        {
            return Titlu;
        }

        public string GetAutor()
        {
            return Autor;
        }

        public int GetAnPublicatie()
        {
            return AnPublicatie;
        }

        public bool GetValabilitate()
        {
            return Valabilitate;
        }

        public string GetDetinator()
        { 
            return Detinator;
        }
    }
}