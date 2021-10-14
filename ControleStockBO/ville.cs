using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class Ville
    {
        private int insee;
        private string nom;
        private int codePostal;

        public int Insee { get => insee; set => insee = value; }
        public string Nom { get => nom; set => nom = value; }
        public int CodePostal { get => codePostal; set => codePostal = value; }
        //Constructeur pour la
        public Ville(string insee, string nom)
        {
            this.insee = insee;
            this.nom = nom;
            this.codePostal = codePostal;
        }
    }
}
