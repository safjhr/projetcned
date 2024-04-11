using System;
using System.Collections.Generic;
using CD1.view;
using CD1.bddmanager;
using CD1.modele;
using Serilog;
using System.Threading.Tasks;

namespace CD1.DAL
{
    public class AbsenceAccess
    {

        private readonly Access access = null;
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        public List<Absence> GetAbsencesForPersonnel(Personnel personnel)
        {
            List<Absence> absences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "SELECT a.idpersonnel, a.datedebut, a.datefin, m.idmotif, m.libelle " +
                             "FROM absence a " +
                             "JOIN motif m ON a.idmotif = m.idmotif " +
                             "WHERE a.idpersonnel = @idPersonnel";
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
    }

}
