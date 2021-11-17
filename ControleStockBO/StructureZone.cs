using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBO
{
    public class StructureZone
    {
        private int id;
        private string typeStructure;

        public int Id { get => id; set => id = value; }
        public string TypeStructure { get => typeStructure; set => typeStructure = value; }

        public StructureZone(int id, string typeStructure)
        {
            this.id = id;
            this.typeStructure = typeStructure;
        }
        public StructureZone(int id)
        {
            this.id = id;
        }
    }
}
