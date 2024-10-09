using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitWarriors_AP.Models
{
    public partial class FUpdatePassword : Form
    {
        public FUpdatePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfPassword.Text)
            {
                ModelM1.setPassword(txtPassword.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Veuillez saisir un mot de passe identique dans les deux champs.");
            }
        }
    }
}
