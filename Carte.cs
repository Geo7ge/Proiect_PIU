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

        private const int TITLU = 0;
        private const int AUTOR = 1;
        private const int ANPUBLICATIE = 2;
        private const int VALABILITATE = 3;
        private const int DETINATOR = 4;

        public string Titlu { get; set; }
        public string Autor { get; set; }
        public int AnPublicatie { get; set; }
        public bool Valabilitate { get; set; }
        public string Detinator { get; set; }

        public Carte() //Constructor implicit
        {
            Titlu = Autor = Detinator = string.Empty;
            AnPublicatie = 0;
            Valabilitate = false;
        }
        public Carte(string titlu, string autor, int anPublicatie, bool valabilitate, string detinator) //Constructor cu parametrii
        {
            Titlu = titlu;
            Autor = autor;
            AnPublicatie = anPublicatie;
            Valabilitate = valabilitate;
            Detinator = detinator;
        }

        public Carte(string linieFisier) //Constructor folosind datele din fisier
        {
            var dateFisier = linieFisier.Split(SEPARATOR);
            Titlu = dateFisier[TITLU];
            Autor = dateFisier[AUTOR];
            AnPublicatie = Convert.ToInt16(dateFisier[ANPUBLICATIE]);
            Valabilitate = Convert.ToBoolean(dateFisier[VALABILITATE]);
            Detinator = dateFisier[DETINATOR];
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

        public string Info()
        {
            string info = string.Format("Titlu: {0} Autor: {1} An publicatie: {2} Valabilitate: {3} Detinator: {4}",
                GetTitlu(),
                GetAutor(),
                GetAnPublicatie(),
                GetValabilitate(),
                GetDetinator());
            return info;
        }

        public string ConversieLaSirPentruFisier() ///// LAB_3 - conversia datelor la string pentru scrierea in fisier
        {
            string stringPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR,
                GetTitlu(),
                GetAutor(),
                GetAnPublicatie(),
                GetValabilitate(),
                GetDetinator());
            return stringPentruFisier;
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