using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CD1.controller;
using CD1.modele;

namespace CD1

{
    public partial class absence : Form
    {
        private Personnel personnel;
        private absencecontroller controller;
        private readonly BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();

        public absence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            controller = new absencecontroller(); // Initialisez le contrôleur des absences
            RemplirListeAbsences();
            RemplirListeMotifs();
        }

        private void RemplirListeAbsences()
        {
            List<Absence> absences = controller.GetAbsencesForPersonnel(personnel);
            bdgAbsences.DataSource = absences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["IdPersonnel"].Visible = false; // Assurez-vous que la colonne "IdPersonnel" est correctement cachée
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RemplirListeMotifs()
        {
            List<motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cbmotif.DataSource = bdgMotifs;
        }

    }
}
