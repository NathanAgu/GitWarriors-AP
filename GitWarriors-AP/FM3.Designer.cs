namespace GitWarriors_AP
{
    partial class FM3
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
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            dataGridView1 = new DataGridView();
            btnAjout = new Button();
            btnModif = new Button();
            btnSuppr = new Button();
            bsEtat = new BindingSource(components);
            bsFicheFrais = new BindingSource(components);
            btnFiltres = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFicheFrais).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 20F);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(241, 40);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Fiches de frais :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 352);
            dataGridView1.TabIndex = 4;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(12, 415);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(93, 23);
            btnAjout.TabIndex = 5;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = true;
            // 
            // btnModif
            // 
            btnModif.Location = new Point(111, 415);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(93, 23);
            btnModif.TabIndex = 6;
            btnModif.Text = "Modifier";
            btnModif.UseVisualStyleBackColor = true;
            // 
            // btnSuppr
            // 
            btnSuppr.Location = new Point(210, 415);
            btnSuppr.Name = "btnSuppr";
            btnSuppr.Size = new Size(93, 23);
            btnSuppr.TabIndex = 7;
            btnSuppr.Text = "Supprimer";
            btnSuppr.UseVisualStyleBackColor = true;
            // 
            // btnFiltres
            // 
            btnFiltres.Location = new Point(702, 22);
            btnFiltres.Name = "btnFiltres";
            btnFiltres.Size = new Size(75, 23);
            btnFiltres.TabIndex = 8;
            btnFiltres.Text = "Filtrer";
            btnFiltres.UseVisualStyleBackColor = true;
            // 
            // FM3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFiltres);
            Controls.Add(btnSuppr);
            Controls.Add(btnModif);
            Controls.Add(btnAjout);
            Controls.Add(dataGridView1);
            Controls.Add(labelTitle);
            Name = "FM3";
            Text = "FM3";
            Load += FM3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFicheFrais).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelTitle;
        private DataGridView dataGridView1;
        private Button btnAjout;
        private Button btnModif;
        private Button btnSuppr;
        private BindingSource bsEtat;
        private BindingSource bsFicheFrais;
        private Button btnFiltres;
    }
}