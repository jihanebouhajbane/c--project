using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class Examen
    {
        private int idE;
        private int idET;
        private string Matier;
        private string session;
        private DateTime Date;

        public int IdE { get => idE; set => idE = value; }
        public int IdET { get => idET; set => idET = value; }
        public string Matier1 { get => Matier; set => Matier = value; }
        public string Session { get => session; set => session = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
    }
}
