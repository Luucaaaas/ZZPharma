using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZinventory
{
    internal class Antecedent
    {
        public string id_a  { get; set; }

        public string libelle_a { get; set; }

        public Antecedent(string id_a, string libelle_a)
        {
            this.id_a = id_a;
            this.libelle_a = libelle_a;

        }
    }
}
