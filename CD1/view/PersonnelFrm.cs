﻿using System;
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
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private readonly BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
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

        /// <summary>
        /// création du controleur etremplissage des listes
        /// </summary>

        private void Init()
        {
            controller = new personnelcontroller();
            RemplirListePersonnels();
            RemplirListeServices();
            EnCourseModifPersonnel(false);
        }

        /// <summary>
        /// afficher les personnels
        /// </summary>

        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bdgPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// afficher les services
        /// </summary>

        private void RemplirListeServices()
        {

            List<service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            srvaff.DataSource = bdgServices;
        }

        /// <summary>
        /// modifcation d'affichage si on souhaite ajouter ou modifier le personnel 
        /// </summary>
        /// <param name="modif"></param>

        private void EnCourseModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grpLesPersonnels.Enabled = !modif;
            if (modif)
            {
                grpPersonnel.Text = "modifier un personnel";
            }
            else
            {
                grpPersonnel.Text = "ajouter un personnel";
                txtnom.Text = "";
                txtprenom.Text = "";
                txttel.Text = "";
                txtmail.Text = "";
            }
        }

        /// <summary>
        /// annuler la demande de modification ou d'ajout d'un personnel et permet de vider les zones de texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// demande d'enregistrement d'ajout ou de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// permet de modifier le personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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

        /// <summary>
        /// permet de supprimer un developpeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// pour afficher la page avec la liste d'absence du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnabsence_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.Current;
                absence frm = new absence(personnel);
                frm.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Information");
            }
        }

        private int selectedPersonnelId;

        private void dgvPersonnels_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                // Récupérer l'objet Personnel sélectionné à partir du BindingSource
                Personnel personnel = (Personnel)bdgPersonnels.Current;

                // Obtenez l'ID du personnel sélectionné
                int selectedPersonnelId = personnel.IdPersonnel;

                // Utilisez l'ID du personnel sélectionné comme vous le souhaitez, par exemple pour afficher ses absences
                // Vous pouvez appeler une méthode pour charger les absences de ce personnel ici
                // loadAbsencesForSelectedPersonnel(selectedPersonnelId);
            }
        }


        public int SelectedPersonnelId
        {
            get { return selectedPersonnelId; }
        }

        /// <summary>
        /// fermer l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

