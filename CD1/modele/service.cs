using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD1.modele
{
    public class service
    {
        public int IdService { get; }
        public string Nom { get; }


        public service(int idservice, string nom)
        {
            this.IdService = idservice;
            this.Nom = nom;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
