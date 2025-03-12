namespace Medical
{
    partial class frmConnexion1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.txtNomUtlisateur = new System.Windows.Forms.TextBox();
            this.frmConnexion = new System.Windows.Forms.Label();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Location = new System.Drawing.Point(228, 372);
            this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(162, 35);
            this.btnSeConnecter.TabIndex = 3;
            this.btnSeConnecter.Text = "&Se Connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = true;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(68, 372);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(112, 35);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(63, 250);
            this.lblMotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(106, 20);
            this.lblMotDePasse.TabIndex = 14;
            this.lblMotDePasse.Text = "Mot de Passe";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(68, 275);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(320, 26);
            this.txtMotDePasse.TabIndex = 2;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // txtNomUtlisateur
            // 
            this.txtNomUtlisateur.Location = new System.Drawing.Point(68, 195);
            this.txtNomUtlisateur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomUtlisateur.Name = "txtNomUtlisateur";
            this.txtNomUtlisateur.Size = new System.Drawing.Size(320, 26);
            this.txtNomUtlisateur.TabIndex = 1;
            // 
            // frmConnexion
            // 
            this.frmConnexion.Location = new System.Drawing.Point(431, 350);
            this.frmConnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frmConnexion.Name = "frmConnexion";
            this.frmConnexion.Size = new System.Drawing.Size(150, 35);
            this.frmConnexion.TabIndex = 13;
            this.frmConnexion.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.Location = new System.Drawing.Point(63, 170);
            this.lblNomUtilisateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(129, 20);
            this.lblNomUtilisateur.TabIndex = 9;
            this.lblNomUtilisateur.Text = "Nom d\'Utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "Authentification";
            // 
            // frmConnexion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 440);
            this.ControlBox = false;
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtNomUtlisateur);
            this.Controls.Add(this.frmConnexion);
            this.Controls.Add(this.lblNomUtilisateur);
            this.Controls.Add(this.label1);
            this.Name = "frmConnexion1";
            this.Text = "Page de Connexion";
            this.Load += new System.EventHandler(this.frmConnexion1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.TextBox txtNomUtlisateur;
        private System.Windows.Forms.Label frmConnexion;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.Label label1;
    }
}

