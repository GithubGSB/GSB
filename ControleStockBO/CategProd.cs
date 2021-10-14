using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class CategProd
    {
        private int id;
        private string libelle;


        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public CategProd(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;

        }
        public CategProd(int id)
        {
            this.id = id;
        }
    }
}