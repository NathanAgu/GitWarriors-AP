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
    public partial class FM3AjoutModif : Form
    {
        public FM3AjoutModif()
        {
            InitializeComponent();
        }

        private void FM3AjoutModif_Load(object sender, EventArgs e)
        {
            name.Text = ModelM3.currentVisiteur.Nom + " " + ModelM3.currentVisiteur.Prenom;
            matricule.Text = ModelM3.currentVisiteur.IdVisiteur;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "MM/yyyy";
        }
    }
}
