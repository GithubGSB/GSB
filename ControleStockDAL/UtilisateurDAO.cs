using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    // <summary>
    /// Classe permettant l'accès aux données relatif à l'utilisateur
    /// </summary>
    public class UtilisateurDAO
    {
        private static UtilisateurDAO uneInstance;
        /// <summary>
        /// Premet de récupéré l'instance UtilisateurDAO
        /// </summary>
        /// <returns>Instance de UtilisateurDAO</returns>
        public static UtilisateurDAO GetInstance()
        {
            if (uneInstance == null) uneInstance = new UtilisateurDAO();
            return uneInstance;
        }
    }
}
