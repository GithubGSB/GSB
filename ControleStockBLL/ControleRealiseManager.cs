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
        /// <summary>
        /// Méthode qui appelle une méthode de la couche DAO pour ajouter un nouveau controle dans la BD
        /// </summary>
        /// <param name="dateControle"></param>
        /// <param name="dateCreation"></param>
        /// <param name="dateDerniereModif"></param>
        /// <param name="resume"></param>
        /// <param name="montantHT"></param>
        /// <param name="idTypeControle"></param>
        /// <param name="idEntreprise"></param>
        /// <param name="idZoneStockage"></param>
        /// <returns> Retourne le nb d'enregistrement ajouter </returns>
        public int AjoutControle(DateTime dateControle, DateTime dateCreation, DateTime dateDerniereModif, string resume,
            float montantHT, int idTypeControle, int idEntreprise, int idZoneStockage)
        {
            TypeControle unTypeControle = new TypeControle(idTypeControle);
            Entreprise uneEntreprise = new Entreprise(idEntreprise);
            ZoneStockage uneZoneStockage = new ZoneStockage(idZoneStockage);

            return ControleRealiseDAO.GetInstance().AjoutControle(new ControleRealise(dateControle, dateCreation, dateDerniereModif, resume, montantHT, unTypeControle, uneEntreprise, uneZoneStockage));
        }

        public List<ControleRealise> GetLesControlesRealises()
        {
            return ControleRealiseDAO.GetInstance().GetLesControlesRealises();
        }

        public int ModifControle(int id, DateTime dateControle, DateTime dateCreation, DateTime dateDerniereModif, string resume,
            float montantHT, int idTypeControle, int idEntreprise, int idZoneStockage)
        {
            TypeControle unTypeControle = new TypeControle(idTypeControle);
            Entreprise uneEntreprise = new Entreprise(idEntreprise);
            ZoneStockage uneZoneStockage = new ZoneStockage(idZoneStockage);
            return ControleRealiseDAO.GetInstance().ModifControle(new ControleRealise(dateControle, dateCreation, dateDerniereModif, resume, montantHT, unTypeControle, uneEntreprise, uneZoneStockage));


        }

        public ControleRealise RecupererControle(int id)
        {
            return ControleRealiseDAO.GetInstance().RecupererControle(id);
        }
    }
}
