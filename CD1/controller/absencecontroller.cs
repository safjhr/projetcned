using CD1.DAL;
using CD1.modele;
using System.Collections.Generic;
using Serilog;
using System;

namespace CD1.controller
{
    public class absencecontroller
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        
        /// <summary>
        /// objet d'accès aux opérations possible sur motif
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
        /// Récupère et retourne les infos des absences
        /// </summary>
        /// <returns>liste des absences</returns>       
        public List<Absence> GetAbsencesForPersonnel(Personnel personnel)
        {
            return absenceAccess.GetAbsencesForPersonnel(personnel);
        }

        /// <summary>
        /// Récupère et retourne les infos des motis
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// demande de suppresion d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>

        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }


        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsenceForPersonnel(Personnel personnel, Absence absence)
        {
            // Appelez la méthode du DAL pour ajouter l'absence pour le personnel sélectionné
            absenceAccess.AddAbsenceForPersonnel(personnel, absence);
        }


        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(int idPersonnel, DateTime oldDebut, DateTime oldFin, Absence newAbsence)
        {
            absenceAccess.UpdateAbsence(idPersonnel, oldDebut, oldFin, newAbsence);
        }
        public void UpdateMotif(motif motif)
        {
            absenceAccess.UpdateMotif(motif);
        }
        public bool IsAbsenceScheduled(int idPersonnel, DateTime debut, DateTime fin)
        {
            return absenceAccess.IsAbsenceScheduled(idPersonnel, debut, fin);
        }






    }
}
