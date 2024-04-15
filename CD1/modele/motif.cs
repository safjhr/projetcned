using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD1.modele
{
    /// <summary>
    /// Classe métier liée à la table motif
    /// </summary>
    public class motif
    {
        public int IdMotif { get; set; }
        public string Libelle { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public motif(int idmotif, string libelle)
        {
            this.IdMotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher
        /// </summary>
        /// <returns>libelle du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
