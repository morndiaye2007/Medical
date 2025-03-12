using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGroupe2.Model;

namespace AppGroupe2.View
{
    //todo: faire la gestion des erreurs
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }
        BdRvMedicalContext db= new BdRvMedicalContext();
        private void ResetForm()
        {
            txtAdresse.Text= string.Empty;
            txtEmail.Text= string.Empty;
            cbbGroupeSanguin.DataSource = LoadGroupeSanguin();
            cbbGroupeSanguin.ValueMember = "Value";
            cbbGroupeSanguin.DisplayMember = "Text"; 
            txtNomPrenom.Text= string.Empty;
            txtPoids.Text= string.Empty;
            txtTaille.Text= string.Empty;
            txtTelephone.Text= string.Empty;
            dgPatient.DataSource = db.Patients.ToList();
            txtNomPrenom.Focus();

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.NomPrenom= txtNomPrenom.Text;
            p.Adresse = txtAdresse.Text;
            p.Tel= txtTelephone.Text;
            p.Poids = float.Parse(txtPoids.Text);
            p.Email= txtEmail.Text;
            p.Taille = float.Parse(txtTaille.Text);
            p.IdGroupeSanguin = int.Parse(cbbGroupeSanguin.SelectedValue.ToString());
            db.Patients.Add(p);
            db.SaveChanges();
            ResetForm();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgPatient.CurrentRow.Cells[4].Value.ToString();
            txtAdresse.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();
            txtTelephone.Text = dgPatient.CurrentRow.Cells[7].Value.ToString();
            txtPoids.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txtTaille.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();

        }
        private List<SelectListViewModel> LoadGroupeSanguin()
        {
            var m = db.GroupeSanguins.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel b = new SelectListViewModel();
            b.Text = "Selectionnez...";
            b.Value = "";
            liste.Add(b);
            foreach (var c in m)
            {
                SelectListViewModel a = new SelectListViewModel();
                a.Text = c.CodeGroupeSanguin;
                a.Value = c.IdGroupeSanguin.ToString();
                liste.Add(a);
            }
            return liste;
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString());
            if(id.HasValue )
            {
                var p = db.Patients.Find(id);
                p.NomPrenom = txtNomPrenom.Text;
                p.Adresse = txtAdresse.Text;
                p.Tel = txtTelephone.Text;
                p.Poids = float.Parse(txtPoids.Text);
                p.Email = txtEmail.Text;
                p.Taille = float.Parse(txtTaille.Text);
                p.IdGroupeSanguin = int.Parse(cbbGroupeSanguin.SelectedValue.ToString());
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString());
            if (id.HasValue)
            {
                var p = db.Patients.Find(id);
                db.Patients.Remove(p);
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnRendezvous_Click(object sender, EventArgs e)
        {

            frmRendezVous f = new frmRendezVous();
            f.Show();
            this.Hide();
        }
    }
}
