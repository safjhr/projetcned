using CD1.DAL;
using CD1.modele;
using System.Collections.Generic;

namespace CD1.controller
{
    public class absencecontroller
    {
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Profil
        /// </summary>
        private readonly motifAccess motifAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public absencecontroller()
        {
            absenceAccess = new AbsenceAccess();
            motifAccess = new motifAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos des développeurs
        /// </summary>
        /// <returns>liste des développeurs</returns>       
        public List<Absence> GetAbsencesForPersonnel(Personnel personnel)
        {
            return absenceAccess.GetAbsencesForPersonnel(personnel);
        }

        /// <summary>
        /// Récupère et retourne les infos des profils
        /// </summary>
        /// <returns>liste des profils</returns>
        public List<motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }
    }
}
