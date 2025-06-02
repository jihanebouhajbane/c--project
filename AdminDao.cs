using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class AdminDao
    {
        string fileAdmin = "C:\\Users\\user\\source\\repos\\JihaneBouhajbane\\JihaneBouhajbane\\Ad.csv";
        public void addEtudiant(int id, string nom, string prenom, string password)
        {
            StreamWriter sw = new StreamWriter(fileAdmin, true);
            sw.WriteLine(id + "," + nom + "," + prenom + "," + password);
            sw.Close();
        }
    }
}
