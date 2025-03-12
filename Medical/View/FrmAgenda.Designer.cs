namespace Medical.View
{
    partial class FrmAgenda
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
            this.lblIdMedecin = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.txtDateAgenda = new System.Windows.Forms.DateTimePicker();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtCreneau = new System.Windows.Forms.TextBox();
            this.lblCreneau = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.txtHeureFin = new System.Windows.Forms.TextBox();
            this.lblHeureFin = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.lblHeureDebut = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.dgAgenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdMedecin
            // 
            this.lblIdMedecin.AutoSize = true;
            this.lblIdMedecin.Location = new System.Drawing.Point(104, 566);
            this.lblIdMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMedecin.Name = "lblIdMedecin";
            this.lblIdMedecin.Size = new System.Drawing.Size(0, 20);
            this.lblIdMedecin.TabIndex = 99;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(1049, 63);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(112, 34);
            this.btnFermer.TabIndex = 98;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // txtDateAgenda
            // 
            this.txtDateAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateAgenda.Location = new System.Drawing.Point(104, 156);
            this.txtDateAgenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDateAgenda.Name = "txtDateAgenda";
            this.txtDateAgenda.Size = new System.Drawing.Size(353, 26);
            this.txtDateAgenda.TabIndex = 97;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Location = new System.Drawing.Point(104, 506);
            this.lblMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(0, 20);
            this.lblMedecin.TabIndex = 96;
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(513, 82);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(112, 34);
            this.btnChoisir.TabIndex = 90;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(347, 448);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 34);
            this.btnSupprimer.TabIndex = 93;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(230, 448);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 34);
            this.btnModifier.TabIndex = 92;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(104, 448);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 34);
            this.btnAjouter.TabIndex = 89;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // txtCreneau
            // 
            this.txtCreneau.Location = new System.Drawing.Point(104, 405);
            this.txtCreneau.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtCreneau.Name = "txtCreneau";
            this.txtCreneau.Size = new System.Drawing.Size(352, 26);
            this.txtCreneau.TabIndex = 87;
            // 
            // lblCreneau
            // 
            this.lblCreneau.AutoSize = true;
            this.lblCreneau.Location = new System.Drawing.Point(104, 382);
            this.lblCreneau.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCreneau.Name = "lblCreneau";
            this.lblCreneau.Size = new System.Drawing.Size(70, 20);
            this.lblCreneau.TabIndex = 94;
            this.lblCreneau.Text = "Creneau";
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(104, 343);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(352, 26);
            this.txtLieu.TabIndex = 86;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(104, 318);
            this.lblLieu.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(39, 20);
            this.lblLieu.TabIndex = 91;
            this.lblLieu.Text = "Lieu";
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.Location = new System.Drawing.Point(104, 279);
            this.txtHeureFin.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(352, 26);
            this.txtHeureFin.TabIndex = 84;
            // 
            // lblHeureFin
            // 
            this.lblHeureFin.AutoSize = true;
            this.lblHeureFin.Location = new System.Drawing.Point(104, 254);
            this.lblHeureFin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblHeureFin.Name = "lblHeureFin";
            this.lblHeureFin.Size = new System.Drawing.Size(79, 20);
            this.lblHeureFin.TabIndex = 88;
            this.lblHeureFin.Text = "Heure Fin";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(104, 215);
            this.txtHeureDebut.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(352, 26);
            this.txtHeureDebut.TabIndex = 83;
            // 
            // lblHeureDebut
            // 
            this.lblHeureDebut.AutoSize = true;
            this.lblHeureDebut.Location = new System.Drawing.Point(104, 190);
            this.lblHeureDebut.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblHeureDebut.Name = "lblHeureDebut";
            this.lblHeureDebut.Size = new System.Drawing.Size(101, 20);
            this.lblHeureDebut.TabIndex = 85;
            this.lblHeureDebut.Text = "Heure Debut";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(104, 127);
            this.lblDate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 82;
            this.lblDate.Text = "Date";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(104, 88);
            this.txtTitre.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(352, 26);
            this.txtTitre.TabIndex = 80;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(104, 63);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(40, 20);
            this.lblTitre.TabIndex = 81;
            this.lblTitre.Text = "Titre";
            // 
            // dgAgenda
            // 
            this.dgAgenda.ColumnHeadersHeight = 34;
            this.dgAgenda.Location = new System.Drawing.Point(513, 126);
            this.dgAgenda.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dgAgenda.Name = "dgAgenda";
            this.dgAgenda.RowHeadersWidth = 62;
            this.dgAgenda.Size = new System.Drawing.Size(628, 474);
            this.dgAgenda.TabIndex = 95;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 662);
            this.Controls.Add(this.lblIdMedecin);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.txtDateAgenda);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtCreneau);
            this.Controls.Add(this.lblCreneau);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.txtHeureFin);
            this.Controls.Add(this.lblHeureFin);
            this.Controls.Add(this.txtHeureDebut);
            this.Controls.Add(this.lblHeureDebut);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.dgAgenda);
            this.Name = "FrmAgenda";
            this.Text = "FrmAgenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdMedecin;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DateTimePicker txtDateAgenda;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtCreneau;
        private System.Windows.Forms.Label lblCreneau;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.TextBox txtHeureFin;
        private System.Windows.Forms.Label lblHeureFin;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Label lblHeureDebut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgAgenda;
    }
}