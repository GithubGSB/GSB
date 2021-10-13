using ControleStockBO;
using ControleStockDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBLL
{
    public class TypeControleManager
    {
        private static TypeControleManager instance;

        private TypeControleManager() { }
        
        public static TypeControleManager GetInstance()
        {
            if (instance == null) instance = new TypeControleManager();
            return instance;
        }

        public List<TypeControle> GetLesTypeControles()
        {
            return TypeControleDAO.GetInstance().GetLesTypeControles();
        }
    }
}
