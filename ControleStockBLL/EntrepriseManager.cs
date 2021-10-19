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
            if(uneInstance == null)
            {
                uneInstance = new EntrepriseManager();
            }
            return uneInstance;
        }


        /// <summary>
        /// methode qui permet la création une entreprise et retourne une methode de la couche DAO pour AjoutEntreprise de BD
        /// </summary>
        /// <param name="leNom"></param>
        /// <param name="LAdresse"></param>
        /// <param name="lEmail"></param>
        /// <param name="dateCreation"></param>
        /// <param name="dateDerniereModif"></param>
        /// <param name="sonIdVille"></param>
        /// <returns></returns>
        public int CreerEntreprise(string leNom, string LAdresse, string lEmail, DateTime dateCreation, DateTime dateDerniereModif, int sonIdVille)
        {
            Entreprise uneEntreprise;
            Ville laVille;
            laVille = new Ville(sonIdVille);
            uneEntreprise = new Entreprise(leNom, LAdresse, lEmail, dateCreation, dateDerniereModif, laVille);
            return EntrepriseDAO.GetInstance().AjoutEntreprise(uneEntreprise);
        }




    }
}
