using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class Note
    {
        private int idN;
        private int idET;
        private string Matier;
        private string session;

        public int IdN { get => idN; set => idN = value; }
        public int IdET { get => idET; set => idET = value; }
        public string Matier1 { get => Matier; set => Matier = value; }
        public string Session { get => session; set => session = value; }
    }
}
