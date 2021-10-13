using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    /// <summary>
    /// Contient un objet commande, qui permet d'effectué des requêtes de type procédure stocké sur la BD __nomBD
    /// </summary>
    public class Commande
    {
        private SqlCommand objCommande;

        private static Commande uneInstance;
        /// <summary>
        /// Permet de récupéré l'instance de Commande
        /// </summary>
        /// <returns>instance de Commande</returns>
        public static Commande GetInstance()
        {
            if (uneInstance == null) uneInstance = new Commande();
            return uneInstance;
        }
         private Commande()
        {
            SqlConnection objConnex = new SqlConnection();
            objConnex.ConnectionString = ConfigurationManager.ConnectionStrings["GSBControleStockage"].ConnectionString; //a completé
            objCommande = objConnex.CreateCommand();
            objCommande.CommandType = System.Data.CommandType.StoredProcedure;
        }

        /// <summary>
        /// Ouverture d'une commande du la BD
        /// </summary>
        /// <returns>Objet responsable de la commande, ou null si impossible d'ouvrir une connexion</returns>
        public SqlCommand GetObjCommande()
        {
            try
            {
                if (objCommande.Connection.State == System.Data.ConnectionState.Closed) objCommande.Connection.Open();
                objCommande.Parameters.Clear();
                return objCommande;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Fermeture de la connexion si elle est ouverte
        /// </summary>
        public void FermerConnexion()
        {
            if (objCommande.Connection != null && objCommande.Connection.State != System.Data.ConnectionState.Closed) objCommande.Connection.Close();
        }
    }
}
