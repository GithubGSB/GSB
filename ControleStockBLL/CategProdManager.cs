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
    /// BLL de CategProd
    /// </summary>
    public class CategProdManager
    {
        private static CategProdManager uneCategProdManager;
        // PATERN SINGLETON 
        /// <summary>
        /// Créer une instance de CategProd
        /// </summary>
        /// <returns></returns>
        public static CategProdManager GetInstance()
        {
            if (uneCategProdManager == null)
            {
                uneCategProdManager = new CategProdManager();
            }
            return uneCategProdManager;
        }
        private CategProdManager()
        {

        }
        /// <summary>
        /// Méthode qui appelle une méthode de la couche DAO pour retourner les categories de produit de la BD
        /// </summary>
        /// <returns>Listes des Catégories de produit</returns>
        public List<CategProd> GetLesCategoriesProduits()
        {
            return CategProdDAO.GetInstance().GetLesCategProds();
        }
    }
}
