using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockBO;
using ControleStockDAL;

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

        public List<ZoneStockage> GetLesZonesStockages()
        {
            return ZoneStockageDAO.GetInstance().GetLesZonesStockages();
        }
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
        public List<ZoneStockage> ConsultZonesStockages()
        {
            return ZoneStockageDAO.GetInstance().ConsultZonesStockages();
        }

    }
}