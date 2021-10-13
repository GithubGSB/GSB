using ControleStockBO;
using ControleStockDAL;
using System.Collections.Generic;

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
        //
        public List<TypeControle> GetLesTypeControles()
        {
            return TypeControleDAO.GetInstance().GetLesTypeControles();
        }
    }
}