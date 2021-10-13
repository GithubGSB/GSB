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
    /// Classe permettant l'accès aux données relatif au fonctionnalité
    /// </summary>
    public class FonctionnaliteDAO
    {
        private static FonctionnaliteDAO uneInstance;
        /// <summary>
        /// Premet de récupéré l'instance FonctionnaliteDAO
        /// </summary>
        /// <returns>Instance de FonctionnaliteDAO</returns>
        public static FonctionnaliteDAO GetInstance()
        {
            if (uneInstance == null) uneInstance = new FonctionnaliteDAO();
            return uneInstance;
        }
        private FonctionnaliteDAO() { }

        /// <summary>
        /// Permet de récupéré la liste des fonctionnalités correspondant à un profil
        /// </summary>
        /// <param name="idProfil">id du profil</param>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="SqlException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns>Liste des profils</returns>
        public List<Fonctionnalite> GetFoncProfil(int idProfil)
        {
            List<Fonctionnalite> lesFonctionnalites = new List<Fonctionnalite>();

            string libelle, code;

            //récupération commande
            SqlCommand cmd = Commande.GetInstance().GetObjCommande();
            cmd.CommandText = "spGetFoncProfil";

            //ajout des paramètres
            cmd.Parameters.Add("idProfil", System.Data.SqlDbType.Int).Value = idProfil;

            //récupération des fonctionnalités
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //récupération données
                    if (reader["libelle"] == DBNull.Value) libelle = default(string);
                    else libelle = reader["libelle"].ToString();

                    if (reader["code"] == DBNull.Value) code = default(string);
                    else code = reader["code"].ToString();

                    //ajout du profil
                    lesFonctionnalites.Add(new Fonctionnalite(code, libelle));
                }
            }

            //fermeture de la commande
            Commande.GetInstance().FermerConnexion();

            return lesFonctionnalites;
        }
    }
}
