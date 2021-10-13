using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockBO;

namespace ControleStockDAL
{
    public class CategProdDAO
    {
        private static CategProdDAO uneInstance;
        // PATERN SINGLETON
        public static CategProdDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CategProdDAO();
            }
            return uneInstance;
        }
        private CategProdDAO()
        {

        }
        public List<CategProd> GetLesCategProds()
        {
            int id;
            string libelle;
            List<CategProd> lesCategProds = new List<CategProd>();

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spConsultCategProds";

            SqlDataReader monLecteur = commande.ExecuteReader();
            while (monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                if (monLecteur["libelle"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monLecteur["libelle"].ToString();
                }
                lesCategProds.Add(new CategProd(id, libelle));
            }
            monLecteur.Close();
            commande.Connection.Close();
            return lesCategProds;
        }

    }
}
