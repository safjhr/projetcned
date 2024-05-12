using CD1.DAL;
using CD1.modele;
using System.Collections.Generic;


namespace CD1.controller
{
    /// <summary>
    /// controleur de PersonnelForm
    /// </summary>
    public class personnelcontroller
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly personnelAccess personnelAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Service
        /// </summary>
        private readonly serviceAccess serviceAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public personnelcontroller()
        {
            personnelAccess = new personnelAccess();
            serviceAccess = new serviceAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }


        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }




    }
}