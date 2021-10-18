using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ControleStockBO;
using System.Data;

namespace ControleStockDAL
{
    /// <summary>
    /// DAL de ZoneStockage
    /// </summary>
    public class ZoneStockageDAO
    {
        private static ZoneStockageDAO uneInstance;
        /// <summary>
        /// Permet de récupérer l'instance de ZoneStockage
        /// </summary>
        /// <returns>Instance de ZoneStockage</returns>
        public static ZoneStockageDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ZoneStockageDAO();
            }
            return uneInstance;
        }
        private ZoneStockageDAO()
        {

        }
        /// <summary>
        /// Ajout d'une zone de stockage dans la BD via une procédure stockée. On ouvre l'accès au donnée avec l'objet Commande
        /// en appelant une instance de Commande.
        /// </summary>
        /// <param name="uneZoneStockage"></param>
        /// <returns>Un objet de ZoneStockage avec tous les arguments sans l'id</returns>
        public int AjoutZoneStockage(ZoneStockage uneZoneStockage)
        {
            // Ouverture de l'accès à la BD
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            // Indique l'appel de la procédure stockée
            commande.CommandType = CommandType.StoredProcedure;
            // Appel de la procédure
            commande.CommandText = "spAjoutZoneStockage";
            
            commande.Parameters.Add("nomZone", System.Data.SqlDbType.VarChar);
            commande.Parameters["nomZone"].Value = uneZoneStockage.NomZone;

            commande.Parameters.Add("batiment", System.Data.SqlDbType.VarChar);
            commande.Parameters["batiment"].Value = uneZoneStockage.Batiment;

            commande.Parameters.Add("etage", System.Data.SqlDbType.VarChar);
            commande.Parameters["etage"].Value = uneZoneStockage.Etage;

            commande.Parameters.Add("dateCreation", System.Data.SqlDbType.DateTime);
            commande.Parameters["dateCreation"].Value = uneZoneStockage.DateCreation;

            commande.Parameters.Add("dateDerniereModif", System.Data.SqlDbType.DateTime);
            commande.Parameters["dateDerniereModif"].Value = uneZoneStockage.DateDernModif;

            commande.Parameters.Add("adresse", System.Data.SqlDbType.VarChar);
            commande.Parameters["adresse"].Value = uneZoneStockage.Adresse;

            commande.Parameters.Add("insee", System.Data.SqlDbType.Int);
            commande.Parameters["insee"].Value = uneZoneStockage.UneVille.Insee;

            commande.Parameters.Add("idCategProduit", System.Data.SqlDbType.Int);
            commande.Parameters["idCategProduit"].Value = uneZoneStockage.UneCategProd.Id;
            
            int nb = commande.ExecuteNonQuery();
            //fermeture de l'accès à la BD
            commande.Connection.Close();
            return nb; 
        }

    }
}
