using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    /// <summary>
    /// BO de Zone de stockage
    /// </summary>
    public class ZoneStockage
    {
        private int id;
        private string nomZone;
        private string batiment;
        private string etage;
        private string adresse;
        private DateTime dateCreation;
        private DateTime dateDernModif;
        private Ville uneVille;
        private CategProd uneCategProd;

        public int Id { get => id; set => id = value; }
        public string NomZone { get => nomZone; set => nomZone = value; }
        public string Batiment { get => batiment; set => batiment = value; }
        public string Etage { get => etage; set => etage = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public DateTime DateDernModif { get => dateDernModif; set => dateDernModif = value; }
        public Ville UneVille { get => uneVille; set => uneVille = value; }
        public CategProd UneCategProd { get => uneCategProd; set => uneCategProd = value; }
        public string NomVille { get => uneVille.Nom; set => uneVille.Nom = value; }
        public string LibelleCategProd { get => uneCategProd.Libelle; set => uneCategProd.Libelle = value; }

        public ZoneStockage(int id, string nomZone, string batiment, string etage, string adresse, DateTime dateCreation, DateTime dateDernModif, Ville uneVille, CategProd uneCategProd)
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
        public ZoneStockage(int id, string nomZone, Ville uneVille, string adresse, string batiment, string etage, CategProd uneCategProd)
        {
            this.id = id;
            this.nomZone = nomZone;
            this.batiment = batiment;
            this.etage = etage;
            this.adresse = adresse;
            
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

        public ZoneStockage(int id, string nomZone)
        {

            this.nomZone = nomZone;
            this.id = id;
        }
    }
}