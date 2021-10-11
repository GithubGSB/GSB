using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    /// <summary>
    /// Classe permettant de stocké les données le type du profil utilisateur, et les fonctionnalités autorisées a utilisées
    /// </summary>
    public class Profil
    {
        private int id;
        private string libelle;
        private List<Fonctionnalite> lesFoncAutorises;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Profil
        /// </summary>
        /// <param name="id">id permettant d'identifié le profil</param>
        /// <param name="libelle">libelle permettant d'explicité le libelle</param>
        public Profil(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
            this.lesFoncAutorises = new List<Fonctionnalite>();
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Profil avec des fonctionnalités
        /// </summary>
        /// <param name="id">code permettant d'identifié la fonctionnalité</param>
        /// <param name="libelle">libelle permettant d'explicité la fonctionnalité</param>
        /// /// <param name="lesFoncAutorises">liste contenant l'ensemble des fonctionnalités autorisées</param>
        public Profil(int id, string libelle, List<Fonctionnalite> lesFoncAutorises)
        {
            this.id = id;
            this.libelle = libelle;
            this.lesFoncAutorises = lesFoncAutorises;
        }

        public int Id { get => id;}
        public string Libelle { get => libelle; set => libelle = value; }
        public List<Fonctionnalite> LesFoncAutorises { get => lesFoncAutorises; set => lesFoncAutorises = value; }
    }
}
