using CD1.DAL;
using CD1.modele;
using System.Collections.Generic;
using Serilog;
using System;

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

        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }


        /// <summary>
        /// Demande d'ajout d'un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à ajouter</param>
        public void AddAbsenceForPersonnel(Personnel personnel, Absence absence)
        {
            // Appelez la méthode du DAL pour ajouter l'absence pour le personnel sélectionné
            absenceAccess.AddAbsenceForPersonnel(personnel, absence);
        }


        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }
        private personnelAccess personnelAccess = new personnelAccess(); // Initialisez personnelaccess

        public bool IsAbsenceScheduled(Personnel personnel, DateTime debut, DateTime fin)
        {
            return absenceAccess.IsAbsenceScheduled(personnel, debut, fin);
        }



    }
}
