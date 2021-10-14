using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockBO;
using ControleStockDAL;

namespace ControleStockBLL
{
    public class ControleRealiseManager
    {
        private static ControleRealiseManager instance;
        private List<ControleRealise> lesControlesRealises;

        private ControleRealiseManager() { }

        public static ControleRealiseManager GetInstance()
        {
            if (instance == null) instance = new ControleRealiseManager();
            return instance;
        }

        public int AjoutControle(DateTime dateControle, DateTime dateCreation, DateTime dateDerniereModif, string resume,
            float montantHT, int idTypeControle, int idEntreprise, int idZoneStockage)
        {
            TypeControle unTypeControle = new TypeControle(idTypeControle);
            Entreprise uneEntreprise = new Entreprise(idEntreprise);
            ZoneStockage uneZoneStockage = new ZoneStockage(idZoneStockage);

            return ControleRealiseDAO.GetInstance().AjoutControle(new ControleRealise(dateControle, dateCreation, dateDerniereModif, resume, montantHT, unTypeControle, uneEntreprise, uneZoneStockage));
        }
    }
}