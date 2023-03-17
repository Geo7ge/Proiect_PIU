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
            int nrCarti = 0;


            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii pentru carte de la tastatura");
                Console.WriteLine("A. Afisare ultimele informatii intruduse");
                //Console.WriteLine("F. Afisare studenti din fisier");
                //Console.WriteLine("S. Salvare student in fisier");
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
/*                    case "F":
                        Student[] studenti = adminStudenti.GetStudenti(out nrStudenti);
                        AfisareStudenti(studenti, nrStudenti);

                        break;*/
/*                    case "S":
                        int idStudent = nrStudenti + 1;
                        student.SetIdStudent(idStudent);
                        //adaugare student in fisier
                        adminStudenti.AddStudent(student);

                        nrStudenti = nrStudenti + 1;

                        break;*/
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");
        }
    }
}
