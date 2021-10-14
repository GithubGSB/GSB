using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class ZoneStockage
    {
        //variable de ZoneStockage
        private int id;
        private string nomZone;
        private string batiment;
        private string etage;
        private string adresse;
        private DateTime dateCreation;
        private DateTime dateDernModif;
        //Besoin de Ville pour INSEE qui est l'id de Ville
        private Ville uneVille;
        //Besoin de CategProd pour id qui est l'id de CategProduit
        private CategProd uneCategProd;

        //Propriété de ZoneStockage 
        public int Id { get => id; set => id = value; }
        public string NomZone { get => nomZone; set => nomZone = value; }
        public string Batiment { get => batiment; set => batiment = value; }
        public string Etage { get => etage; set => etage = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public DateTime DateDernModif { get => dateDernModif; set => dateDernModif = value; }

       
        public Ville UneVille { get => uneVille; set => uneVille = value; }
        public CategProd UneCategProd { get => uneCategProd; set => uneCategProd = value; }

        public ZoneStockage (int id, string nomZone, string batiment, string etage, string adresse, DateTime dateCreation, DateTime dateDernModif, Ville uneVille, CategProd uneCategProd)
        {
            this.id = id;
            this.nomZone = nomZone;
            this.batiment = batiment;
            this.etage = etage;
            this.adresse = adresse;
            this.dateCreation = dateCreation;
            this.dateDernModif = dateDernModif;
            this.uneVille = uneVille;
            this.uneCategProd = uneCategProd;
        }
        public ZoneStockage(string nomZone, string batiment, string etage, DateTime dateCreation, DateTime dateDernModif, string adresse, CategProd uneCategProd, Ville uneVille)
        {
            
            this.nomZone = nomZone;
            this.batiment = batiment;
            this.etage = etage;
            this.adresse = adresse;
            this.dateCreation = dateCreation;
            this.dateDernModif = dateDernModif;
            this.uneVille = uneVille;
            this.uneCategProd = uneCategProd;
        }

        public ZoneStockage(int id)
        {
            this.id = id;
        }

    }
}
