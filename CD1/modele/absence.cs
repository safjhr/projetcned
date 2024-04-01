using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD1.modele
{
    class absence
    {
        public int IdPersonnel { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public int IdMotif { get; set; }
    }
}
