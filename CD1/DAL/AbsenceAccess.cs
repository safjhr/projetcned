using System;
using System.Collections.Generic;
using CD1.view;
using CD1.bddmanager;
using CD1.modele;
using Serilog;
using System.Threading.Tasks;

namespace CD1.DAL
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences
        /// </summary>
        /// <returns>liste des absences</returns>

        public List<Absence> GetAbsencesForPersonnel(Personnel personnel)
        {
            List<Absence> absences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "SELECT a.idpersonnel, a.datedebut, a.datefin, m.idmotif, m.libelle " +
                             "FROM absence a " +
                             "JOIN motif m ON a.idmotif = m.idmotif " +
                             "WHERE a.idpersonnel = @idpersonnel " +
                             "ORDER BY datedebut DESC";

                Dictionary<string, object> parameters = new Dictionary<string, object> {
            { "@idpersonnel", personnel.IdPersonnel }
            };

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            int idAbsence = (int)record[0];
                            DateTime dateDebut = (DateTime)record[1];
                            DateTime dateFin = (DateTime)record[2];
                            int idMotif = (int)record[3];
                            string libelleMotif = (string)record[4];

                            motif motif = new motif(idMotif, libelleMotif);
                            Absence absence = new Absence(idAbsence, dateDebut, dateFin, motif);

                            absences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.GetAbsencesForPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return absences;
        }

        /// <summary>
        /// Demande de suppresion d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut AND datefin = @datefin";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
            {"@idpersonnel", absence.IdPersonnel },
            {"@datedebut", absence.DateDebut },
            {"@datefin", absence.DateFin }
        };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.DelAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }


        /// <summary>
        /// Demande d'ajout d'une absence au personnel sélectionné
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsenceForPersonnel(Personnel personnel, Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif)";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
            { "@idpersonnel", personnel.IdPersonnel },
            { "@datedebut", absence.DateDebut },
            { "@datefin", absence.DateFin },
            { "@idmotif", absence.Motif.IdMotif }
        };

                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("Erreur lors de l'ajout de l'absence pour le personnel. Requête : {0}, Erreur : {1}", req, e.Message);
                }
            }
        }


        /// <summary>
        /// Demande de modifier une absence 
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif where idpersonnel = @idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@idpersonnel", absence.IdPersonnel},
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin },
                    { "@idmotif", absence.Motif.IdMotif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.UpdateAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// Demande de verifier si l'absence qu'on souhaite ajouter n'est pas semblable à une autre
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        public bool IsAbsenceScheduled(Personnel personnel, DateTime debut, DateTime fin)
        {
            if (access.Manager != null)
            {
                string req = "SELECT COUNT(*) FROM absence WHERE idpersonnel = @idpersonnel " +
                             "AND ((@debut BETWEEN datedebut AND datefin) OR " +
                             "(@fin BETWEEN datedebut AND datefin) OR " +
                             "(datedebut BETWEEN @debut AND @fin))";

                Dictionary<string, object> parameters = new Dictionary<string, object> {
            { "@idpersonnel", personnel.IdPersonnel},
            { "@debut", debut },
            { "@fin", fin }
        };

                try
                {
                    object result = access.Manager.ReqSelect(req, parameters);
                    int count = Convert.ToInt32(result);
                    return count > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("Erreur lors de la vérification des absences programmées. Requête : {0}, Erreur : {1}", req, e.Message);
                    return false;
                }
            }
            return false;
        }


    }

}
