using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockDAL;
using ControleStockBO;

namespace ControleStockBLL
{
    public class VilleManager
    {
        private static VilleManager uneVilleManager;
        // PATERN SINGLETON
        public static VilleManager GetInstance()
        {
            if (uneVilleManager == null)
            {
                uneVilleManager = new VilleManager();
            }
            return uneVilleManager;
        }
        private VilleManager()
        {

        }

        public List<Ville> GetLesVilles()
        {
            return VilleDAO.GetInstance().GetLesVilles();
        }
    }
    
}
