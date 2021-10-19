using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
     public class Entreprise
    {

        /// <summary>
        /// Parametre 
        /// </summary>
        private int idEntreprise;
        private string nom;
        private string adresse;
        private string email;
        private DateTime dateCreation;
        private DateTime dateDerniereModif;
        private Ville laVille;

        /// <summary>
        /// La methode Get renvoie la valeur de la variable name. 
        /// La methode Set affecte a valueà la namevariable.Le valuemot-clé représente la valeur que nous attribuons à la propriété.
       /// </summary>
        public Ville Ville { get => laVille; set => laVille = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public DateTime DateDerniereModif { get => dateDerniereModif; set => dateDerniereModif = value; }
        


        /// <summary>
        /// Une Constructeur permettant de 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="adresse"></param>
        /// <param name="email"></param>
        /// <param name="dateCreation"></param>
        /// <param name="dateDerniereModif"></param>
        /// <param name="laVille"></param>
        public Entreprise(string nom, string adresse, string email, DateTime dateCreation, DateTime dateDerniereModif, Ville laVille)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.email = email;
            this.dateCreation = dateCreation;
            this.dateDerniereModif = dateDerniereModif;
            this.laVille = laVille;

        }

        public Entreprise(string leNom, int idEntreprise)
        {
            this.idEntreprise = idEntreprise;
        }

        public Entreprise(int idEntreprise)
        {
            this.idEntreprise = idEntreprise;
        }
    }
}
