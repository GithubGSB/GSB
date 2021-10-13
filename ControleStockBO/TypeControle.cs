using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class TypeControle
    {
        private int id;
        private string libelle;



        public TypeControle(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public TypeControle(int id)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}