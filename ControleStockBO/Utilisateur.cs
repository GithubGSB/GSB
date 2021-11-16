using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    /// <summary>
    /// Classe permettant de stocké les données relatif à l'utilisateur
    /// </summary>
    public class Utilisateur
    {
        private int id;
        private string nom;
        private string prenom;
        private Profil profil;
        private DateTime dateCreation;
        private DateTime dateDerniereModif;

        /// <summary>
        /// Initialise une nouvelle Instance de la classe Utilisateur
        /// </summary>
        /// <param name="id">id permetant d'identifié l'utilisateur</param>
        /// <param name="nom">nom de l'utilisateur</param>
        /// <param name="prenom">prénom de l'utilisateur</param>
        /// <param name="profil">profil de l'utilisateur</param>
        /// <param name="dateCreation">date de création de l'utilisateur</param>
        /// <param name="dateDerniereModif">date de la dernière modification de l'utilisateur</param>
        public Utilisateur(int id, string nom, string prenom, Profil profil, DateTime dateCreation, DateTime dateDerniereModif)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.profil = profil;
            this.dateCreation = dateCreation;
            this.dateDerniereModif = dateDerniereModif;
        }

        /// <summary>
        /// Initialise une nouvelle Instance de la classe Utilisateur
        /// </summary>
        /// <param name="id">id permetant d'identifié l'utilisateur</param>
        /// <param name="nom">nom de l'utilisateur</param>
        /// <param name="prenom">prénom de l'utilisateur</param>
        public Utilisateur(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.profil = null;
            this.dateCreation = DateTime.Now;
        }

        /// <summary>
        /// Initialise une nouvelle Instance de la classe Utilisateur
        /// </summary>
        /// <param name="id">id permetant d'identifié l'utilisateur</param>
        /// <param name="nom">nom de l'utilisateur</param>
        /// <param name="prenom">prénom de l'utilisateur</param>
        /// /// <param name="profil">profil de l'utilisateur</param>
        public Utilisateur(int id, string nom, string prenom, Profil profil)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.profil = profil;
            this.dateCreation = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public Profil Profil { get => profil; set => profil = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public DateTime DateDerniereModif { get => dateDerniereModif; set => dateDerniereModif = value; }
        public string LibelleProfil { get => profil.Libelle; }
        public string NomPrenom { get => nom + " " + prenom; }
    }
}
