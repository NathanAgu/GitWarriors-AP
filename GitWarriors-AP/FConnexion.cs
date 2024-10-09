using GitWarriors_AP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitWarriors_AP
{
    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            ModelM1.validationConnexion(txtIdentifiant.Text, txtMotDePasse.Text);
            if (ModelM1.ConnexionValide)
            {
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                thread.Start();
                this.Close();
            }
            else
            {
                if (ModelM1.NbrEssaieConnexion == 3)
                {
                    btnConnexion.Enabled = false;
                    ModelM1.NbrEssaieConnexion = 0;
                }
            }
        }

        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        private void FConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
