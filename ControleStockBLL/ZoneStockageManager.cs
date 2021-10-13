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
        public List<CategProd> GetLesCategoriesProduits()
        {
            return CategorieProduitDAO.GetInstance().GetLesCategoriesProduits();
        }
        public List<Ville> GetLesVilles()
        {
            return VilleDAO.GetInstance().GetLesVilles();
        }
        public int AjoutZoneStockage(string sonNomZone, string sonBatiment, string sonEtage, 
            string sonAdresse, DateTime saDateCreation, DateTime saDateDernModif,
            int sonIdVille, int sonIdCategProd)
        {
            Ville laVille;
            laVille = new Ville(sonIdVille);
            CategProd laCategProd;
            laCategProd = new CategProd(sonIdCategProd);
            ZoneStockage laZoneStockage;
            laZoneStockage = new ZoneStockage(sonNomZone, sonBatiment, sonEtage, sonAdresse, saDateCreation, saDateDernModif, laVille, laCategProd);
            return ZoneStockageDAO.GetInstance().AjoutZoneStockage(laZoneStockage);
        }

    }
}
