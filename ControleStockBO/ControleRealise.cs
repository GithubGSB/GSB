using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class ControleRealise
    {
        private int id;
        private DateTime dateControle;
        private DateTime dateCreation;
        private DateTime dateDerniereModif;
        private string resume;
        private float montantHT;
        private TypeControle unTypeControle;
        private Entreprise uneEntreprise;
        private ZoneStockage uneZoneStockage;

        public ControleRealise(int id, DateTime dateControle, DateTime dateCreation, DateTime dateDerniereModif, string resume, float montantHT, TypeControle unTypeControle, Entreprise uneEntreprise, ZoneStockage uneZoneStockage)
        {
            this.Id = id;
            this.DateControle = dateControle;
            this.DateCreation = dateCreation;
            this.DateDerniereModif = dateDerniereModif;
            this.Resume = resume;
            this.MontantHT = montantHT;
            this.UnTypeControle = unTypeControle;
            this.UneEntreprise = uneEntreprise;
            this.UneZoneStockage = uneZoneStockage;
        }

        public ControleRealise(DateTime dateControle, DateTime dateCreation, DateTime dateDerniereModif, string resume, float montantHT, TypeControle unTypeControle, Entreprise uneEntreprise, ZoneStockage uneZoneStockage)
        {
            this.DateControle = dateControle;
            this.DateCreation = dateCreation;
            this.DateDerniereModif = dateDerniereModif;
            this.Resume = resume;
            this.MontantHT = montantHT;
            this.UnTypeControle = unTypeControle;
            this.UneEntreprise = uneEntreprise;
            this.UneZoneStockage = uneZoneStockage;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateControle { get => dateControle; set => dateControle = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public DateTime DateDerniereModif { get => dateDerniereModif; set => dateDerniereModif = value; }
        public string Resume { get => resume; set => resume = value; }
        public float MontantHT { get => montantHT; set => montantHT = value; }
        public TypeControle UnTypeControle { get => unTypeControle; set => unTypeControle = value; }
        public Entreprise UneEntreprise { get => uneEntreprise; set => uneEntreprise = value; }
        public ZoneStockage UneZoneStockage { get => uneZoneStockage; set => uneZoneStockage = value; }
    }
}