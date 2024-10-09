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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            if (ModelM1.VisiteurConnecte.Actif && ModelM1.VisiteurConnecte.NbEssai == 4)
            {
                FUpdatePassword fUpdatePassword = new FUpdatePassword();
                fUpdatePassword.ShowDialog();
            }
        }
    }
}
