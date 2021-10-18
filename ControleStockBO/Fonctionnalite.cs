using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    /// <summary>
    /// Classe permettant de stocké les données sur les différentes fonctionnalités de l'application
    /// </summary>
    public class Fonctionnalite
    {
        private string code;
        private string libelle;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Fonctionnalite
        /// </summary>
        /// <param name="code">code permettant d'identifié la fonctionnalité</param>
        /// <param name="libelle">libelle permettant d'explicité la fonctionnalité</param>
        public Fonctionnalite(string code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;
        }

        public string Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
