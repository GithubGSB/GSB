using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    class ControleRealise
    {
        private int id;
        private DateTime dateControle;
        private DateTime dateCreation;
        private DateTime dateDerniereModif;
        private string resume;
        private float montantHT;

        public ControleRealise(int id, DateTime dateControle, DateTime dateCreation, DateTime dateDerniereModif, string resume, float montantHT)
        {
            this.Id = id;
            this.DateControle = dateControle;
            this.DateCreation = dateCreation;
            this.DateDerniereModif = dateDerniereModif;
            this.Resume = resume;
            this.MontantHT = montantHT;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateControle { get => dateControle; set => dateControle = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public DateTime DateDerniereModif { get => dateDerniereModif; set => dateDerniereModif = value; }
        public string Resume { get => resume; set => resume = value; }
        public float MontantHT { get => montantHT; set => montantHT = value; }
    }
}
