﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleStockBO;
using ControleStockDAL;

namespace ControleStockDAL
{
    /// <summary>
    /// Classe VilleDAO récupérer les informations dans la base de donnée de la table Ville
    /// </summary>
    public class VilleDAO

    {
        private static VilleDAO uneInstance;
        // PATERN SINGLETON
        /// <summary>
        /// Créer une instance de Ville si elle n'existe pas et la retourne
        /// </summary>
        /// <returns>retourne un objet ville</returns>
        public static VilleDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VilleDAO();
            }
            return uneInstance;
        }
        /// <summary>
        /// Constructeur de ville pour bloquer la création d'entitée dans VilleDAO
        /// </summary>
        private VilleDAO()
        {

        }
        /// <summary>
        /// Retourne les villes via une procédure stockée. Il cherchera l'ensemble des ville de la BD. 
        /// </summary>
        /// <returns>retourne collection Villes</returns>
        public List<Ville> GetLesVilles()
        {
            int insee;
            string nom;
            List<Ville> lesVilles = new List<Ville>();

            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spConsultLesVilles";

            SqlDataReader monLecteur = commande.ExecuteReader();
            while (monLecteur.Read())
            {
                insee = (int)monLecteur["insee"];
                if (monLecteur["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monLecteur["nom"].ToString();
                }
                lesVilles.Add(new Ville(insee, nom));
            }
            monLecteur.Close();
            commande.Connection.Close();
            return lesVilles;
        }
    }
}
