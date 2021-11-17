using ControleStockBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    public class ControleRealiseDAO
    {
        private static ControleRealiseDAO instance;
        private ControleRealiseDAO() { }

        public static ControleRealiseDAO GetInstance()
        {
            if (instance == null) instance = new ControleRealiseDAO();
            return instance;
        }


        public int AjoutControle(ControleRealise unControle)
        {
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spAjoutControleRealise";

            commande.Parameters.Add("dateControle", System.Data.SqlDbType.Date);
            commande.Parameters["dateControle"].Value = unControle.DateControle;

            commande.Parameters.Add("resume", System.Data.SqlDbType.VarChar);
            commande.Parameters["resume"].Value = unControle.Resume;

            commande.Parameters.Add("montantHT", System.Data.SqlDbType.Float);
            commande.Parameters["montantHT"].Value = unControle.MontantHT;

            commande.Parameters.Add("dateCreation", System.Data.SqlDbType.Date);
            commande.Parameters["dateCreation"].Value = unControle.DateCreation;

            commande.Parameters.Add("dateDerniereModif", System.Data.SqlDbType.Date);
            commande.Parameters["dateDerniereModif"].Value = unControle.DateDerniereModif;

            commande.Parameters.Add("idTypeControle", System.Data.SqlDbType.Int);
            commande.Parameters["idTypeControle"].Value = unControle.UnTypeControle.Id;

            commande.Parameters.Add("idEntreprise", System.Data.SqlDbType.Int);
            commande.Parameters["idEntreprise"].Value = unControle.UneEntreprise.Id;

            commande.Parameters.Add("idZoneStockage", System.Data.SqlDbType.Int);
            commande.Parameters["idZoneStockage"].Value = unControle.UneZoneStockage.Id;

            int nb = commande.ExecuteNonQuery();
            commande.Connection.Close();
            return nb;
        }

        public List<ControleRealise> GetLesControlesRealises()
        {
            int id;
            DateTime dateControle;
            string resume;
            float montantHT;
            DateTime dateCreation;
            DateTime dateDerniereModif;
            int idEntreprise;
            int idZoneStockage;
            int idTypeControle;

            string libelleTypeControle;
            string nomZone;
            string nomEntreprise;
            List<ControleRealise> lesControles = new List<ControleRealise>();
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spConsultLesControles";

            SqlDataReader monLecteur = commande.ExecuteReader();

            while(monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                idEntreprise = (int)monLecteur["idEntreprise"];
                idZoneStockage = (int)monLecteur["idZoneStockage"];
                idTypeControle = (int)monLecteur["idTypeControle"];
                
                if(monLecteur["dateControle"] == DBNull.Value)
                {
                    dateControle = default(DateTime);
                }
                else
                {
                    dateControle = (DateTime)monLecteur["dateControle"];
                }
                if (monLecteur["resume"] == DBNull.Value)
                {
                    resume = default(string);
                }
                else
                {
                    resume = monLecteur["resume"].ToString();
                }
                if (monLecteur["montantHT"] == DBNull.Value)
                {
                    montantHT = default(float);
                }
                else
                {
                    montantHT = float.Parse(monLecteur["montantHT"].ToString());
                }
                if (monLecteur["dateCreation"] == DBNull.Value)
                {
                    dateCreation = default(DateTime);
                }
                else
                {
                    dateCreation = (DateTime)monLecteur["dateControle"];
                }
                if (monLecteur["dateDerniereModif"] == DBNull.Value)
                {
                    dateDerniereModif = default(DateTime);
                }
                else
                {
                    dateDerniereModif = (DateTime)monLecteur["dateControle"];
                }
                if(monLecteur["libelle"] == DBNull.Value)
                {
                    libelleTypeControle = default(string);
                }
                else
                {
                    libelleTypeControle = monLecteur["libelle"].ToString();
                }
                if (monLecteur["nom"] == DBNull.Value)
                {
                    nomEntreprise = default(string);
                }
                else
                {
                    nomEntreprise = monLecteur["nom"].ToString();

                }
                if (monLecteur["nomZone"] == DBNull.Value)
                {
                    nomZone = default(string);
                }
                else
                {
                    nomZone = monLecteur["nomZone"].ToString();
                }
                
                lesControles.Add(new ControleRealise(id, dateControle, dateCreation, dateDerniereModif, resume, montantHT, 
                    new TypeControle(idTypeControle, libelleTypeControle), 
                    new Entreprise(idEntreprise, nomEntreprise), 
                    new ZoneStockage(idZoneStockage, nomZone)));
            }
            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();
            return lesControles;
        }

        public int ModifControle(ControleRealise unControle)
        {
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spModifControle";

            commande.Parameters.Add("id", System.Data.SqlDbType.Int);
            commande.Parameters["id"].Value = unControle.Id;

            commande.Parameters.Add("dateControle", System.Data.SqlDbType.Date);
            commande.Parameters["dateControle"].Value = unControle.DateControle;

            commande.Parameters.Add("resume", System.Data.SqlDbType.VarChar);
            commande.Parameters["resume"].Value = unControle.Resume;

            commande.Parameters.Add("montantHT", System.Data.SqlDbType.Float);
            commande.Parameters["montantHT"].Value = unControle.MontantHT;

            commande.Parameters.Add("dateCreation", System.Data.SqlDbType.Date);
            commande.Parameters["dateCreation"].Value = unControle.DateCreation;

            commande.Parameters.Add("dateDerniereModif", System.Data.SqlDbType.Date);
            commande.Parameters["dateDerniereModif"].Value = unControle.DateDerniereModif;

            commande.Parameters.Add("idTypeControle", System.Data.SqlDbType.Int);
            commande.Parameters["idTypeControle"].Value = unControle.UnTypeControle.Id;

            commande.Parameters.Add("idEntreprise", System.Data.SqlDbType.Int);
            commande.Parameters["idEntreprise"].Value = unControle.UneEntreprise.Id;

            commande.Parameters.Add("idZoneStockage", System.Data.SqlDbType.Int);
            commande.Parameters["idZoneStockage"].Value = unControle.UneZoneStockage.Id;

            int nb = commande.ExecuteNonQuery();
            commande.Connection.Close();
            return nb;

        }

        public ControleRealise RecupererControle(int id)
        {
            DateTime dateControle;
            string resume;
            float montantHT;
            DateTime dateCreation;
            DateTime dateDerniereModif;
            int idEntreprise;
            int idZoneStockage;
            int idTypeControle;

            string libelleTypeControle;
            string nomZone;
            string nomEntreprise;

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spConsultLesControles";
            commande.Parameters.Add("id", System.Data.SqlDbType.Int);
            commande.Parameters["id"].Value = id;
            SqlDataReader monLecteur = commande.ExecuteReader();
            monLecteur.Read();
            id = (int)monLecteur["id"];
            idEntreprise = (int)monLecteur["idEntreprise"];
            idZoneStockage = (int)monLecteur["idZoneStockage"];
            idTypeControle = (int)monLecteur["idTypeControle"];
            if (monLecteur["dateControle"] == DBNull.Value)
            {
                dateControle = default(DateTime);
            }
            else
            {
                dateControle = (DateTime)monLecteur["dateControle"];
            }
            if (monLecteur["resume"] == DBNull.Value)
            {
                resume = default(string);
            }
            else
            {
                resume = monLecteur["resume"].ToString();
            }
            if (monLecteur["montantHT"] == DBNull.Value)
            {
                montantHT = default(float);
            }
            else
            {
                montantHT = float.Parse(monLecteur["montantHT"].ToString());
            }
            if (monLecteur["dateCreation"] == DBNull.Value)
            {
                dateCreation = default(DateTime);
            }
            else
            {
                dateCreation = (DateTime)monLecteur["dateControle"];
            }
            if (monLecteur["dateDerniereModif"] == DBNull.Value)
            {
                dateDerniereModif = default(DateTime);
            }
            else
            {
                dateDerniereModif = (DateTime)monLecteur["dateControle"];
            }
            if (monLecteur["libelle"] == DBNull.Value)
            {
                libelleTypeControle = default(string);
            }
            else
            {
                libelleTypeControle = monLecteur["libelle"].ToString();
            }
            if (monLecteur["nom"] == DBNull.Value)
            {
                nomEntreprise = default(string);
            }
            else
            {
                nomEntreprise = monLecteur["nom"].ToString();
            }
            if (monLecteur["nomZone"] == DBNull.Value)
            {
                nomZone = default(string);
            }
            else
            {
                nomZone = monLecteur["nomZone"].ToString();
            }
            commande.Connection.Close();
            return new ControleRealise(id, dateControle, dateCreation, dateDerniereModif, resume, montantHT, 
                new TypeControle(idTypeControle, libelleTypeControle), new Entreprise(id, nomEntreprise), 
                new ZoneStockage(id, nomZone));
        }

        public ControleRealise RecupererTousLesControles(int id)
        {
            DateTime dateControle;
            string resume;
            float montantHT;
            DateTime dateCreation;
            DateTime dateDerniereModif;
            int idEntreprise;
            int idZoneStockage;
            int idTypeControle;

            string libelleTypeControle;
            string nomZone;
            string nomEntreprise;

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spConsultTousLesControles";
            commande.Parameters.Add("id", System.Data.SqlDbType.Int);
            commande.Parameters["id"].Value = id;
            SqlDataReader monLecteur = commande.ExecuteReader();
            monLecteur.Read();
            id = (int)monLecteur["id"];
            idEntreprise = (int)monLecteur["idEntreprise"];
            idZoneStockage = (int)monLecteur["idZoneStockage"];
            idTypeControle = (int)monLecteur["idTypeControle"];
            if (monLecteur["dateControle"] == DBNull.Value)
            {
                dateControle = default(DateTime);
            }
            else
            {
                dateControle = (DateTime)monLecteur["dateControle"];
            }
            if (monLecteur["resume"] == DBNull.Value)
            {
                resume = default(string);
            }
            else
            {
                resume = monLecteur["resume"].ToString();
            }
            if (monLecteur["montantHT"] == DBNull.Value)
            {
                montantHT = default(float);
            }
            else
            {
                montantHT = float.Parse(monLecteur["montantHT"].ToString());
            }
            if (monLecteur["dateCreation"] == DBNull.Value)
            {
                dateCreation = default(DateTime);
            }
            else
            {
                dateCreation = (DateTime)monLecteur["dateControle"];
            }
            if (monLecteur["dateDerniereModif"] == DBNull.Value)
            {
                dateDerniereModif = default(DateTime);
            }
            else
            {
                dateDerniereModif = (DateTime)monLecteur["dateControle"];
            }
            if (monLecteur["libelle"] == DBNull.Value)
            {
                libelleTypeControle = default(string);
            }
            else
            {
                libelleTypeControle = monLecteur["libelle"].ToString();
            }
            if (monLecteur["nom"] == DBNull.Value)
            {
                nomEntreprise = default(string);
            }
            else
            {
                nomEntreprise = monLecteur["nom"].ToString();
            }
            if (monLecteur["nomZone"] == DBNull.Value)
            {
                nomZone = default(string);
            }
            else
            {
                nomZone = monLecteur["nomZone"].ToString();
            }
            commande.Connection.Close();
            return new ControleRealise(id, dateControle, dateCreation, dateDerniereModif, resume, montantHT,
                new TypeControle(idTypeControle, libelleTypeControle), new Entreprise(id, nomEntreprise),
                new ZoneStockage(id, nomZone));
        }
    }
}