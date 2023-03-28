using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Lab2_Tema
{
    internal class Program
    {
        static void Main()
        {
            Carte carte = new Carte();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareCarti_FisierText adminCarti = new AdministrareCarti_FisierText(numeFisier);
            int nrCarti = 0;
            adminCarti.GetCarti(out nrCarti);

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii pentru carte de la tastatura");
                Console.WriteLine("A. Afisare ultimele informatii intruduse despre o carte");
                Console.WriteLine("F. Afisare carti din fisier");
                Console.WriteLine("S. Salvare carte in fisier");
                Console.WriteLine("C. Cauta prin carti dupa un anumit criteriu");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        carte = Carte.CitesteCarteTastatura();

                        break;
                    case "A":
                        carte.AfiseazaCarte();

                        break;
                    case "F":
                        Carte[] carti = adminCarti.GetCarti(out nrCarti);
                        AfisareCarti(carti, nrCarti);

                        break;
                    case "S":
                        adminCarti.AddCarte(carte);

                        nrCarti = nrCarti + 1;

                        break;
                    case "C":
                        Carte[] Carti = adminCarti.GetCarti(out nrCarti);
                        Console.WriteLine("Aveti de ales dintre urmatoarele optiuni:" +
                            "   Titlu   Autor   AnPublicatie   Detinator");
                        CautaCarte(Console.ReadLine(), nrCarti, Carti);

                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");
            Console.ReadKey();
        }

        public static void AfisareCarte(Carte carte) ///// LAB_3 - afisare date din fisier
        {
            string infoCarte = string.Format("Titlu: {0} Autor: {1} An publicatie: {2} Valabilitate: {3} Detinator: {4}",
                carte.GetTitlu(),
                carte.GetAutor(),
                carte.GetAnPublicatie(),
                carte.GetValabilitate(),
                carte.GetDetinator());
            Console.WriteLine(infoCarte);
        }

        public static void AfisareCarti(Carte[] carti, int nrCarti) ///// LAB_3 - afisare date din fisier
        {
            Console.WriteLine("Cartile sunt : ");
            for (int contor = 0; contor < nrCarti; contor++)
            {
                AfisareCarte(carti[contor]);
            }
        }

        public static void CautaCarte(string criteriu, int nrCarti, Carte[] carti) ///// LAB_3 - căutarea după anumite criterii
        {

            switch(criteriu)
            {
                case "Titlu":
                    Console.WriteLine("Introduceti datele pe care doriti sa le cautati");
                    string date_cerute = Console.ReadLine();
                    Console.WriteLine("Pentru datele introduse am gasit in fisier urmatoarele similaritati");
                    for (int contor = 0; contor < nrCarti; contor++)
                        if (carti[contor].GetTitlu() == date_cerute)
                            Console.WriteLine(carti[contor].Info());

                        break;
                case "Autor":
                    Console.WriteLine("Introduceti datele pe care doriti sa le cautati");
                    date_cerute = Console.ReadLine();
                    Console.WriteLine("Pentru datele introduse am gasit in fisier urmatoarele similaritati");
                    for (int contor = 0; contor < nrCarti; contor++)
                        if (carti[contor].GetAutor() == date_cerute)
                            Console.WriteLine(carti[contor].Info());

                    break;
                case "AnPublicatie":
                    Console.WriteLine("Introduceti datele pe care doriti sa le cautati");
                    date_cerute = Console.ReadLine();
                    Console.WriteLine("Pentru datele introduse am gasit in fisier urmatoarele similaritati");
                    for (int contor = 0; contor < nrCarti; contor++)
                        if (carti[contor].GetAnPublicatie() == Convert.ToInt16(date_cerute))
                            Console.WriteLine(carti[contor].Info());

                    break;
                case "Detinator":
                    Console.WriteLine("Introduceti datele pe care doriti sa le cautati");
                    date_cerute = Console.ReadLine();
                    Console.WriteLine("Pentru datele introduse am gasit in fisier urmatoarele similaritati");
                    for (int contor = 0; contor < nrCarti; contor++)
                        if (carti[contor].GetDetinator() == date_cerute)
                            Console.WriteLine(carti[contor].Info());

                    break;
                default:
                    Console.WriteLine("Optiune inexistenta");

                    break;
            }
        }

    }
}
