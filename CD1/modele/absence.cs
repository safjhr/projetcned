using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD1.modele
{
    public class Absence
    {
        public Absence(int idpersonnel, System.DateTime datedebut, DateTime datefin, motif motif)
        {
            this.IdPersonnel = idpersonnel;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.Motif = motif;
        }
        

        



        public int IdPersonnel { get; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public motif Motif { get; set; }
    }
}
