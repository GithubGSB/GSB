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
            
            string nomZone;
            string adresse;
            string chn;
            string batiment;
            string etage;

            string libelleCateg;
            string nomVille;

            List<ZoneStockage> lesZonesStockages = new List<ZoneStockage>();

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.CommandType = CommandType.StoredProcedure;
            commande.CommandText = "spConsultZonesStockages";

            SqlDataReader monLecteur = commande.ExecuteReader();
            while (monLecteur.Read())
            {
                chn = monLecteur["idZone"].ToString();
                int.TryParse(chn, out id);
                chn = monLecteur["idCateg"].ToString();
                int.TryParse(chn, out idCategProd);
                chn = monLecteur["inseeVille"].ToString();
                int.TryParse(chn, out idVille);

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
                
                if (monLecteur["nomVille"]==DBNull.Value)
                {
                    nomVille = default(string);
                }
                else
                {
                    nomVille = monLecteur["nomVille"].ToString();
                }               
                if (monLecteur["libelleCateg"] ==DBNull.Value)
                {
                    libelleCateg = default(string);
                }
                else
                {
                    libelleCateg = monLecteur["libelleCateg"].ToString();
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
                CategProd laCateg = new CategProd(idCategProd, libelleCateg);
                Ville uneVille = new Ville(idVille, nomVille);
                lesZonesStockages.Add(new ZoneStockage(id, nomZone, uneVille, adresse, batiment, etage, laCateg));
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
        /// <summary>
        /// Permet de modifier une zone de stockage avec un id de la zone transmise 
        /// </summary>
        /// <param name="uneZoneStockage"></param>
        /// <returns></returns>
        public int ModifZoneStockage(ZoneStockage uneZoneStockage)
        {
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            // Indique l'appel de la procédure stockée
            commande.CommandType = CommandType.StoredProcedure;
            // Appel de la procédure
            commande.CommandText = "spModifZoneStockage";

            commande.Parameters.Add("id", System.Data.SqlDbType.Int);
            commande.Parameters["id"].Value = uneZoneStockage.Id;

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
        /// <summary>
        ///  Permet d'obtenir une zone de stockage par rapport à son id, retourne la zone de stockage avec l'id de la Categorie et l'id de la Ville
        /// </summary>
        /// <param name="sonId"></param>
        /// <returns></returns>
        public ZoneStockage GetLaZoneStockage(int sonId)
        {
            string nomZone;
            string batiment;
            string etage;
            string adresse;
            int idVille;
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
            idCateg = (int)monLecteur["idCategProduit"];
            idVille = (int)monLecteur["insee"];

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
           

            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();

            return new ZoneStockage(sonId, nomZone, new Ville(idVille), adresse, batiment, etage, new CategProd(idCateg)) ; 
        }
        /// <summary>
        /// Permet de visualiser la zone de stockage avant sa suppression
        /// </summary>
        /// <param name="sonId"></param>
        /// <returns> la zone de stockage à supprimer </returns>
        public ZoneStockage GetLaZoneStockageASuppr(int sonId)
        {
            string nomZone;
            string batiment;
            string etage;
            string adresse;
            int idVille;
            int idCateg;
            string nomVille;
            string libelleCateg;

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
            idCateg = (int)monLecteur["idCategProduit"];
            idVille = (int)monLecteur["insee"];

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
                etage = default(string);
            }
            else
            {
                etage = monLecteur["etage"].ToString();
            }
            if (monLecteur["nomVille"] == DBNull.Value)
            {
                nomVille = default(string);
            }
            else
            {
                nomVille = monLecteur["nomVille"].ToString();
            }
            if (monLecteur["libelleCateg"] == DBNull.Value)
            {
                libelleCateg = default(string);
            }
            else
            {
                libelleCateg = monLecteur["libelleCateg"].ToString();
            }


            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();

            return new ZoneStockage(sonId, nomZone, new Ville(idVille, nomVille), adresse, batiment, etage, new CategProd(idCateg, libelleCateg));
        }
        /// <summary>
        /// Permet d'obtenir une zone de stockage par rapport à un id avec le libelle de la categorie et le nom de la ville
        /// </summary>
        /// <param name="sonId"></param>
        /// <returns></returns>
        public List<ZoneStockage> ConsultZoneASupprimer(int sonId)
        {
            int id;
            int idCategProd;
            int idVille;

            string nomZone;
            string adresse;
            string chn;
            string batiment;
            string etage;

            string libelleCateg;
            string nomVille;

            List<ZoneStockage> lesZonesStockagesASuppr = new List<ZoneStockage>();

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.CommandType = CommandType.StoredProcedure;
            commande.CommandText = "spConsultZonesASuppr";

            commande.Parameters.Add("id", System.Data.SqlDbType.Int);
            commande.Parameters["id"].Value = sonId;

            SqlDataReader monLecteur = commande.ExecuteReader();
            while (monLecteur.Read())
            {
                chn = monLecteur["idZone"].ToString();
                int.TryParse(chn, out id);
                chn = monLecteur["idCateg"].ToString();
                int.TryParse(chn, out idCategProd);
                chn = monLecteur["inseeVille"].ToString();
                int.TryParse(chn, out idVille);

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

                if (monLecteur["nomVille"] == DBNull.Value)
                {
                    nomVille = default(string);
                }
                else
                {
                    nomVille = monLecteur["nomVille"].ToString();
                }
                if (monLecteur["libelleCateg"] == DBNull.Value)
                {
                    libelleCateg = default(string);
                }
                else
                {
                    libelleCateg = monLecteur["libelleCateg"].ToString();
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
                CategProd laCateg = new CategProd(idCategProd, libelleCateg);
                Ville uneVille = new Ville(idVille, nomVille);
                lesZonesStockagesASuppr.Add(new ZoneStockage(id, nomZone, uneVille, adresse, batiment, etage, laCateg));
            }
            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();
            return lesZonesStockagesASuppr;
        }

        /// <summary>
        /// Procédure qui permet de supprimé une zone de stockage
        /// </summary>
        /// <param name="sonId"></param>
        /// <returns></returns>
        public int SupprZoneStockage(int sonId)
        {
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            // Indique l'appel de la procédure stockée
            commande.CommandType = CommandType.StoredProcedure;
            // Appel de la procédure
            commande.CommandText = "spSupprZoneStockage";

            commande.Parameters.Add("id", System.Data.SqlDbType.Int);
            commande.Parameters["id"].Value = sonId;

            int nb = commande.ExecuteNonQuery();
            //fermeture de l'accès à la BD
            commande.Connection.Close();
            return nb;
        }

        //supprZoneStockage procédure : spSupprZoneStockage


    }
}