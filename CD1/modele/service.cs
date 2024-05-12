using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD1.modele
{
    /// <summary>
    /// Classe métier liée à la table service
    /// </summary>
    public class service
    {
        public int IdService { get; }
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public service(int idservice, string nom)
        {
            this.IdService = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'informatio à affiche
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
