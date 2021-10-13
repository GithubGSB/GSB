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
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="SqlException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void AjoutUtilisateur(Utilisateur utilisateur, string motDePasse, string sel, string identifiantConnexion)
        {
            //récupération commande
            SqlCommand cmd = Commande.GetInstance().GetObjCommande();
            cmd.CommandText = "spAjoutUtilisateur";

            //ajout des paramètres
            cmd.Parameters.Add("nom", System.Data.SqlDbType.VarChar).Value = utilisateur.Nom;
            cmd.Parameters.Add("prenom", System.Data.SqlDbType.VarChar).Value = utilisateur.Prenom;
            cmd.Parameters.Add("motDePasse", System.Data.SqlDbType.VarChar).Value = motDePasse;
            cmd.Parameters.Add("selMotDePasse", System.Data.SqlDbType.VarChar).Value = sel;
            cmd.Parameters.Add("identifiantConnexion", System.Data.SqlDbType.VarChar).Value = identifiantConnexion;
            cmd.Parameters.Add("idProfil", System.Data.SqlDbType.Int).Value = utilisateur.Profil.Id;

            //récupération des profils
            cmd.ExecuteNonQuery();

            //fermeture de la commande
            Commande.GetInstance().FermerConnexion();
        }

        /// <summary>
        /// Permet de vérifié si un identfiant de connexion existe dans la base de donnée
        /// </summary>
        /// <param name="identifiant">Identifiant à vérifié</param>
        /// <returns>true si une ou plusieurs lignes ont été trouvés</returns>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="SqlException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        public bool IdentifiantExiste(string identifiant)
        {
            bool existe;

            //récupération commande
            SqlCommand cmd = Commande.GetInstance().GetObjCommande();
            cmd.CommandText = "spIdentifiantExiste";

            //ajout des paramètres
            cmd.Parameters.Add("identifiantConnexion", System.Data.SqlDbType.VarChar).Value = identifiant;

            //récupération des profils
            existe = cmd.ExecuteReader().HasRows;

            //fermeture de la commande
            Commande.GetInstance().FermerConnexion();

            return existe;
        }

        /// <summary>
        /// Permet de récupéré le sel pour l'identification du compte
        /// </summary>
        /// <param name="identifiant">identifiant saisie</param>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="SqlException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        /// <returns>sel du compte ou null si introuvable</returns>
        public string GetIdentification(string identifiant)
        {
            string sel = null;

            //récupération commande
            SqlCommand cmd = Commande.GetInstance().GetObjCommande();
            cmd.CommandText = "spGetIdentification";

            //ajout des paramètres
            cmd.Parameters.Add("identifiantConnexion", System.Data.SqlDbType.VarChar).Value = identifiant;

            //récupération du sel
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (reader["selMotDePasse"] != DBNull.Value) sel = reader["selMotDePasse"].ToString();
                }
            }

            //fermeture de la commande
            Commande.GetInstance().FermerConnexion();

            return sel;
        }
    }
}
