using ControleStockBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    public class TypeControleDAO
    {
        private static TypeControleDAO instance;
        private List<TypeControle> lesTypeControles = new List<TypeControle>();

        private TypeControleDAO() { }

        public static TypeControleDAO GetInstance()
        {
            if (instance == null) instance = new TypeControleDAO();
            return instance;
        }

        public List<TypeControle> GetLesTypeControles()
        {
            int id;
            string libelle;
            List<TypeControle> typeControles = new List<TypeControle>();

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spGetTypeControles";

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
                typeControles.Add(new TypeControle(id, libelle));
            }
            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();
            return typeControles;
        }

        //public int AjoutTypeControle(TypeControle unTypeControle)
        //{
        //    SqlCommand commande = Commande.GetInstance().GetObjCommande();
        //    commande.Parameters.Clear();
        //    // TODO -> Procédure stockée

        //    int nb = commande.ExecuteNonQuery();
        //    commande.Connection.Close();
        //    return nb;
        //}
    }
}