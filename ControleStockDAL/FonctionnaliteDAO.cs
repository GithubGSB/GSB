using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    /// <summary>
    /// Classe permettant l'accès aux données relatif au fonctionnalité
    /// </summary>
    public class FonctionnaliteDAO
    {
        private static FonctionnaliteDAO uneInstance;
        /// <summary>
        /// Premet de récupéré l'instance FonctionnaliteDAO
        /// </summary>
        /// <returns>Instance de FonctionnaliteDAO</returns>
        public static FonctionnaliteDAO GetInstance()
        {
            if (uneInstance == null) uneInstance = new FonctionnaliteDAO();
            return uneInstance;
        }
        private FonctionnaliteDAO() { }
    }
}
