using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockDAL;
using ControleStockBO;

namespace ControleStockBLL
{
    /// <summary>
    /// BLL de ville
    /// </summary>
    public class VilleManager
    {

        private static VilleManager uneVilleManager;
        // PATERN SINGLETON
        /// <summary>
        /// Création de l'insance de VilleManager
        /// </summary>
        /// <returns>uneVilleManager</returns>
        public static VilleManager GetInstance()
        {
            if (uneVilleManager == null)
            {
                uneVilleManager = new VilleManager();
            }
            return uneVilleManager;
        }
        private VilleManager()
        {

        }
        /// <summary>
        /// Méthode qui appelle une méthode de la couche DAO pour retourner les villes de la BD
        /// </summary>
        /// <returns>la liste des villes</returns>
        public List<Ville> GetLesVilles()
        {
            return VilleDAO.GetInstance().GetLesVilles();
        }
    }
    
}
