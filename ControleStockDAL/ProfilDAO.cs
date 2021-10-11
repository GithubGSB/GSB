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
    /// Classe permettant l'accès aux données relatif au profil
    /// </summary>
    public class ProfilDAO
    {
        private static ProfilDAO uneInstance;
        /// <summary>
        /// Premet de récupéré l'instance ProfilDAO
        /// </summary>
        /// <returns>Instance de profilDAO</returns>
        public static ProfilDAO GetInstance()
        {
            if (uneInstance == null) uneInstance = new ProfilDAO();
            return uneInstance;
        }

        /// <summary>
        /// Permet de récupéré tous les profils contenus dans la BD
        /// </summary>
        /// <returns>Liste des profils</returns>
        public List<Profil> GetProfils()
        {
            //variable de travail
            List<Profil> lesProfils = new List<Profil>();
            string libelle, str;
            int id;

            //récupération commande
            SqlCommand cmd = Commande.GetInstance().GetObjCommande();
            cmd.CommandText = "spGetProfils";

            //récupération des profils
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //récupération données
                    if (reader["libelle"] == DBNull.Value) libelle = default(string);
                    else libelle = reader["libelle"].ToString();

                    str = reader["id"].ToString();
                    int.TryParse(str, out id);

                    //ajout du profil
                    lesProfils.Add(new Profil(id, libelle));
                }
            }

            //fermeture de la commande
            Commande.GetInstance().FermerConnexion();
            return lesProfils;
        }
    }
}
