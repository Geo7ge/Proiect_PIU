using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2_Tema
{
    internal class AdministrareCarti_FisierText
    {
        private const int NR_MAX_CARTI = 100;
        private string numeFisier;

        public AdministrareCarti_FisierText(string numeFisier) ///// LAB_3 - deschiderea unui fisier text in modul open or create
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddCarte(Carte carte) ///// LAB_3 - salvarae datelor intr-un fisier text(in mod append)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(carte.ConversieLaSirPentruFisier());
            }
        }

        public Carte[] GetCarti(out int nrCarti) ///// LAB_3 - preluarea datelor dintr-un fisier text
        {
            Carte[] carti = new Carte[NR_MAX_CARTI];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrCarti = 0;
                //Citeste cate o linie si creeaza cate un obiect de tip carte
                while((linieFisier = streamReader.ReadLine()) != null)
                {
                    carti[nrCarti++] = new Carte(linieFisier);
                }
            }
            return carti;
        }

    }
}
