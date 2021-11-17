using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockBO;
using ControleStockDAL;

namespace ControleStockBLL
{
    public class StructureZoneManager
    {
        private static StructureZoneManager uneStructureZoneManager;
        // PATERN SINGLETON
        /// <summary>
        /// Créer l'instance de StructureZoneManager
        /// </summary>
        /// <returns>uneStructureZoneManager</returns>
        public static StructureZoneManager GetInstance()
        {
            if (uneStructureZoneManager == null)
            {
                uneStructureZoneManager = new StructureZoneManager();
            }
            return uneStructureZoneManager;
        }
        private StructureZoneManager()
        {

        }
        public List<StructureZone> GetLesStructuresZones()
        {
            return StructureZoneDAO.GetInstance().GetLesStructuresZones();
        }



    }
}
