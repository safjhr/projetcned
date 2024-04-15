using System;
using CD1.controller;
using System.Windows.Forms;
using CD1.modele;
using CD1.view;

namespace CD1.view
{
    public partial class Connexion : Form
    {
        private connexioncontroller controller;

        public Connexion()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new connexioncontroller();
        }

        /// <summary>
        /// demande au controler de controler la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String login = txt_login.Text;
            String pwd = txt_pwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.Controleconnexion(responsable))
                {
                    personnel frm = new personnel();
                    frm.Show ();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte", "Alerte");
                }
            }
        }
    }
}

