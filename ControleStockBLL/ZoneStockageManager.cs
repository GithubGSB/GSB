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
    /// BLL de Zone de stockage 
    /// </summary>
    public class ZoneStockageManager
    {
        
        private static ZoneStockageManager uneZoneStockageManager; 
        // PATERN SINGLETON
       /// <summary>
       /// Créer l'instance de ZoneStockageManager
       /// </summary>
       /// <returns>uneZoneStockageManager</returns>
        public static ZoneStockageManager GetInstance()
        {
            if (uneZoneStockageManager == null)
            {
                uneZoneStockageManager = new ZoneStockageManager();
            }
            return uneZoneStockageManager;
        }
        private ZoneStockageManager()
        {

        }

        /// <summary>
        /// Méthode qui appelle une méthode de la couche DAO pour ajouter une nouvelle Zone de Stockage dans la BD
        /// </summary>
        /// <param name="sonNomZone"></param>
        /// <param name="sonBatiment"></param>
        /// <param name="sonEtage"></param>
        /// <param name="saDateCreation"></param>
        /// <param name="saDateDernModif"></param>
        /// <param name="sonAdresse"></param>
        /// <param name="sonIdCategProd"></param>
        /// <param name="sonIdVille"></param>
        /// <returns>retourne le nombre d'enregistrement realise</returns>
        public int AjoutZoneStockage(string sonNomZone, string sonBatiment, string sonEtage, 
        DateTime saDateCreation, DateTime saDateDernModif,string sonAdresse, int sonIdCategProd,
            int sonIdVille)
        {
            Ville laVille;
            laVille = new Ville(sonIdVille);
            CategProd laCategProd;
            laCategProd = new CategProd(sonIdCategProd);
            ZoneStockage laZoneStockage;
            laZoneStockage = new ZoneStockage(sonNomZone, sonBatiment, sonEtage, saDateCreation, saDateDernModif, sonAdresse, laCategProd, laVille);
            return ZoneStockageDAO.GetInstance().AjoutZoneStockage(laZoneStockage);
        }

    }
}
