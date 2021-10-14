using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
     public class Entreprise
    {
        private int id;
        private string nom;
        private string adresse;
        private string email;
        private DateTime dateCreation;
        private DateTime dateDerniereModif;
        private Ville insee;
           
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Email { get => email; set => email = value; }
        public Ville Insee { get => insee; set => insee = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public DateTime DateDerniereModif { get => dateDerniereModif; set => dateDerniereModif = value; }

        public Entreprise(int id, string nom, string adresse, string email, DateTime dateCreation, DateTime dateDerniereModif, Ville insee)
        {
            this.id = id;
            this.nom = nom;
            this.adresse = adresse;
            this.email = email;
            this.dateCreation = dateCreation;
            this.dateDerniereModif = dateDerniereModif;
            this.insee = insee;

        }
        public Entreprise(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public Entreprise(string nom, string adresse, string email, DateTime dateCreation, DateTime dateDerniereModif, Ville insee)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.email = email;
            this.dateCreation = dateCreation;
            this.dateDerniereModif = dateDerniereModif;
            this.insee = insee;

        }

        public Entreprise(int id)
        {
            this.id = id;
        }
    }
}
