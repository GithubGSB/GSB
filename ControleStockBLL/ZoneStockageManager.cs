using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockDAL;
using ControleStockBO;

namespace ControleStockBLL
{
    public class ZoneStockageManager
    {
        private static ZoneStockageManager uneZoneStockageManager; 
        // PATERN SINGLETON
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
