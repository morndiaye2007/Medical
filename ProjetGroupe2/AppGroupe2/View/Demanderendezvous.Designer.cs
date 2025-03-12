namespace AppGroupe2.View
{
    partial class frmDemanderendezvous
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNumeroOrdre = new System.Windows.Forms.TextBox();
            this.lblNumeroOrdre = new System.Windows.Forms.Label();
            this.txtSpecialite = new System.Windows.Forms.TextBox();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.dgRendezVous = new System.Windows.Forms.DataGridView();
            this.namecreneau = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dgRendezVous)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(276, 751);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(142, 52);
            this.btnSupprimer.TabIndex = 72;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(33, 751);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(144, 52);
            this.btnAjouter.TabIndex = 68;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtNumeroOrdre
            // 
            this.txtNumeroOrdre.Location = new System.Drawing.Point(33, 654);
            this.txtNumeroOrdre.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtNumeroOrdre.Name = "txtNumeroOrdre";
            this.txtNumeroOrdre.Size = new System.Drawing.Size(451, 26);
            this.txtNumeroOrdre.TabIndex = 66;
            this.txtNumeroOrdre.TextChanged += new System.EventHandler(this.txtNumeroOrdre_TextChanged);
            // 
            // lblNumeroOrdre
            // 
            this.lblNumeroOrdre.AutoSize = true;
            this.lblNumeroOrdre.Location = new System.Drawing.Point(35, 603);
            this.lblNumeroOrdre.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblNumeroOrdre.Name = "lblNumeroOrdre";
            this.lblNumeroOrdre.Size = new System.Drawing.Size(109, 20);
            this.lblNumeroOrdre.TabIndex = 74;
            this.lblNumeroOrdre.Text = "Numero Ordre";
            // 
            // txtSpecialite
            // 
            this.txtSpecialite.Location = new System.Drawing.Point(39, 534);
            this.txtSpecialite.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.Size = new System.Drawing.Size(451, 26);
            this.txtSpecialite.TabIndex = 65;
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(35, 506);
            this.lblSpecialite.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(78, 20);
            this.lblSpecialite.TabIndex = 73;
            this.lblSpecialite.Text = "Specialite";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(39, 448);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(451, 26);
            this.txtIdentifiant.TabIndex = 64;
            this.txtIdentifiant.TextChanged += new System.EventHandler(this.txtIdentifiant_TextChanged);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(35, 408);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.lblIdentifiant.TabIndex = 70;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(39, 349);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(451, 26);
            this.txtTelephone.TabIndex = 62;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(35, 309);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(159, 20);
            this.lblTelephone.TabIndex = 67;
            this.lblTelephone.Text = "Reference Payement";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(39, 249);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(451, 26);
            this.txtEmail.TabIndex = 61;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 211);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 20);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = " Mode de Payement";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(35, 151);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(451, 26);
            this.txtAdresse.TabIndex = 59;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(35, 114);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(43, 20);
            this.lblAdresse.TabIndex = 60;
            this.lblAdresse.Text = "Cout";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(35, 54);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(451, 26);
            this.txtNomPrenom.TabIndex = 57;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(35, 15);
            this.lblNomPrenom.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(100, 20);
            this.lblNomPrenom.TabIndex = 58;
            this.lblNomPrenom.Text = "Nom prenom";
            // 
            // dgRendezVous
            // 
            this.dgRendezVous.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgRendezVous.ColumnHeadersHeight = 34;
            this.dgRendezVous.Location = new System.Drawing.Point(754, 195);
            this.dgRendezVous.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dgRendezVous.Name = "dgRendezVous";
            this.dgRendezVous.RowHeadersWidth = 62;
            this.dgRendezVous.Size = new System.Drawing.Size(328, 626);
            this.dgRendezVous.TabIndex = 75;
            this.dgRendezVous.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRendezVous_CellContentClick);
            // 
            // namecreneau
            // 
            this.namecreneau.AutoSize = true;
            this.namecreneau.Location = new System.Drawing.Point(802, 44);
            this.namecreneau.Name = "namecreneau";
            this.namecreneau.Size = new System.Drawing.Size(70, 20);
            this.namecreneau.TabIndex = 76;
            this.namecreneau.Text = "Creneau";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(286, 506);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(150, 150);
            this.crystalReportViewer1.TabIndex = 77;
            // 
            // frmDemanderendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1227, 865);
            this.ControlBox = false;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.namecreneau);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNumeroOrdre);
            this.Controls.Add(this.lblNumeroOrdre);
            this.Controls.Add(this.txtSpecialite);
            this.Controls.Add(this.lblSpecialite);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.dgRendezVous);
            this.Name = "frmDemanderendezvous";
            this.Text = "Demanderendezvous";
            ((System.ComponentModel.ISupportInitialize)(this.dgRendezVous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNumeroOrdre;
        private System.Windows.Forms.Label lblNumeroOrdre;
        private System.Windows.Forms.TextBox txtSpecialite;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.DataGridView dgRendezVous;
        private System.Windows.Forms.Label namecreneau;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}