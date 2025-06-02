using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class ExamenDao
    {
        string fileExamen = "C:\\Users\\user\\source\\repos\\JihaneBouhajbane\\JihaneBouhajbane\\Ex.csv";
        public void addEtudiant(int id, string nom, string prenom, string password)
        {
            StreamWriter sw = new StreamWriter(fileExamen, true);
            sw.WriteLine(id + "," + nom + "," + prenom + "," + password);
            sw.Close();
        }
        public List<Examen> getAllExamens()
        {
            List<Examen> examens = new List<Examen>();

            StreamReader sr = new StreamReader(fileExamen);
            string line = sr.ReadLine();
            DateTime date = DateTime.Now;

            while (line != null)
            {
                string[] parts = line.Split(',');
                if (date < DateTime.Parse(parts[3]))
                {
                    Examen e = new Examen();
                    e.IdE = Int32.Parse(parts[0]);
                    e.IdET = Int32.Parse(parts[0]);
                    e.Matier1 = parts[1];
                    e.Session = parts[2];
                    e.Date1 = DateTime.Parse(parts[3]);

                    examens.Add(e);
                }

                line = sr.ReadLine();
            }

            sr.Close();
            return examens;
        }
        public List<Etudiant> findEtudiantsByExam(string nomExam)
        {
            List<Etudiant> listeEtudiant = new List<Etudiant>();

            StreamReader sr = new StreamReader(fileExamen);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                string examName = dd[1];
                int etudiantId = Int32.Parse(dd[4]);

                if (examName == nomExam)
                {
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
    }
}
