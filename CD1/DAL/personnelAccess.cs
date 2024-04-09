﻿using CD1.modele;
using Serilog;
using System;
using System.Collections.Generic;

namespace CD1.DAL
{
    public class personnelAccess
    {
        private readonly Access access = null;

        public personnelAccess()
        {
            access = Access.GetInstance();
        }

        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select d.idpersonnel as idpersonnel, d.nom as nom, d.prenom as prenom, d.tel as tel, d.mail as mail, p.idservice as idservice, p.nom as service ";
                req += "from personnel d join service p on (d.idservice = p.idservice) ";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("personnelAccess.GetLesPersonnels nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("DeveloppeurAccess.GetLesDeveloppeurs Profil : id={0} nom={1}", record[5], record[6]);
                            Log.Debug("DeveloppeurAccess.GetLesDeveloppeurs Developpeur : id={0} nom={1} prenom={2} tel={3} mail={4} ", record[0], record[1], record[2], record[3], record[4]);
                            service service = new service((int)record[5], (string)record[6]); // Mettez le nom du service si disponible
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2],
                               (string)record[3], (string)record[4], service);
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("personnelAccess.GetLesPersonnels catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }

        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@idpersonnel", personnel.IdPersonnel }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("personnelAccess.DelPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice) values (@nom, @prenom, @tel, @mail, @idservice)";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail },
                    { "@idservice", personnel.Service.IdService }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("personnelAccess.AddPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice where idpersonnel = @idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@idpersonnel", personnel.IdPersonnel},
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail },
                    { "@idservice", personnel.Service.IdService }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.UpdatePersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}

