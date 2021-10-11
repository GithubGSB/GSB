using ControleStockBO;
using ControleStockDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBLL
{
    /// <summary>
    /// Classe permettant la gestion des profils
    /// </summary>
    public class ProfilManager
    {
        private static ProfilManager uneInstance;
        /// <summary>
        /// Premet de récupéré l'instance ProfilManager
        /// </summary>
        /// <returns>Instance de ProfilManager</returns>
        public static ProfilManager GetInstance()
        {
            if (uneInstance == null) uneInstance = new ProfilManager();
            return uneInstance;
        }
        private ProfilManager() { }

        /// <summary>
        /// Permet de récupéré la liste des profils de la BD
        /// </summary>
        /// <returns>Liste des profils</returns>
        public List<Profil> GetProfils()
        {
            return ProfilDAO.GetInstance().GetProfils();
        }
    }
}
