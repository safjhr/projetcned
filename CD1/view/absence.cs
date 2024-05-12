using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CD1.controller;
using CD1.modele;
using System.Globalization;



namespace CD1.view

{
    public partial class absence : Form
    {
        /// <summary>
        /// boolèen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        private Personnel personnel;
        /// <summary>
        /// controleur de la fenêtre
        /// </summary>
        private absencecontroller controller;
        /// <summary>
        /// objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// le format de date qu'il faut écrire
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        private DateTime? ParseDateTime(string dateString)
        {
            string[] formats = {"dd/MM/yyyy HH:mm:ss"};
            DateTime parsedDate;
            if (DateTime.TryParseExact(dateString, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                return parsedDate;
            }
            else
            {
                // La conversion a échoué
                return null;
            }
        }
        public int SelectedPersonnelId { get; set; }


        public absence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            controller = new absencecontroller(); // Initialisez le contrôleur des absences
            RemplirListeAbsences();
            RemplirListeMotifs();
            EnCourseModifAbsence(false);
        }



        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>


        private void EnCourseModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grpLesAbsences.Enabled = !modif;
            if (modif)
            {
                grpAbsence.Text = "modifier une absence";
            }
            else
            {
                grpAbsence.Text = "ajouter une absence";
                txtdebut.Text = "";
                txtfin.Text = "";
                
            }
        }

        /// <summary>
        /// remplir la liste d'absence
        /// </summary>

        private void RemplirListeAbsences()
        {
            List<Absence> absences = controller.GetAbsencesForPersonnel(personnel);
            bdgAbsences.DataSource = absences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["IdPersonnel"].Visible = false ; // Assurez-vous que la colonne "IdPersonnel" est correctement cachée
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// remplir la liste de motif
        /// </summary>

        private void RemplirListeMotifs()
        {
            List<motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cbmotif.DataSource = bdgMotifs;
        }

        /// <summary>
        /// supprimer une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du  " + absence.DateDebut + " " + " au " +" " + absence.DateFin + " ?",
                    "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// permet d'enregistrer un ajout ou une modification d'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtdebut.Text) && !string.IsNullOrWhiteSpace(txtfin.Text) && cbmotif.SelectedIndex != -1)
            {
                
                if (DateTime.TryParse(txtdebut.Text, out DateTime debut) && DateTime.TryParse(txtfin.Text, out DateTime fin))
                {
                    
                    if (fin < debut)
                    {
                        MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur de saisie");
                        return;
                    }

                   
                    if (controller.IsAbsenceScheduled(personnel.IdPersonnel, debut, fin))
                    {
                        MessageBox.Show("Une absence est déjà programmée dans ce créneau.", "Erreur de saisie");
                        return;
                    }

                    motif motif = (motif)cbmotif.SelectedItem;
                    Absence absence = new Absence(0, debut, fin, motif);
                    controller.AddAbsenceForPersonnel(personnel, absence);
                    RemplirListeAbsences();
                    EnCourseModifAbsence(false);
                }
                else
                {
                    MessageBox.Show("Les dates saisies ne sont pas valides. Veuillez saisir des dates au format jj/MM/yyyy HH:mm:ss", "Erreur de saisie");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Information");
            }
        }
    
        /// <summary>
        /// modifier une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            { 
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                txtdebut.Text = absence.DateDebut.ToString();
                txtfin.Text = absence.DateFin.ToString();
                cbmotif.SelectedIndex = cbmotif.FindStringExact(absence.Motif.Libelle);
                EnCourseModifAbsence(true);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// annuler la saisieet vider les zones de textes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifAbsence(false);
            }
        }
        /// <summary>
        /// permet de revenir a la page des personnels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnrevenir_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire d'absence
            this.Close();

            // Ouvrir le formulaire du personnel
            personnel personnel = new personnel();
            personnel.Show();
        }

        private void btnmdf_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                motif motif = (motif)cbmotif.SelectedItem;
                
                if (dgvAbsences.SelectedRows[0].DataBoundItem is Absence absence)
                {
                    
                    if (!string.IsNullOrWhiteSpace(txtdebut.Text) && !string.IsNullOrWhiteSpace(txtfin.Text) && cbmotif.SelectedIndex != -1)
                    {
                        
                        if (DateTime.TryParse(txtdebut.Text, out DateTime debut) && DateTime.TryParse(txtfin.Text, out DateTime fin))
                        {
                            
                            if (fin < debut)
                            {
                                MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur de saisie");
                                return;
                            }

                            
                            if (controller.IsAbsenceScheduled(absence.IdPersonnel, debut, fin))
                            {
                                MessageBox.Show("Une absence existe déjà dans ce créneau.", "Erreur");
                                return;
                            }

                            

                            
                            controller.UpdateAbsence(absence.IdPersonnel, absence.DateDebut, absence.DateFin, new Absence(absence.IdPersonnel, debut, fin, motif));
                            controller.UpdateMotif(motif);

                            
                            RemplirListeAbsences();

                            
                            txtdebut.Text = "";
                            txtfin.Text = "";
                            cbmotif.SelectedIndex = -1;
                            EnCourseModifAbsence(false);
                        }
                        else
                        {
                            MessageBox.Show("Les dates saisies ne sont pas valides. Veuillez saisir des dates au format jj/MM/yyyy HH:mm:ss", "Erreur de saisie");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez remplir tous les champs.", "Information");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.", "Information");
            }
        }
    }
}
