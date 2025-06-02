using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class Etudiant
    {
        private int id;
        private string name;
        private string prenom;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Password { get => password; set => password = value; }
    }
}
