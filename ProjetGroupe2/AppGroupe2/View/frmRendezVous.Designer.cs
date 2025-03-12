namespace AppGroupe2.View
{
    partial class frmRendezVous
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.txtajout = new System.Windows.Forms.Button();
            this.btnSupprimer1 = new System.Windows.Forms.Button();
            this.btxModifier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(1012, 330);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(185, 57);
            this.btnQuitter.TabIndex = 50;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(38, 273);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(451, 26);
            this.txtTelephone.TabIndex = 43;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(38, 245);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 20);
            this.lblTelephone.TabIndex = 48;
            this.lblTelephone.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(38, 199);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(451, 26);
            this.txtEmail.TabIndex = 42;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 171);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(38, 125);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(451, 26);
            this.txtAdresse.TabIndex = 40;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(38, 83);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 20);
            this.lblAdresse.TabIndex = 41;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(42, 40);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(451, 26);
            this.txtNomPrenom.TabIndex = 38;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(38, 12);
            this.lblNomPrenom.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(100, 20);
            this.lblNomPrenom.TabIndex = 39;
            this.lblNomPrenom.Text = "Nom prenom";
            // 
            // txtajout
            // 
            this.txtajout.Location = new System.Drawing.Point(38, 414);
            this.txtajout.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtajout.Name = "txtajout";
            this.txtajout.Size = new System.Drawing.Size(120, 36);
            this.txtajout.TabIndex = 59;
            this.txtajout.Text = "Ajout";
            this.txtajout.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer1
            // 
            this.btnSupprimer1.Location = new System.Drawing.Point(324, 414);
            this.btnSupprimer1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnSupprimer1.Name = "btnSupprimer1";
            this.btnSupprimer1.Size = new System.Drawing.Size(120, 36);
            this.btnSupprimer1.TabIndex = 60;
            this.btnSupprimer1.Text = "Supprimer";
            this.btnSupprimer1.UseVisualStyleBackColor = true;
            // 
            // btxModifier
            // 
            this.btxModifier.Location = new System.Drawing.Point(176, 414);
            this.btxModifier.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btxModifier.Name = "btxModifier";
            this.btxModifier.Size = new System.Drawing.Size(120, 36);
            this.btxModifier.TabIndex = 61;
            this.btxModifier.Text = "Modifier";
            this.btxModifier.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(372, 477);
            this.dataGridView1.TabIndex = 62;
            // 
            // frmRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 851);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btxModifier);
            this.Controls.Add(this.btnSupprimer1);
            this.Controls.Add(this.txtajout);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRendezVous";
            this.Text = "RendezVous";
            this.Load += new System.EventHandler(this.frmRendezVous_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Button txtajout;
        private System.Windows.Forms.Button btnSupprimer1;
        private System.Windows.Forms.Button btxModifier;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}