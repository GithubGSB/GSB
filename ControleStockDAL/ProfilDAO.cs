using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    /// <summary>
    /// Classe permettant l'accès aux données relatif au profil
    /// </summary>
    public class ProfilDAO
    {
        private static ProfilDAO uneInstance;
        /// <summary>
        /// Premet de récupéré l'instance ProfilDAO
        /// </summary>
        /// <returns>Instance de profilDAO</returns>
        public static ProfilDAO GetInstance()
        {
            if (uneInstance == null) uneInstance = new ProfilDAO();
            return uneInstance;
        }
    }
}
