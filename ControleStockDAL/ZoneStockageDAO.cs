using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ControleStockBO;



namespace ControleStockDAL
{
    public class ZoneStockageDAO
    {
        private static ZoneStockageDAO uneInstance;
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
        public int AjoutZoneStockage(ZoneStockage uneZoneStockage)
        {
            
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            commande.CommandText; //PROCEDURE STOCKEE

            commande.Parameters.Add("parNomZone", System.Data.SqlDbType.VarChar);
            commande.Parameters["parNomZone"].Value = uneZoneStockage.NomZone;

            commande.Parameters.Add("parBatiment", System.Data.SqlDbType.VarChar);
            commande.Parameters["parBatiment"].Value = uneZoneStockage.Batiment;

            commande.Parameters.Add("parEtage", System.Data.SqlDbType.VarChar);
            commande.Parameters["parEtage"].Value = uneZoneStockage.Etage;

            commande.Parameters.Add("parDateCreation", System.Data.SqlDbType.DateTime);
            commande.Parameters["parDateCreation"].Value = uneZoneStockage.DateCreation;

            commande.Parameters.Add("parDateDernModif", System.Data.SqlDbType.DateTime);
            commande.Parameters["parDateDernModif"].Value = uneZoneStockage.DateDernModif;

            commande.Parameters.Add("parAdresse", System.Data.SqlDbType.VarChar);
            commande.Parameters["parAdresse"].Value = uneZoneStockage.Adresse;

            commande.Parameters.Add("parIdVille", System.Data.SqlDbType.Int);
            commande.Parameters["parIdVille"].Value = uneZoneStockage.UneVille.Id;

            commande.Parameters.Add("parIdCategProd", System.Data.SqlDbType.Int);
            commande.Parameters["parIdCategProd"].Value = uneZoneStockage.UneCategProd.Id;

            int nb = commande.ExecuteNonQuery();
            commande.Connection.Close();
        }

    }
}
