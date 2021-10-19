using ControleStockBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    /// <summary>
    /// Créer une instance d'entreprise si elle n'existe pas 
    /// </summary>
    /// 
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
        /// <summary>
        /// Génèrer un constructeur 
        /// </summary>
        private EntrepriseDAO()
        {
        }

        /// <summary>
        /// Méthode qui permet d'obtenir une liste d'objet d'Entreprise sous forme de Collection de type List.
        /// Pour chaque Objet seul l'id et le nom sont fournis
        /// </summary>
        /// <returns></returns>
        public List<Entreprise> GetLesEntreprises()
        {
            int id;
            string nom;
            // Création d'une Collection de l'objet Entreprise retournant à une Collection d'Entreprise.
            List<Entreprise> lesEntreprises = new List<Entreprise>();
            // Ouverture de la basse de données
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            // Création de la procédure stockée
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spGetLesEntreprises";
            // Ouvertur du reader
            SqlDataReader monLecteur = commande.ExecuteReader();
            // Boucle qui permet d'initialiser les attributs
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
                // Création d'un objet Entreprise avec l'id et le nom
                lesEntreprises.Add(new Entreprise(id, nom));
            }
            // Fermeture du lecteur, connexion et on retourne la Collection
            monLecteur.Close();
            Commande.GetInstance().FermerConnexion();
            return lesEntreprises;

     

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
