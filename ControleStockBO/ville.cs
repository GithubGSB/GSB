using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class Ville
    {
        private string insee;
        private string nom;
        private int codePostal;

        public string Insee { get => insee; set => insee = value; }
        public string Nom { get => nom; set => nom = value; }
        public int CodePostal { get => codePostal; set => codePostal = value; }

        public Ville(string insee, string nom)
        {
            this.insee = insee;
            this.nom = nom;
           
        }


        public Ville(string insee)
        {
            this.insee = insee;
        }
    }
}
