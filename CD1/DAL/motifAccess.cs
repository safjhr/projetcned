using System;
using System.Collections.Generic;
using CD1.modele;
using Serilog;
using System.Threading.Tasks;

namespace CD1.DAL
{
    /// <summary>
    /// classe permettant de gérer les demandes de motif
    /// </summary>
    public class motifAccess
    {

        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public motifAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<motif> GetLesMotifs()
        {
            List<motif> lesMotifs = new List<motif>();
            if (access.Manager != null)
            {
                string req = "select * from motif order by libelle;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("motifAccess.GetLesMotifs nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("motifAccess.GestLesMotifs id={0} nom={1}", record[0], record[1]);
                            motif motif = new motif((int)record[0], (string)record[1]);
                            lesMotifs.Add(motif);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("motifAccess.GetLesMotifs catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesMotifs;

        }

       


    }
}
