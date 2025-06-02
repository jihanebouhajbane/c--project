using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class NoteDao
    {
        string fileNote = "C:\\Users\\user\\source\\repos\\JihaneBouhajbane\\JihaneBouhajbane\\NO.csv";

        public Stream FileNote { get; private set; }

        public void addEtudiant(int id, string nom, string prenom, string password)
        {
            StreamWriter sw = new StreamWriter(fileNote, true);
            sw.WriteLine(id + "," + nom + "," + prenom+","+ password);
            sw.Close();
        }

       

        public List<Note> allnotes(string Matière)
        {
            List<Note> ms = new List<Note>();

            StreamReader sd = new StreamReader(fileNote);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (Matière == dd[3])
                {
                    Note e = new Note();
                    e.IdN = Int32.Parse(dd[0]);
                    e.IdET = Int32.Parse(dd[2]);
                    e.Matier1 = dd[3];
                    e.Session = dd[4];
                }
                line = sd.ReadLine();
            }
            sd.Close();
            return ms;


        }
        public List<Note> allnotesBySession(string Session)
        {
            List<Note> ms = new List<Note>();

            StreamReader sd = new StreamReader(fileNote);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (Session == dd[4])
                {
                    Note e = new Note();
                    e.IdN = Int32.Parse(dd[0]);
                    e.IdET = Int32.Parse(dd[2]);
                    e.Matier1 = dd[3];
                    e.Session = dd[4];
                }
                line = sd.ReadLine();
            }
            sd.Close();
            return ms;


        }

        public List<Note> findNoteById(int id)
        {
            List<Note> n = new List<Note>();

            StreamReader sd = new StreamReader(fileNote);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (Int32.Parse(dd[1]) == id)
                {
                    Note e = new Note();
                    e.IdN = Int32.Parse(dd[0]);
                    e.IdET = id;
                    e.Matier1 = dd[2];
                    e.Session = dd[3];

                    n.Add(e);
                }
                line = sd.ReadLine();
            }
            sd.Close();
            return n;
        }
        public double Moyenne(string matiereRecherchee)
        {
            double somme = 0;
            int compteur = 0;

            StreamReader sr = new StreamReader(FileNote);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                string Matier = dd[1];
                double Notes = Double.Parse(dd[3]);

                if (Matier == matiereRecherchee)
                {
                    somme += Notes;
                    compteur++;
                }

                line = sr.ReadLine();
            }

            sr.Close();

            if (compteur == 0)
                return 0;

            return somme / compteur;
        }

        public double TauxReussite(string matierRecherchee)
        {
            int Total = 0;
            int Reussite = 0;

            StreamReader sr = new StreamReader(FileNote);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                string Matier = dd[1];
                double Note = Double.Parse(dd[3]);

                if (Matier == matierRecherchee)
                {
                    Total++;
                    if (Note >= 10)
                        Reussite++;
                }

                line = sr.ReadLine();
            }

            sr.Close();

            if (Total == 0)
                return 0;

            return 100.0 * Reussite / Total;
        }
    }
}
