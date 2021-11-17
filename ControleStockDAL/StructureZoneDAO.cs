using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockBO;
using ControleStockDAL;



namespace ControleStockDAL
{
    public class StructureZoneDAO
    {
        /// <summary>
        /// Générer une instance de CategProdDAO
        /// </summary>
        private static StructureZoneDAO uneInstance;
        // PATERN SINGLETON
        public static StructureZoneDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new StructureZoneDAO();
            }
            return uneInstance;
        }
        private StructureZoneDAO()
        {

        }
        /// <summary>
        /// Retourne les catégories de produit via une procédure stockée. Il cherchera l'ensemble des catégories de produit de la BD. 

        /// </summary>
        /// <returns> retourne collections CategProd</returns>
        public List<StructureZone> GetLesStructuresZones()
        {
            int id;
            string libelle;
            List<StructureZone> lesStructuresZones = new List<StructureZone>();

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spConsultStructureZone";

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
                lesStructuresZones.Add(new StructureZone(id, libelle));
            }
            monLecteur.Close();
            commande.Connection.Close();
            return lesStructuresZones;
        }
    }
}
