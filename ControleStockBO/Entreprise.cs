using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
     public class Entreprise
    {
        private string nom;
        private string adresse;
        private string email;
        private DateTime dateCreation;
        private DateTime dateDerniereModif;
        private int insee;
        private Ville laVille;

        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public DateTime DateDerniereModif { get => dateDerniereModif; set => dateDerniereModif = value; }
        public int Insee { get => insee; set => insee = value; }

        public Entreprise(string nom, string adresse, string email, DateTime dateCreation, DateTime dateDerniereModif, int insee, Ville laVille)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.email = email;
            this.dateCreation = dateCreation;
            this.dateDerniereModif = dateDerniereModif;
            this.insee = insee;
            this.laVille = laVille;

        }
    }
}
