using ControleStockBO;
using ControleStockDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBLL
{
    public class EntrepriseManager
    {
        private static EntrepriseManager uneInstance;

        public static EntrepriseManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EntrepriseManager();
            }
            return uneInstance;
        }


        public int CreerEntreprise(string leNom, string LAdresse, string lEmail, DateTime dateCreation, DateTime dateDerniereModif, int idVille)
        {
            Entreprise uneEntreprise;
            Ville insee = new Ville(idVille);
            uneEntreprise = new Entreprise(leNom, LAdresse, lEmail, dateCreation, dateDerniereModif, insee);
            return EntrepriseDAO.GetInstance().AjoutEntreprise(uneEntreprise);
        }

        public List<Entreprise> GetLesEntreprises()
        {
            return EntrepriseDAO.GetInstance().GetLesEntreprises();
        }


    }
}