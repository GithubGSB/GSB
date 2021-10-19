using ControleStockBO;
using ControleStockDAL;
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
        private Utilisateur utilisateurApp;

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
        private UtilisateurManager()
        {
            utilisateurApp = null;
        }

        public Utilisateur UtilisateurApp {get => utilisateurApp;}

        /// <summary>
        /// Permet l'ajout d'un utilisateur dans la base de données
        /// </summary>
        /// <param name="nom">Nom de l'utilisateur</param>
        /// <param name="prenom">Prénom de l'utilisateur</param>
        /// <param name="profil">Profil de l'utilisateur</param>
        /// <param name="motDePasse">Mot de passe de l'utilisation</param>
        /// <param name="motDePasseConf">Mot de passe de confirmation</param>
        /// <returns>true si réussite, sinon false</returns>
        public bool AjoutUtilisateur(string nom, string prenom, Profil profil, string motDePasse, string motDePasseConf)
        {
            //creation utilisateur
            Utilisateur utilisateur = new Utilisateur(0, nom, prenom, profil);
            string identifiant = null, motDePasseHash = null, sel = null;
            if (motDePasse == null) motDePasse = "";

            //vérification données et ajout
            if (VerifDonneesUtilisateurs(utilisateur, motDePasse, motDePasseConf))
            {
                bool generationReussite = true;
                //génération identifiantConnexion
                identifiant = (utilisateur.Prenom + "." + utilisateur.Nom).ToLower();

                int num = 0;
                try
                {
                    while (UtilisateurDAO.GetInstance().IdentifiantExiste(identifiant))
                    {
                        num++;
                        if (num == 1) identifiant += num;
                        else identifiant = identifiant.Substring(0, identifiant.Length - 1) + num;
                    }
                }
                catch (Exception ex)
                {
                    ex.LogErreur("Impossible de généré un identifiant.");
                    generationReussite = false;
                }

                //génération mot de passe et sel
                if (generationReussite)
                {
                    try
                    {
                        MotDePasseUtil.GenerationMdpHash(motDePasse, out motDePasseHash, out sel);
                    }
                    catch (Exception ex)
                    {
                        ex.LogErreur("Impossible de sécurisé le mot de passe.");
                        generationReussite = false;
                    }
                }

                if (generationReussite)
                {
                    try
                    {
                        UtilisateurDAO.GetInstance().AjoutUtilisateur(utilisateur, motDePasseHash, sel, identifiant);
                        Logger.LogInformation("Utilisateur ajouté, son identifiant est : " + identifiant);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        ex.LogErreur("Impossible d'ajouter l'utilisateur dans la base de données.");
                        generationReussite = false;
                    }
                }
            }
            return false;
        }

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

            if (motDePasse != null)
            {
                if (string.IsNullOrWhiteSpace(motDePasse) || motDePasse.Length < 8) lesErreurs.Add("Le mot de passe est trop petit (minimun 8).");
                else if (motDePasse.Length > 20) lesErreurs.Add("Le mot de passe est trop grand (maximun 20).");
                else if (motDePasse != motDePasseConf) lesErreurs.Add("Le mot de passe de confirmation est incorrect.");
            }

            //retour et affichage des erreurs
            if (lesErreurs.Count > 0)
            {
                Logger.LogAttention("Les données suivantes sont incorrectes :\n\t-" + lesErreurs.Aggregate((x, y) => x + "\n\t-" + y));
                return false;
            }
            return true;
        }
    
        /// <summary>
        /// Permet de connecté un utilisateur et d'assigné l'utilisateur de l'application
        /// </summary>
        /// <param name="identifiant">identifiant</param>
        /// <param name="motDePasse">mot de passe</param>
        /// <returns>true si connecté sinon false</returns>
        public bool ConnexionUtilisateur(string identifiant, string motDePasse)
        {
            //contrôle
            if(identifiant.Length > 50 || motDePasse.Length > 20 || motDePasse.Length < 8)
            {
                Logger.LogAttention("Les données de connexion ne sont pas conforme.");
                return false;
            }
            
            //récupération élément d'identifiant
            string sel;
            try
            {
                sel = UtilisateurDAO.GetInstance().GetIdentification(identifiant);
                if(sel == null)
                {
                    Logger.LogAttention("Aucun compte trouvé avec cette identifiant.");
                    return false;
                }
            } catch(Exception ex)
            {
                ex.LogErreur("Impossible de récupéré les données d'identification.");
                return false;
            }

            //generation mot de passe hash;
            string mdpHash;
            try
            {
                mdpHash = MotDePasseUtil.GenerationMdpVerif(motDePasse, sel);
            } catch(Exception ex)
            {
                ex.LogErreur("Erreur dans la génération des informations d'identification.");
                return false;
            }

            //connexion
            try
            {
                this.utilisateurApp = UtilisateurDAO.GetInstance().GetUtilisateurConnexion(identifiant, mdpHash);
                if(utilisateurApp == null)
                {
                    Logger.LogAttention("Information de connexion incorrecte.");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                ex.LogErreur("Erreur dans la connexion à l'application");
                return false;
            }
        }

        /// <summary>
        /// permet de supprimer l'utilisateur actuel
        /// </summary>
        public void Deconnexion()
        {
            this.utilisateurApp = null;
        }

        /// <summary>
        /// Permet de récupéré la liste des utilisateurs
        /// </summary>
        /// <returns>liste des utilisateur</returns>
        public List<Utilisateur> ConsultationUtilisateur()
        {
            try
            {
                return UtilisateurDAO.GetInstance().GetUtilisateurConsult();
            }
            catch (Exception ex)
            {
                ex.LogErreur("Impossible de récupéré la liste des utlisateurs");
            }
            return new List<Utilisateur>();
        }
    }
}
