using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class Fonctionnalite
    {
        private string code;
        private string libelle;

        public Fonctionnalite(string code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;
        }

        public string Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
