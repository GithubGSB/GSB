using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class Profil
    {
        private int id;
        private string libelle;
        private List<Fonctionnalite> lesFoncAutorises;

        public Profil(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
            this.lesFoncAutorises = new List<Fonctionnalite>();
        }

        public Profil(int id, string libelle, List<Fonctionnalite> lesFoncAutorises)
        {
            this.id = id;
            this.libelle = libelle;
            this.lesFoncAutorises = lesFoncAutorises;
        }

        public int Id { get => id;}
        public string Libelle { get => libelle; set => libelle = value; }
        public List<Fonctionnalite> LesFoncAutorises { get => lesFoncAutorises; set => lesFoncAutorises = value; }
    }
}
