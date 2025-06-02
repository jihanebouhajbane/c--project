using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class EnseDao
    {
        string fileEseignant = "C:\\Users\\user\\source\\repos\\JihaneBouhajbane\\JihaneBouhajbane\\Es.csv";


        public void addEtudiant(int id, string nom, string prenom, string password)
        {
            StreamWriter sw = new StreamWriter(fileEseignant, true);
            sw.WriteLine(id + "," + nom + "," + prenom+","+password);
            sw.Close();
        }
        public List<Ense> AllEnseignants()
        {
            List<Ense> es = new List<Ense>();
            StreamReader sd = new StreamReader(fileEseignant);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");

                Ense e = new Ense();
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
        public void SupprimerEnseignantParId(int id)
        {
            List<string> lignes = new List<string>();


            StreamReader sr = new StreamReader(fileEseignant);
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

            StreamWriter sw = new StreamWriter(fileEseignant, false);
            foreach (string l in lignes)
            {
                sw.WriteLine(l);
            }
            sw.Close();
        }
        public Ense findEnseignanttById(int id)
        {
            Ense e = null;

            StreamReader sd = new StreamReader(fileEseignant);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (Int32.Parse(dd[0]) == id)
                {
                    e = new Ense();
                    e.Id = id;
                    e.Name  = dd[1];
                    e.Prenom = dd[2];
                    e.Password = dd[3];
                    break;
                }
                line = sd.ReadLine();
            }
            sd.Close();
            return e;
        }

    }
}

