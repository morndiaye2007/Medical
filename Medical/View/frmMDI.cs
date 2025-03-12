using System;
using System.Drawing;
using System.Windows.Forms;
using Medical;
using Medical.View;

namespace AppGroupe2
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion1 f = new frmConnexion1();
            f.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            // For each child form set the window state to Maximized
            foreach (Form chform in charr)
            {
                chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }

        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmPatient f = new frmPatient();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void bleuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMedecin f = new frmMedecin();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
