using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class EtudiantDao
    {
        string fileEtudiant = "C:\\Users\\user\\source\\repos\\JihaneBouhajbane\\JihaneBouhajbane\\Et.csv";
        public void addEtudiant(int id, string nom, string prenom, string password)
        {
            StreamWriter sw = new StreamWriter(fileEtudiant, true);
            sw.WriteLine(id + "," + nom + "," + prenom + "," + password);
            sw.Close();
        }

        public Etudiant findEtudiantById(int id)
        {
            Etudiant e = null;

            StreamReader sd = new StreamReader(fileEtudiant);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (Int32.Parse(dd[0]) == id)
                {
                    e = new Etudiant();
                    e.Id = id;
                    e.Name = dd[1];
                    e.Prenom = dd[2];
                    break;
                }
                line = sd.ReadLine();
            }
            sd.Close();
            return e;
        }
        public List<Etudiant> ALLEtudiants()
        {
            List<Etudiant> es = new List<Etudiant>();
            StreamReader sd = new StreamReader(fileEtudiant);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");

                Etudiant e = new Etudiant();
                e.Id = Int32.Parse(dd[0]);
                e.Name = dd[1];
                e.Prenom = dd[2];
                e.Password = dd[3];
                es.Add(e);
                line = sd.ReadLine();
            }
            sd.Close();
            return es;
        }
        public void SupprimerEtudiantParId(int id)
        {
            List<string> lignes = new List<string>();


            StreamReader sr = new StreamReader(fileEtudiant);
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

            StreamWriter sw = new StreamWriter(fileEtudiant, false);
            foreach (string l in lignes)
            {
                sw.WriteLine(l);
            }
            sw.Close();
        }

    }
}
 