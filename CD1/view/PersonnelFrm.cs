using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CD1.controller;
using CD1.modele;
using CD1.DAL;

namespace CD1.view
{
    public partial class personnel : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        private readonly BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private readonly BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private personnelcontroller controller;
        


        public personnel()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new personnelcontroller();
            RemplirListePersonnels();
            RemplirListeServices();
            EnCourseModifPersonnel(false);
        }

        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bdgPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RemplirListeServices()
        {

            List<service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            srvaff.DataSource = bdgServices;
        }

        private void EnCourseModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grpLesPersonnels.Enabled = !modif;
            if (modif)
            {
                grpPersonnel.Text = "modifier un développeur";
            }
            else
            {
                grpPersonnel.Text = "ajouter un développeur";
                txtnom.Text = "";
                txtprenom.Text = "";
                txttel.Text = "";
                txtmail.Text = "";
            }
        }

        private void btnann_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifPersonnel(false);
            }

        }

        private void personnel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && !txttel.Text.Equals("") && !txtmail.Text.Equals("") && srvaff.SelectedIndex != -1)
            {
                service service = (service)bdgServices.List[bdgServices.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    personnel.Nom = txtnom.Text;
                    personnel.Prenom = txtprenom.Text;
                    personnel.Tel = txttel.Text;
                    personnel.Mail = txtmail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtnom.Text, txtprenom.Text, txttel.Text, txtmail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                EnCourseModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                EnCourseModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtnom.Text = personnel.Nom;
                txtprenom.Text = personnel.Prenom;
                txttel.Text = personnel.Tel;
                txtmail.Text = personnel.Mail;
                srvaff.SelectedIndex = srvaff.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?",
                    "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnabsence_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.Current;
                absence frm = new absence(personnel);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Information");
            }
        }
    }
}

