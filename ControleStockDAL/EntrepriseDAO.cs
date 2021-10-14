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
        private List<Entreprise> lesEntreprises;

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
            commande.Parameters.Add("insee", System.Data.SqlDbType.Int);

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
