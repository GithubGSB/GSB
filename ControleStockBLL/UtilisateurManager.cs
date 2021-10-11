using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBLL
{
    /// <summary>
    /// Classe permettant la gestion des utilisateurs
    /// </summary>
    public class UtilisateurManager
    {
        private static UtilisateurManager uneInstance;
        /// <summary>
        /// Premet de récupéré l'instance UtilisateurManager
        /// </summary>
        /// <returns>Instance de UtilisateurManager</returns>
        public static UtilisateurManager GetInstance()
        {
            if (uneInstance == null) uneInstance = new UtilisateurManager();
            return uneInstance;
        }
        private UtilisateurManager() { }
    }
}
