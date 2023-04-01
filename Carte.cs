using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Tema
{
    internal class Carte
    {
        public enum valabilitate ///// LAB_5 - exercitiul 2;
        {
            True = 1,
            False = 2
        };

        public enum subiectLiterar ///// LAB_5 - exercitiul 2;
        {
            Literatura_moderna = 1,
            Crima = 2,
            Fantezie = 3,
            Actiune = 4,
            Dragoste = 5,
            Thriller = 6,
            Literatura_clasica = 7,
            Fictine = 8,
            Istorie = 9
        }
        
        private const char SEPARATOR = ';';

        private const int TITLU = 0;
        private const int AUTOR = 1;
        private const int ANPUBLICATIE = 2;
        private const int SUBIECTLITERAR = 3;
        private const int VALABILITATE = 4;
        private const int DETINATOR = 5;

        public string Titlu { get; set; } ///// LAB_5 - exercitiul 1;
        public string Autor { get; set; } ///// LAB_5 - exercitiul 1;
        public int AnPublicatie { get; set; } ///// LAB_5 - exercitiul 1;
        public string SubiectLiterar { get; set; } ///// LAB_5 - exercitiul 1;

        public bool Valabilitate { get; set; } ///// LAB_5 - exercitiul 1;
        public string Detinator { get; set; } ///// LAB_5 - exercitiul 1;

        public Carte() //Constructor implicit
        {
            Titlu = Autor = Detinator = SubiectLiterar = string.Empty;
            AnPublicatie = 0;
            Valabilitate = false;
        }
        public Carte(string titlu, string autor, int anPublicatie, string subiectLiterar, bool valabilitate, string detinator) //Constructor cu parametrii
        {
            Titlu = titlu;
            Autor = autor;
            AnPublicatie = anPublicatie;
            SubiectLiterar = subiectLiterar;
            Valabilitate = valabilitate;
            Detinator = detinator;
        }

        public Carte(string linieFisier) //Constructor folosind datele din fisier
        {
            var dateFisier = linieFisier.Split(SEPARATOR);
            Titlu = dateFisier[TITLU];
            Autor = dateFisier[AUTOR];
            AnPublicatie = Convert.ToInt16(dateFisier[ANPUBLICATIE]);
            SubiectLiterar= dateFisier[SUBIECTLITERAR];
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

            string subiectliterar = SetSubiectLiterar();

            //Console.WriteLine("Introduceti valabilitatea cartii (true/false):");
            bool valabilitate = SetValabilitate();

            string detinator;
            if (valabilitate == true)
            {
                detinator = "-----";
            }
            else
            {
                Console.WriteLine("Introduceti detinatorul cartii:");
                detinator = Console.ReadLine();
            }

            return new Carte(titlu, autor, anPublicatie, subiectliterar, valabilitate, detinator);
        }

        public void AfiseazaCarte() ///// LAB_3 - afisarea datelor de la tastatura;
        {
            string stringPentruAfisare = string.Format("Informatiile despre carte sunt urmatoarele:\n" +
                "Titlu: {0}\tAutor: {1}\tAn Publicatie: {2}\tSubiect Literar: {3}\tValabilitate: {4}\tDetinator: {5}",
                GetTitlu(),
                GetAutor(),
                GetAnPublicatie(),
                GetSubiectLiterar(),
                GetValabilitate(),
                GetDetinator());
            Console.WriteLine(stringPentruAfisare);
        }

        public string Info()
        {
            string info = string.Format("Titlu: {0} Autor: {1} An publicatie: {2} Subiect Literar: {3} Valabilitate: {4} Detinator: {5}",
                GetTitlu(),
                GetAutor(),
                GetAnPublicatie(),
                GetSubiectLiterar(),
                GetValabilitate(),
                GetDetinator());
            return info;
        }

        public string ConversieLaSirPentruFisier() ///// LAB_3 - conversia datelor la string pentru scrierea in fisier
        {
            string stringPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}",
                SEPARATOR,
                GetTitlu(),
                GetAutor(),
                GetAnPublicatie(),
                GetSubiectLiterar(),
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
        public string GetSubiectLiterar()
        {
            return SubiectLiterar;
        }

        public bool GetValabilitate()
        {
            return Valabilitate;
        }

        public string GetDetinator()
        { 
            return Detinator;
        }

        static bool SetValabilitate() ///// LAB_5 - exercitiul 2;
        {
            valabilitate valabil = valabilitate.False;

            int optiune;
            do
            {
                Console.WriteLine("Alegeti valabilitatea pentru cartea introdusa:");
                Console.WriteLine("1 - true \n2 - false");
                optiune = Convert.ToInt32(Console.ReadLine());
                switch (optiune)
                {
                    case 1:
                        valabil = valabilitate.True;
                        Console.WriteLine("Cartea introdusa este valabila");

                        break;
                    case 2:
                        valabil = valabilitate.False;
                        Console.WriteLine("Cartea introdusa nu este valabila");

                        break;
                    default:
                        Console.WriteLine("Optiune invalida, Va rugam incercati din nou");

                        break;

                }
            }while(optiune != 1 && optiune != 2);
            string s = Convert.ToString(valabil);
            bool output = Convert.ToBoolean(s.ToLower());

            return output;
        }

        static string SetSubiectLiterar() ///// LAB_5 - exercitiul 2;
        {
            subiectLiterar subiect = subiectLiterar.Actiune;
            int optiune;
            do
            {
                Console.WriteLine("Alegeti subiectul pentru cartea introdusa:");
                Console.WriteLine("1 - Literatura_moderna\n" +
                                  "2 - Crima\n" +
                                  "3 - Fantezie\n" +
                                  "4 - Actiune\n" +
                                  "5 - Dragoste\n" +
                                  "6 - Thriller\n" +
                                  "7 - Literatura clasica\n" +
                                  "8 - Fictiune\n" +
                                  "9 - Istorie\n");
                optiune = Convert.ToInt32(Console.ReadLine());
                switch (optiune)
                {
                    case 1:
                        subiect = subiectLiterar.Literatura_moderna;
                        Console.WriteLine("Cartea are subiectul {0}", subiect);

                        break;
                    case 2:
                        subiect = subiectLiterar.Crima;
                        Console.WriteLine("Cartea are subiectul {0}", subiect);

                        break;
                    case 3:
                        subiect = subiectLiterar.Fantezie;
                        Console.WriteLine("Cartea are subiectul {0}", subiect);

                        break;
                    case 4:
                        subiect = subiectLiterar.Actiune;
                        Console.WriteLine("Cartea are subiectul {0}", subiect);

                        break;
                    case 5:
                        subiect = subiectLiterar.Dragoste;
                        Console.WriteLine("Cartea are subiectul {0}", subiect);

                        break;
                    case 6:
                        subiect = subiectLiterar.Thriller;
                        Console.WriteLine("Cartea are subiectul {0}", subiect);

                        break;
                    case 7:
                        subiect = subiectLiterar.Literatura_clasica;
                        Console.WriteLine("Cartea are subiectul {0}", subiect);

                        break;
                    case 8:
                        subiect = subiectLiterar.Fictine;
                        Console.WriteLine("Cartea are subiectul {0}", subiect);

                        break;
                    case 9:
                        subiect = subiectLiterar.Istorie;
                        Console.WriteLine("Cartea are subiectul {0}", subiect);

                        break;
                    default:
                        optiune = 0;

                        break;
                }
            } while (optiune == 0);

            return Convert.ToString(subiect);
        }
    }
}