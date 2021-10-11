using ControleStockBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    // <summary>
    /// Classe permettant l'accès aux données relatif à l'utilisateur
    /// </summary>
    public class UtilisateurDAO
    {
        private static UtilisateurDAO uneInstance;
        /// <summary>
        /// Premet de récupéré l'instance UtilisateurDAO
        /// </summary>
        /// <returns>Instance de UtilisateurDAO</returns>
        public static UtilisateurDAO GetInstance()
        {
            if (uneInstance == null) uneInstance = new UtilisateurDAO();
            return uneInstance;
        }
        private UtilisateurDAO() { }

        /// <summary>
        /// Permet d'ajouter un utilisateur dans la base de données
        /// </summary>
        /// <param name="nom">nom de l'utilisateur</param>
        /// <param name="prenom">prénom de l'utilisateur</param>
        /// <param name="motDePasse">mot de passe sécurisé de l'utilisateur</param>
        /// <param name="sel">sel de sécurisation du mot du passe</param>
        /// <param name="identifiantConnexion">identifiant de connexion de l'utilisateur</param>
        /// <param name="profil">profil de l'utilisateur</param>
        public void AjoutUtilisateur(string nom, string prenom, SecureString motDePasse, SecureString sel, string identifiantConnexion, Profil profil)
        {
            //récupération commande
            SqlCommand cmd = Commande.GetInstance().GetObjCommande();
            cmd.CommandText = "spAjoutUtilisateur";

            //ajout des paramètres
            cmd.Parameters.Add("nom", System.Data.SqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("prenom", System.Data.SqlDbType.VarChar).Value = prenom;
            cmd.Parameters.Add("motDePasse", System.Data.SqlDbType.VarChar).Value = motDePasse.FromSecureString();
            cmd.Parameters.Add("selMotDePasse", System.Data.SqlDbType.VarChar).Value = sel.FromSecureString();
            cmd.Parameters.Add("identifiantConnexion", System.Data.SqlDbType.VarChar).Value = identifiantConnexion;
            cmd.Parameters.Add("idProfil", System.Data.SqlDbType.Int).Value = profil.Id;

            //récupération des profils
            cmd.ExecuteNonQuery();

            //fermeture de la commande
            Commande.GetInstance().FermerConnexion();
        }
    }
}
