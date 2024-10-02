using GitWarriors_AP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitWarriors_AP
{
    public partial class FM3 : Form
    {
        public FM3()
        {
            InitializeComponent();
        }

        private void FM3_Load(object sender, EventArgs e)
        {
            Visiteur visiteur = ModelM3.setCurrentVisiteur();
            bsFicheFrais.DataSource = visiteur.Fichefrais;
            dgvFichesFrais.DataSource = bsFicheFrais;
            dgvFichesFrais.Columns[0].Visible = false;
            dgvFichesFrais.Columns[1].HeaderText = "Date";
            dgvFichesFrais.Columns[2].HeaderText = "Nombre de justificatif";
            dgvFichesFrais.Columns[3].HeaderText = "Montant Valide";
            dgvFichesFrais.Columns[4].HeaderText = "Date de Motification";
            dgvFichesFrais.Columns[5].Visible = false;
            dgvFichesFrais.Columns[6].Visible = false;
            dgvFichesFrais.Columns[7].Visible = false;
            dgvFichesFrais.Columns[8].Visible = false;
            dgvFichesFrais.Columns[9].Visible = false;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            ModelM3.statutAjoutModif = 1;
            FM3AjoutModif fM3Ajout = new FM3AjoutModif();
            fM3Ajout.ShowDialog();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            ModelM3.statutAjoutModif = 2;
            ModelM3.currentFicheFrai = (Fichefrai)bsFicheFrais.Current;
            FM3AjoutModif fM3Ajout = new FM3AjoutModif();
            fM3Ajout.ShowDialog();
        }
    }
}
