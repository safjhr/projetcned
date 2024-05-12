using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD1.modele
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations de connexion
    /// </summary>
    public class Responsable
    {
        public string Login { get; set; }
        public string Pwd { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
