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

        public List<ZoneStockage> GetLesZonesStockages()
        {
            int id;
            string nomZone;

            List<ZoneStockage> lesZonesStockages = new List<ZoneStockage>();

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.CommandType = CommandType.StoredProcedure;
            commande.CommandText = "spGetLesZonesStockages";

            SqlDataReader monLecteur = commande.ExecuteReader();
            while(monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                if(monLecteur["nomZone"] == DBNull.Value)
                {
                    nomZone = default(string);
                }
                else
                {
                    nomZone = monLecteur["nomZone"].ToString();
                }
                lesZonesStockages.Add(new ZoneStockage(id, nomZone)) ;
            }
            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();
            return lesZonesStockages;
        }
        private ZoneStockageDAO(){}
        public int AjoutZoneStockage(ZoneStockage uneZoneStockage)
        {

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

            commande.Parameters.Add("insee", System.Data.SqlDbType.Char);
            commande.Parameters["insee"].Value = uneZoneStockage.UneVille.Insee;

            commande.Parameters.Add("idCategProduit", System.Data.SqlDbType.Int);
            commande.Parameters["idCategProduit"].Value = uneZoneStockage.UneCategProd.Id;

            int nb = commande.ExecuteNonQuery();
            commande.Connection.Close();
            return nb;
        }

    }
}