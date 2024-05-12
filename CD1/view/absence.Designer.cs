
namespace CD1.view
{
    partial class absence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnrevenir = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.grpAbsence = new System.Windows.Forms.GroupBox();
            this.btnannuler = new System.Windows.Forms.Button();
            this.cbmotif = new System.Windows.Forms.ComboBox();
            this.txtfin = new System.Windows.Forms.TextBox();
            this.txtdebut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grpLesAbsences = new System.Windows.Forms.GroupBox();
            this.btnmdf = new System.Windows.Forms.Button();
            this.grpAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grpLesAbsences.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(299, 72);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(128, 23);
            this.btnajouter.TabIndex = 1;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(442, 63);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(128, 23);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer l\'absence";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrevenir
            // 
            this.btnrevenir.Location = new System.Drawing.Point(442, 121);
            this.btnrevenir.Name = "btnrevenir";
            this.btnrevenir.Size = new System.Drawing.Size(128, 57);
            this.btnrevenir.TabIndex = 3;
            this.btnrevenir.Text = "Revenir à la liste des personnels";
            this.btnrevenir.UseVisualStyleBackColor = true;
            this.btnrevenir.Click += new System.EventHandler(this.btnrevenir_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(442, 92);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(128, 23);
            this.btnmodifier.TabIndex = 4;
            this.btnmodifier.Text = "Modifier l\'absence";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // grpAbsence
            // 
            this.grpAbsence.Controls.Add(this.btnmdf);
            this.grpAbsence.Controls.Add(this.btnannuler);
            this.grpAbsence.Controls.Add(this.cbmotif);
            this.grpAbsence.Controls.Add(this.txtfin);
            this.grpAbsence.Controls.Add(this.txtdebut);
            this.grpAbsence.Controls.Add(this.label4);
            this.grpAbsence.Controls.Add(this.label3);
            this.grpAbsence.Controls.Add(this.label2);
            this.grpAbsence.Controls.Add(this.btnajouter);
            this.grpAbsence.Location = new System.Drawing.Point(15, 199);
            this.grpAbsence.Name = "grpAbsence";
            this.grpAbsence.Size = new System.Drawing.Size(549, 147);
            this.grpAbsence.TabIndex = 6;
            this.grpAbsence.TabStop = false;
            this.grpAbsence.Text = "groupBox1";
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(299, 101);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(128, 23);
            this.btnannuler.TabIndex = 8;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbmotif
            // 
            this.cbmotif.FormattingEnabled = true;
            this.cbmotif.Location = new System.Drawing.Point(104, 107);
            this.cbmotif.Name = "cbmotif";
            this.cbmotif.Size = new System.Drawing.Size(121, 21);
            this.cbmotif.TabIndex = 7;
            // 
            // txtfin
            // 
            this.txtfin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtfin.Location = new System.Drawing.Point(104, 65);
            this.txtfin.Name = "txtfin";
            this.txtfin.Size = new System.Drawing.Size(121, 20);
            this.txtfin.TabIndex = 6;
            // 
            // txtdebut
            // 
            this.txtdebut.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtdebut.Location = new System.Drawing.Point(104, 30);
            this.txtdebut.Name = "txtdebut";
            this.txtdebut.Size = new System.Drawing.Size(121, 20);
            this.txtdebut.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Motif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date début";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(9, 28);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(337, 150);
            this.dgvAbsences.TabIndex = 7;
            // 
            // grpLesAbsences
            // 
            this.grpLesAbsences.Controls.Add(this.dgvAbsences);
            this.grpLesAbsences.Controls.Add(this.btnsupprimer);
            this.grpLesAbsences.Controls.Add(this.btnrevenir);
            this.grpLesAbsences.Controls.Add(this.btnmodifier);
            this.grpLesAbsences.Location = new System.Drawing.Point(15, 10);
            this.grpLesAbsences.Name = "grpLesAbsences";
            this.grpLesAbsences.Size = new System.Drawing.Size(583, 190);
            this.grpLesAbsences.TabIndex = 8;
            this.grpLesAbsences.TabStop = false;
            this.grpLesAbsences.Text = "groupBox2";
            // 
            // btnmdf
            // 
            this.btnmdf.Location = new System.Drawing.Point(299, 43);
            this.btnmdf.Name = "btnmdf";
            this.btnmdf.Size = new System.Drawing.Size(128, 23);
            this.btnmdf.TabIndex = 9;
            this.btnmdf.Text = "Modifer";
            this.btnmdf.UseVisualStyleBackColor = true;
            this.btnmdf.Click += new System.EventHandler(this.btnmdf_Click);
            // 
            // absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 377);
            this.Controls.Add(this.grpLesAbsences);
            this.Controls.Add(this.grpAbsence);
            this.Name = "absence";
            this.Text = "Absence";
            this.grpAbsence.ResumeLayout(false);
            this.grpAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grpLesAbsences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnrevenir;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.GroupBox grpAbsence;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.ComboBox cbmotif;
        private System.Windows.Forms.TextBox txtfin;
        private System.Windows.Forms.TextBox txtdebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grpLesAbsences;
        private System.Windows.Forms.Button btnmdf;
    }
}