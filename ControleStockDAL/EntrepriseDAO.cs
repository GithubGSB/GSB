using ControleStockBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    public class EntrepriseDAO
    {
        private static EntrepriseDAO uneInstance;


        public static EntrepriseDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EntrepriseDAO();
            }
            return uneInstance;
        }

        private EntrepriseDAO()
        {
        }

     
        public List<Entreprise> GetLesEntreprises()
        {
            int id;
            string nom;
            string adresse;
            string email;
            DateTime dateCreation;
            DateTime dateDerniereModif;
            string insee;
            List<Entreprise> lesEntreprises = new List<Entreprise>();

            SqlCommand commande = Commande.GetInstance().GetObjCommande();

            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spGetLesEntreprises";

            SqlDataReader monLecteur = commande.ExecuteReader();

            while(monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                if(monLecteur["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monLecteur["nom"].ToString();
                }

                if (monLecteur["adresse"] == DBNull.Value)
                {
                    adresse = default(string);
                }
                else
                {
                    adresse = monLecteur["adresse"].ToString();
                }

                if (monLecteur["email"] == DBNull.Value)
                {
                    email = default(string);
                }
                else
                {
                    email = monLecteur["email"].ToString();
                }

                if (monLecteur["dateCreation"] == DBNull.Value)
                {
                    dateCreation = default(DateTime);
                }
                else
                {
                    dateCreation = (DateTime) monLecteur["dateCreation"];
                }

                if (monLecteur["dateDerniereModif"] == DBNull.Value)
                {
                    dateDerniereModif = default(DateTime);
                }
                else
                {
                    dateDerniereModif = (DateTime)monLecteur["dateDerniereModif"];
                }

                if (monLecteur["insee"] == DBNull.Value)
                {
                    insee = default(string);
                }
                else
                {
                    insee = monLecteur["insee"].ToString();
                }
                lesEntreprises.Add(new Entreprise(id, nom, adresse, email, dateCreation, dateDerniereModif, insee));
            }
            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();
            return lesEntreprises;



        }
        public int AjoutEntreprise(Entreprise unEntreprise)
        {
            Commande.GetInstance().GetObjCommande();

            int nbEnregistrements = 0;
            SqlCommand commande;

            commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = ("spAjoutEntreprise ");
            

            commande.Parameters.Add("nom",System.Data.SqlDbType.VarChar);
            commande.Parameters.Add("adresse", System.Data.SqlDbType.VarChar);
            commande.Parameters.Add("email", System.Data.SqlDbType.VarChar);
            commande.Parameters.Add("dateCreation", System.Data.SqlDbType.DateTime);
            commande.Parameters.Add("dateDerniereModif", System.Data.SqlDbType.DateTime);
            commande.Parameters.Add("insee", System.Data.SqlDbType.Char);

            commande.Parameters[0].Value = unEntreprise.Nom;
            commande.Parameters[0].Value = unEntreprise.Adresse;
            commande.Parameters[0].Value = unEntreprise.Email;
            commande.Parameters[0].Value = unEntreprise.DateCreation;
            commande.Parameters[0].Value = unEntreprise.DateDerniereModif;
            commande.Parameters[0].Value = unEntreprise.Insee;



            nbEnregistrements = commande.ExecuteNonQuery();

            Commande.GetInstance().FermerConnexion();
            return nbEnregistrements;
        }
    }
}
