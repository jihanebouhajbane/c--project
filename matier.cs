using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JihaneBouhajbane
{
    internal class matier
    {

        private int IdM;
        private string libelle;
        private double coeff;
        private int idEns;
        private int idEtudiant;

        public int IdM1 { get => IdM; set => IdM = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public double Coeff { get => coeff; set => coeff = value; }
        public int IdEns { get => idEns; set => idEns = value; }
        public int IdEtudiant { get => idEtudiant; set => idEtudiant = value; }
    }
}
