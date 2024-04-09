
namespace CD1.modele
{
    public class Personnel
    {
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, service service)
        {
            this.IdPersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }



        public int IdPersonnel { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public service Service { get; set; }
    }
}
