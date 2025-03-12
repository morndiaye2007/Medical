namespace AppGroupe2
{
    partial class frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actioncoulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actioncoulerToolStripMenuItem,
            this.coulerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actioncoulerToolStripMenuItem
            // 
            this.actioncoulerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actioncoulerToolStripMenuItem.Name = "actioncoulerToolStripMenuItem";
            this.actioncoulerToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.actioncoulerToolStripMenuItem.Text = "&Action";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.seDeconnecterToolStripMenuItem.Text = "&Se Deconnecter";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // coulerToolStripMenuItem
            // 
            this.coulerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PatientToolStripMenuItem,
            this.MedecinToolStripMenuItem});
            this.coulerToolStripMenuItem.Name = "coulerToolStripMenuItem";
            this.coulerToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.coulerToolStripMenuItem.Text = "Parametre";
            // 
            // PatientToolStripMenuItem
            // 
            this.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem";
            this.PatientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.PatientToolStripMenuItem.Text = "Patient";
            // 
            // MedecinToolStripMenuItem
            // 
            this.MedecinToolStripMenuItem.Name = "MedecinToolStripMenuItem";
            this.MedecinToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.MedecinToolStripMenuItem.Text = "Medecin";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 653);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMDI";
            this.Text = "FrmMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actioncoulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MedecinToolStripMenuItem;
    }
}