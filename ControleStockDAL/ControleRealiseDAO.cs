using ControleStockBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockDAL
{
    public class ControleRealiseDAO
    {
        private static ControleRealiseDAO instance;
        private ControleRealiseDAO() { }

        public static ControleRealiseDAO GetInstance()
        {
            if (instance == null) instance = new ControleRealiseDAO();
            return instance;
        }


        public int AjoutControle(ControleRealise unControle)
        {
            SqlCommand commande = Commande.GetInstance().GetObjCommande();
            commande.Parameters.Clear();
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.CommandText = "spAjoutControleRealise";

            commande.Parameters.Add("dateControle", System.Data.SqlDbType.DateTime);
            commande.Parameters[0].Value = unControle.DateControle;

            commande.Parameters.Add("resume", System.Data.SqlDbType.VarChar);
            commande.Parameters[0].Value = unControle.Resume;

            commande.Parameters.Add("montantHT", System.Data.SqlDbType.Float);
            commande.Parameters[0].Value = unControle.MontantHT;

            commande.Parameters.Add("dateCreation", System.Data.SqlDbType.DateTime);
            commande.Parameters[0].Value = unControle.DateCreation;

            commande.Parameters.Add("dateDerniereModif", System.Data.SqlDbType.DateTime);
            commande.Parameters[0].Value = unControle.DateDerniereModif;

            commande.Parameters.Add("idTypeControle", System.Data.SqlDbType.Int);
            commande.Parameters[0].Value = unControle.UnTypeControle.Id;

            commande.Parameters.Add("idEntreprise", System.Data.SqlDbType.Int);
            commande.Parameters[0].Value = unControle.UneEntreprise.Insee;

            commande.Parameters.Add("idZoneStockage", System.Data.SqlDbType.Int);
            commande.Parameters[0].Value = unControle.UneZoneStockage.Id;

            int nb = commande.ExecuteNonQuery();
            commande.Connection.Close();
            return nb;
        }
    }
}