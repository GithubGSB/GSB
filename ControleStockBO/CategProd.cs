using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    /// <summary>
    /// création de la classe CategProd pour les catégories de produits
    /// </summary>
    public class CategProd
    {
        private int id;
        private string libelle;

       
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        /// <summary>
        /// Constructeur avec l'ensemble des paramètres
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public CategProd (int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
           
        }
        /// <summary>
        /// Constructeur avec Id seulement
        /// </summary>
        /// <param name="id"></param>
        public CategProd (int id)
        {
            this.id = id;
        }
    }
}
