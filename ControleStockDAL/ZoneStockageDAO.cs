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
        public List<ZoneStockage> ConsultZonesStockages()
        {
            int id;
            int idCategProd;
            int idVille;
            
            string nomCateg;
            string nomZone;
            string adresse;
            string batiment;
            string etage;

            string libelle;
            string nomVille;

            List<ZoneStockage> lesZonesStockages = new List<ZoneStockage>();

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.CommandType = CommandType.StoredProcedure;
            commande.CommandText = "spConsultZonesStockages";

            SqlDataReader monLecteur = commande.ExecuteReader();
            while (monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                idCategProd = (int)monLecteur["idCategProduit"];
                idVille = (int)monLecteur["insee"];

                if (monLecteur["nomZone"] == DBNull.Value)
                {
                    nomZone = default(string);
                }
                else
                {
                    nomZone = monLecteur["nomZone"].ToString();
                }
                if (monLecteur["adresse"]== DBNull.Value)
                {
                    adresse = default(string);
                }
                
                else
                {
                    adresse = monLecteur["adresse"].ToString();
                }
                
                if (monLecteur["nom"]==DBNull.Value)
                {
                    nomVille = default(string);
                }
                else
                {
                    nomVille = monLecteur["nom"].ToString();
                }               
                if (monLecteur["libelle"]==DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monLecteur["libelle"].ToString();
                }
                
                if (monLecteur["batiment"] == DBNull.Value)
                {
                    batiment = default(string);
                }
                else
                {
                    batiment = monLecteur["batiment"].ToString();
                }
                if (monLecteur["etage"] == DBNull.Value)
                {
                    etage = default(string);
                }
                else
                {
                    etage = monLecteur["etage"].ToString();
                }
                if (monLecteur["nom"] == DBNull.Value)
                {
                    nomCateg = default(string);
                }
                else
                {
                    nomCateg = monLecteur["nom"].ToString();
                }
                

                CategProd laCateg = new CategProd(idCategProd, libelle);
                Ville laVille = new Ville(idVille, nomVille);
                lesZonesStockages.Add(new ZoneStockage(id, nomZone, laVille, adresse, batiment, etage, laCateg));
            }
            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();
            return lesZonesStockages;
        }
        private ZoneStockageDAO(){}
        /// <summary>
        /// Ajout d'une zone de stockage dans la BD via une procédure stockée. On ouvre l'accès au donnée avec l'objet Commande
        /// en appelant une instance de Commande.
        /// </summary>
        /// <param name="uneZoneStockage"></param>
        /// <returns>Un objet de ZoneStockage avec tous les arguments sans l'id</returns>
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

            commande.Parameters.Add("insee", System.Data.SqlDbType.Int);
            commande.Parameters["insee"].Value = uneZoneStockage.UneVille.Insee;

            commande.Parameters.Add("idCategProduit", System.Data.SqlDbType.Int);
            commande.Parameters["idCategProduit"].Value = uneZoneStockage.UneCategProd.Id;
            
            int nb = commande.ExecuteNonQuery();
            //fermeture de l'accès à la BD
            commande.Connection.Close();
            return nb;
        }
        public int ModifZoneStockage(ZoneStockage uneZoneStockage)
        {
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            // Indique l'appel de la procédure stockée
            commande.CommandType = CommandType.StoredProcedure;
            // Appel de la procédure
            commande.CommandText = "spModifZoneStockage";

            commande.Parameters.Add("nomZone", System.Data.SqlDbType.VarChar);
            commande.Parameters["nomZone"].Value = uneZoneStockage.NomZone;

            commande.Parameters.Add("batiment", System.Data.SqlDbType.VarChar);
            commande.Parameters["batiment"].Value = uneZoneStockage.Batiment;

            commande.Parameters.Add("etage", System.Data.SqlDbType.VarChar);
            commande.Parameters["etage"].Value = uneZoneStockage.Etage;

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
        public ZoneStockage GetLaZoneStockage(int sonId)
        {
            string nomZone;
            string batiment;
            string etage;
            string adresse;
            char idVille;
            int idCateg;
            string nomVille;
            string nomCategProd;

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            // Indique l'appel de la procédure stockée
            commande.CommandType = CommandType.StoredProcedure;
            // Appel de la procédure
            commande.CommandText = "spGetLaZoneStockage";

            commande.Parameters.Add("id", System.Data.SqlDbType.Int);
            commande.Parameters["id"].Value = sonId;

            SqlDataReader monLecteur;
            monLecteur = commande.ExecuteReader();
            monLecteur.Read();
            sonId = (int)monLecteur["id"];
            idCateg = (int)monLecteur["idCategProd"];
            idVille = (char)monLecteur["insee"];

            if (monLecteur["nomZone"] == DBNull.Value)
            {
                nomZone = default(string);
            }
            else
            {
                nomZone = monLecteur["nomZone"].ToString();
            }
            if (monLecteur["adresse"] == DBNull.Value)
            {
                adresse = default(string);
            }
            else
            {
                adresse = monLecteur["adresse"].ToString();
            }
            if (monLecteur["batiment"] == DBNull.Value)
            {
                batiment = default(string);
            }
            else
            {
                batiment = monLecteur["batiment"].ToString();
            }
            if (monLecteur["etage"] == DBNull.Value)
            {
              etage  = default(string);
            }
            else
            {
               etage = monLecteur["etage"].ToString();
            }
            if (monLecteur["nom"] == DBNull.Value)
            {
                nomVille = default(string);
            }
            else
            {
                nomVille = monLecteur["nom"].ToString();
            }
            if (monLecteur["libelle"] == DBNull.Value)
            {
                nomCategProd = default(string);
            }
            else
            {
                nomCategProd = monLecteur["libelle"].ToString();
            }

            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();

            return new ZoneStockage(sonId, nomZone, new Ville(idVille, nomVille), adresse, batiment, etage, new CategProd(idCateg, nomCategProd)) ; 
        }

    }
}