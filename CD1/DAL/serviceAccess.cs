using System;
using System.Collections.Generic;
using CD1.modele;
using Serilog;

namespace CD1.DAL
{
    /// <summary>
    /// classe permettant de gérer les demandes concernant les services
    /// </summary>
    public class serviceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public serviceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<service> GetLesServices()
        {
            List<service> lesServices = new List<service>();
            if (access.Manager != null)
            {
                string req = "select * from service order by nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("serviceAccess.GesLesServices nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("serviceAccess.GestLesServices id={0} nom={1}", record[0], record[1]);
                            service service = new service((int)record[0], (string)record[1]);
                            lesServices.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("serviceAccess.GetLesServices catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }

    }
}
