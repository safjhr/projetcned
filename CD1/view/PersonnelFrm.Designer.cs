
namespace CD1.view
{
    partial class personnel
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
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnabsence = new System.Windows.Forms.Button();
            this.btnann = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.srvaff = new System.Windows.Forms.ComboBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.grpPersonnel = new System.Windows.Forms.GroupBox();
            this.grpLesPersonnels = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.grpPersonnel.SuspendLayout();
            this.grpLesPersonnels.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(87, 175);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Location = new System.Drawing.Point(249, 175);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(75, 23);
            this.btnquitter.TabIndex = 3;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(6, 175);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(75, 23);
            this.btnmodifier.TabIndex = 4;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnabsence
            // 
            this.btnabsence.Location = new System.Drawing.Point(168, 175);
            this.btnabsence.Name = "btnabsence";
            this.btnabsence.Size = new System.Drawing.Size(75, 23);
            this.btnabsence.TabIndex = 5;
            this.btnabsence.Text = "Absence";
            this.btnabsence.UseVisualStyleBackColor = true;
            this.btnabsence.Click += new System.EventHandler(this.btnabsence_Click);
            // 
            // btnann
            // 
            this.btnann.Location = new System.Drawing.Point(420, 142);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(119, 23);
            this.btnann.TabIndex = 10;
            this.btnann.Text = "Annuler";
            this.btnann.UseVisualStyleBackColor = true;
            this.btnann.Click += new System.EventHandler(this.btnann_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(283, 142);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(121, 23);
            this.btnajouter.TabIndex = 7;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // srvaff
            // 
            this.srvaff.FormattingEnabled = true;
            this.srvaff.Location = new System.Drawing.Point(420, 81);
            this.srvaff.Name = "srvaff";
            this.srvaff.Size = new System.Drawing.Size(121, 21);
            this.srvaff.TabIndex = 9;
            // 
            // txtmail
            // 
            this.txtmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtmail.Location = new System.Drawing.Point(420, 40);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 8;
            // 
            // txttel
            // 
            this.txttel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txttel.Location = new System.Drawing.Point(94, 120);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 7;
            // 
            // txtprenom
            // 
            this.txtprenom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtprenom.Location = new System.Drawing.Point(94, 81);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(100, 20);
            this.txtprenom.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtnom.Location = new System.Drawing.Point(94, 40);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Service d\'affecattion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Télephone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Location = new System.Drawing.Point(6, 19);
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.Size = new System.Drawing.Size(564, 150);
            this.dgvPersonnels.TabIndex = 12;
            this.dgvPersonnels.SelectionChanged += new System.EventHandler(this.dgvPersonnels_SelectionChanged);
            // 
            // grpPersonnel
            // 
            this.grpPersonnel.Controls.Add(this.txtnom);
            this.grpPersonnel.Controls.Add(this.btnann);
            this.grpPersonnel.Controls.Add(this.txtprenom);
            this.grpPersonnel.Controls.Add(this.txttel);
            this.grpPersonnel.Controls.Add(this.btnajouter);
            this.grpPersonnel.Controls.Add(this.label2);
            this.grpPersonnel.Controls.Add(this.label6);
            this.grpPersonnel.Controls.Add(this.srvaff);
            this.grpPersonnel.Controls.Add(this.label3);
            this.grpPersonnel.Controls.Add(this.label4);
            this.grpPersonnel.Controls.Add(this.txtmail);
            this.grpPersonnel.Controls.Add(this.label5);
            this.grpPersonnel.Location = new System.Drawing.Point(27, 261);
            this.grpPersonnel.Name = "grpPersonnel";
            this.grpPersonnel.Size = new System.Drawing.Size(576, 181);
            this.grpPersonnel.TabIndex = 13;
            this.grpPersonnel.TabStop = false;
            this.grpPersonnel.Text = "groupBox1";
            // 
            // grpLesPersonnels
            // 
            this.grpLesPersonnels.Controls.Add(this.dgvPersonnels);
            this.grpLesPersonnels.Controls.Add(this.btnmodifier);
            this.grpLesPersonnels.Controls.Add(this.btnquitter);
            this.grpLesPersonnels.Controls.Add(this.btnabsence);
            this.grpLesPersonnels.Controls.Add(this.btnsupprimer);
            this.grpLesPersonnels.Location = new System.Drawing.Point(27, 35);
            this.grpLesPersonnels.Name = "grpLesPersonnels";
            this.grpLesPersonnels.Size = new System.Drawing.Size(576, 220);
            this.grpLesPersonnels.TabIndex = 14;
            this.grpLesPersonnels.TabStop = false;
            this.grpLesPersonnels.Text = "les personnels";
            // 
            // personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 471);
            this.Controls.Add(this.grpLesPersonnels);
            this.Controls.Add(this.grpPersonnel);
            this.Name = "personnel";
            this.Text = "liste des personnels";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.grpPersonnel.ResumeLayout(false);
            this.grpPersonnel.PerformLayout();
            this.grpLesPersonnels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnabsence;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnann;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.ComboBox srvaff;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.GroupBox grpPersonnel;
        private System.Windows.Forms.GroupBox grpLesPersonnels;
    }
}