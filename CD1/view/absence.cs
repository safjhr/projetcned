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
        private Boolean enCoursDeModifAbsence = false;
        private Personnel personnel;
        private absencecontroller controller;
        private readonly BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();
        private DateTime? ParseDateTime(string dateString)
        {
            string[] formats = {"dd/MM/yyyy HH:mm:ss"}; // Ajoutez d'autres formats de date si nécessaire
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

        private void RemplirListeAbsences()
        {
            List<Absence> absences = controller.GetAbsencesForPersonnel(personnel);
            bdgAbsences.DataSource = absences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["IdPersonnel"].Visible = true; // Assurez-vous que la colonne "IdPersonnel" est correctement cachée
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RemplirListeMotifs()
        {
            List<motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cbmotif.DataSource = bdgMotifs;
        }

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

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtdebut.Text) && !string.IsNullOrWhiteSpace(txtfin.Text) && cbmotif.SelectedIndex != -1)
            {
                motif motif = (motif)bdgMotifs.List[bdgMotifs.Position];
                DateTime debut = DateTime.Parse(txtdebut.Text);
                DateTime fin = DateTime.Parse(txtdebut.Text);


                if (DateTime.Parse(txtfin.Text) < DateTime.Parse(txtdebut.Text))
                {
                    // Afficher une alerte à l'utilisateur
                    MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Arrêter l'exécution de la méthode
                }


                if (controller.IsAbsenceScheduled(personnel, debut, fin))
                {
                    MessageBox.Show("Une absence est déjà programmée dans ce créneau.", "Créneau occupé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Arrêter l'exécution de la méthode
                }

                if (DateTime.TryParse(txtdebut.Text, out debut) && DateTime.TryParse(txtfin.Text, out fin))
                {
                    if (enCoursDeModifAbsence)
                    {
                        Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                        absence.DateDebut = debut.Date;
                        absence.DateFin = fin.Date;
                        absence.Motif = motif;
                        controller.UpdateAbsence(absence);
                    }
                    else
                    {
                        Absence absence = new Absence(0, debut, fin, motif);
                        controller.AddAbsenceForPersonnel(personnel, absence);
                    }
                    RemplirListeAbsences();
                    EnCourseModifAbsence(false);
                }
                else
                {
                    MessageBox.Show("Les dates saisies ne sont pas valides. saisissez les sous forme de dd/MM/yyyy HH:mm:ss", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCourseModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                txtdebut.Text = absence.DateDebut.ToString(); // Assurez-vous que absence.DateDebut est un objet DateTime
                txtfin.Text = absence.DateFin.ToString();     // Assurez-vous que absence.DateFin est un objet DateTime
                cbmotif.SelectedIndex = cbmotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifAbsence(false);
            }
        }

        private void btnrevenir_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire d'absence
            this.Close();

            // Ouvrir le formulaire du personnel
            personnel personnel = new personnel();
            personnel.Show();
        }
    }
}
