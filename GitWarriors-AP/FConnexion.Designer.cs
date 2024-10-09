namespace GitWarriors_AP
{
    partial class FConnexion
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
            txtIdentifiant = new TextBox();
            txtMotDePasse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnConnexion = new Button();
            SuspendLayout();
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Location = new Point(121, 34);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(100, 23);
            txtIdentifiant.TabIndex = 0;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(121, 63);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(100, 23);
            txtMotDePasse.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Identifiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 66);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "Mot de passe";
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(121, 92);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(100, 23);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // FConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 143);
            Controls.Add(btnConnexion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtIdentifiant);
            Name = "FConnexion";
            Text = "FConnexion";
            Load += FConnexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdentifiant;
        private TextBox txtMotDePasse;
        private Label label1;
        private Label label2;
        private Button btnConnexion;
    }
}