using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class matierDao
    {
        string filematier = "C:\\Users\\user\\source\\repos\\JihaneBouhajbane\\JihaneBouhajbane\\MAt.csv";

        public void addmatiere(int IdM, string libelle, double coeff, int idEns, int idEtudiant)
        {

            StreamWriter sw = new StreamWriter(filematier, true);
            sw.WriteLine(IdM + "," + libelle + "," + coeff + "," + idEns + "," + idEtudiant);
            sw.Close();
        }

        public List<Etudiant> findEtudiantsByMatière(string nomMatière)
        {
            List<Etudiant> listeEtudiant = new List<Etudiant>();

            StreamReader sr = new StreamReader(filematier);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                string matiereName = dd[1];


                if (matiereName == nomMatière)
                {
                    int etudiantId = Int32.Parse(dd[4]);
                    EtudiantDao eDao = new EtudiantDao();
                    Etudiant e = eDao.findEtudiantById(etudiantId);

                    if (e != null)
                    {
                        listeEtudiant.Add(e);
                    }
                }

                line = sr.ReadLine();
            }

            sr.Close();
            return listeEtudiant;
        }




        public void SupprimerMatiereParId(int id)
        {
            List<string> lignes = new List<string>();


            StreamReader sr = new StreamReader(filematier);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                if (Int32.Parse(dd[0]) != id)
                {

                    lignes.Add(line);

                }

                line = sr.ReadLine();
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(filematier, false);
            foreach (string l in lignes)
            {
                sw.WriteLine(l);
            }
            sw.Close();
        }

        public List<matier> AllMatière()
        {
            List<matier> es = new List<matier>();
            StreamReader sd = new StreamReader(filematier);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");

                matier e = new matier();
                e.IdM1 = Int32.Parse(dd[0]);
                e.Libelle = dd[1];
                e.Coeff = Double.Parse(dd[2]);
                e.IdEtudiant = Int32.Parse(dd[3]);
                e.IdEns = Int32.Parse(dd[4]);
                es.Add(e);
                line = sd.ReadLine();
            }
            sd.Close();
            return es;
        }

        public void AffecterEnseignantAModule(string nomMatière, int enseignantId)
        {
            List<string> nouvellesLignes = new List<string>();

            StreamReader sr = new StreamReader(filematier);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                if (dd[1] == nomMatière)
                {
                    dd[3] = enseignantId.ToString();
                }

                string nouvelleLigne = string.Join(",", dd);
                nouvellesLignes.Add(nouvelleLigne);

                line = sr.ReadLine();
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(filematier, false);
            foreach (string l in nouvellesLignes)
            {
                sw.WriteLine(l);
            }
            sw.Close();
        }

    }
}
