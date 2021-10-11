using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class Utilisateur
    {
        private int id;
        private string nom;
        private string prenom;
        private Profil profil;

        public Utilisateur(int id, string nom, string prenom, Profil profil)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.profil = profil;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public Profil Profil { get => profil; set => profil = value; }
    }
}
