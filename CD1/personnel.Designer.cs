
namespace CD1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionner un personnel";
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(189, 242);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(310, 242);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(75, 23);
            this.btnannuler.TabIndex = 3;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(27, 242);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(75, 23);
            this.btnmodifier.TabIndex = 4;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnabsence
            // 
            this.btnabsence.Location = new System.Drawing.Point(108, 242);
            this.btnabsence.Name = "btnabsence";
            this.btnabsence.Size = new System.Drawing.Size(75, 23);
            this.btnabsence.TabIndex = 5;
            this.btnabsence.Text = "Absence";
            this.btnabsence.UseVisualStyleBackColor = true;
            // 
            // btnann
            // 
            this.btnann.Location = new System.Drawing.Point(521, 130);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(119, 23);
            this.btnann.TabIndex = 10;
            this.btnann.Text = "Annuler";
            this.btnann.UseVisualStyleBackColor = true;
            this.btnann.Click += new System.EventHandler(this.btnann_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(345, 130);
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
            this.srvaff.Location = new System.Drawing.Point(521, 77);
            this.srvaff.Name = "srvaff";
            this.srvaff.Size = new System.Drawing.Size(121, 21);
            this.srvaff.TabIndex = 9;
            // 
            // txtmail
            // 
            this.txtmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtmail.Location = new System.Drawing.Point(521, 28);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 8;
            // 
            // txttel
            // 
            this.txttel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txttel.Location = new System.Drawing.Point(119, 127);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 7;
            // 
            // txtprenom
            // 
            this.txtprenom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtprenom.Location = new System.Drawing.Point(119, 77);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(100, 20);
            this.txtprenom.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtnom.Location = new System.Drawing.Point(119, 28);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Service d\'affecattion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Télephone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnann);
            this.panel1.Controls.Add(this.txtnom);
            this.panel1.Controls.Add(this.btnajouter);
            this.panel1.Controls.Add(this.txtprenom);
            this.panel1.Controls.Add(this.srvaff);
            this.panel1.Controls.Add(this.txttel);
            this.panel1.Controls.Add(this.txtmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(27, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 170);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 618);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnabsence);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.label1);
            this.Name = "personnel";
            this.Text = "liste des personnels";
            this.Load += new System.EventHandler(this.personnel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnannuler;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}