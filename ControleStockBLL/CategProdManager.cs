using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockDAL;
using ControleStockBO;

namespace ControleStockBLL
{
    public class CategProdManager
    {
        private static CategProdManager uneCategProdManager;
        // PATERN SINGLETON 
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
        /// <returns></returns>
        public List<CategProd> GetLesCategoriesProduits()
        {
            return CategProdDAO.GetInstance().GetLesCategProds();
        }
    }
}
