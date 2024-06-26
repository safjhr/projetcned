﻿using CD1.modele;
using System;
using System.Collections.Generic;
using Serilog;

namespace CD1.DAL
{
    /// <summary>
    /// classe permettant de gerer les demandes concernant le responsable
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (login, pwd)
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Boolean ControleConnexion(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable ";
                req += "where login=@login and pwd=@pwd;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@login", responsable.Login },
                    { "@pwd", responsable.Pwd }
                };

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.ControleAuthentification catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }
    }
}

