using ControleStockBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleStockBLL
{
    /// <summary>
    /// Classe permettant la gestion des utilisateurs
    /// </summary>
    public class UtilisateurManager
    {
        private static UtilisateurManager uneInstance;
        /// <summary>
        /// Premet de récupéré l'instance UtilisateurManager
        /// </summary>
        /// <returns>Instance de UtilisateurManager</returns>
        public static UtilisateurManager GetInstance()
        {
            if (uneInstance == null) uneInstance = new UtilisateurManager();
            return uneInstance;
        }
        private UtilisateurManager() { }

        /// <summary>
        /// Permet de vérifié si les données d'un utilisateur sont correctes, et d'affiché les problèmes
        /// </summary>
        /// <param name="utilisateur">Utilisateur à vérifié</param>
        /// <param name="motDePasse">Mot de passe, null si aucun contrôle</param>
        /// <param name="motDePasseConf">Mot de passe de confirmation</param>
        /// <returns>true si valide sinon false</returns>
        private bool VerifDonneesUtilisateurs(Utilisateur utilisateur, string motDePasse = null, string motDePasseConf = null)
        {
                List<string> lesErreurs = new List<string>();

            //validation
            if (string.IsNullOrWhiteSpace(utilisateur.Nom) || utilisateur.Nom.Length < 3) lesErreurs.Add("Le nom est trop petit (minimun 3).");
            else if (utilisateur.Nom.Length > 50) lesErreurs.Add("Le nom est trop grand (maximun 50).");
            if (string.IsNullOrWhiteSpace(utilisateur.Prenom) || utilisateur.Prenom.Length < 3) lesErreurs.Add("Le prénom est trop petit (minimun 3).");
            else if (utilisateur.Prenom.Length > 50) lesErreurs.Add("Le prénom est trop grand (maximun 50).");
            if (utilisateur.Profil == null) lesErreurs.Add("Aucun profil n'a été sélectionné");

            if(motDePasse != null)
            {
                if (string.IsNullOrWhiteSpace(motDePasse) || motDePasse.Length < 8) lesErreurs.Add("Le mot de passe est trop petit (minimun 8).");
                else if (motDePasse.Length > 20) lesErreurs.Add("Le mot de passe est trop grand (maximun 20).");
                else if (motDePasse != motDePasseConf) lesErreurs.Add("Le mot de passe de confirmation est incorrect.");
            }

            //retour et affichage des erreurs
            if (lesErreurs.Count > 0)
                {
                    MessageBox.Show("Les données suivantes sont incorrectes :\n" + lesErreurs.Aggregate((x, y) => x + "\n\t-" + y), "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
        }
    }
}
