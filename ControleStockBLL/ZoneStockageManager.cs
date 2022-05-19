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
        public ZoneStockage RecupererZoneStockage(int id)
        {
            return ZoneStockageDAO.GetInstance().GetLaZoneStockage(id);
        }
        public ZoneStockage RecupererZoneStockageASuppr(int id)
        {
            return ZoneStockageDAO.GetInstance().GetLaZoneStockageASuppr(id);
        }
        public int ModifZoneStockage (int id, string sonNomZone, string sonBatiment, string sonEtage, DateTime saDateDernModif, string sonAdresse, int sonIdCategProd, int sonIdVille)
        {
            Ville laVille;
            laVille = new Ville(sonIdVille);
            CategProd laCategProd;
            laCategProd = new CategProd(sonIdCategProd);
            ZoneStockage laZoneStockage;
            
            laZoneStockage = new ZoneStockage(id, sonNomZone, sonBatiment, sonEtage,  sonAdresse, saDateDernModif, laVille, laCategProd);
            return ZoneStockageDAO.GetInstance().ModifZoneStockage(laZoneStockage);
        }
        public int SupprZoneStockage (int sonId)
        {
            return ZoneStockageDAO.GetInstance().SupprZoneStockage(sonId);
        }

    }
}