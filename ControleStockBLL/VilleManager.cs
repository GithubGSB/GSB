using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockDAL;
using ControleStockBO;

namespace ControleStockBLL
{
    public class VilleManager
    {
        private static VilleManager uneVilleManager;
        // PATERN SINGLETON
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
        /// <returns></returns>
        public List<Ville> GetLesVilles()
        {
            return VilleDAO.GetInstance().GetLesVilles();
        }
    }
    
}
