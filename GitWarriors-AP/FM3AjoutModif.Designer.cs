namespace GitWarriors_AP
{
    partial class FM3AjoutModif
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
            name = new Label();
            datePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            matricule = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            btnAjoutForfait = new Button();
            btnModifForfait = new Button();
            btnSupprForfait = new Button();
            btnAjoutHorsForfait = new Button();
            btnModifHorsForfait = new Button();
            btnSupprHorsForfait = new Button();
            bsLigneForfait = new BindingSource(components);
            bsLigneHorsForfait = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsLigneForfait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsLigneHorsForfait).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F);
            name.Location = new Point(70, 17);
            name.Name = "name";
            name.Size = new Size(0, 21);
            name.TabIndex = 0;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(661, 17);
            datePicker.MaximumSize = new Size(100, 100);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(100, 23);
            datePicker.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(606, 17);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 2;
            label1.Text = "Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "Nom :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(246, 17);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 4;
            label3.Text = "Matricule :";
            // 
            // matricule
            // 
            matricule.AutoSize = true;
            matricule.Font = new Font("Segoe UI", 12F);
            matricule.Location = new Point(334, 17);
            matricule.Name = "matricule";
            matricule.Size = new Size(0, 21);
            matricule.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 120);
            dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 287);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(776, 120);
            dataGridView2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 8;
            label4.Text = "Frais Forfait";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 263);
            label5.Name = "label5";
            label5.Size = new Size(129, 21);
            label5.TabIndex = 9;
            label5.Text = "Frais Hors Forfait";
            // 
            // btnAjoutForfait
            // 
            btnAjoutForfait.Location = new Point(12, 211);
            btnAjoutForfait.Name = "btnAjoutForfait";
            btnAjoutForfait.Size = new Size(75, 23);
            btnAjoutForfait.TabIndex = 10;
            btnAjoutForfait.Text = "Ajouter";
            btnAjoutForfait.UseVisualStyleBackColor = true;
            // 
            // btnModifForfait
            // 
            btnModifForfait.Location = new Point(93, 211);
            btnModifForfait.Name = "btnModifForfait";
            btnModifForfait.Size = new Size(75, 23);
            btnModifForfait.TabIndex = 11;
            btnModifForfait.Text = "Modifier";
            btnModifForfait.UseVisualStyleBackColor = true;
            // 
            // btnSupprForfait
            // 
            btnSupprForfait.Location = new Point(174, 211);
            btnSupprForfait.Name = "btnSupprForfait";
            btnSupprForfait.Size = new Size(75, 23);
            btnSupprForfait.TabIndex = 12;
            btnSupprForfait.Text = "Supprimer";
            btnSupprForfait.UseVisualStyleBackColor = true;
            // 
            // btnAjoutHorsForfait
            // 
            btnAjoutHorsForfait.Location = new Point(12, 413);
            btnAjoutHorsForfait.Name = "btnAjoutHorsForfait";
            btnAjoutHorsForfait.Size = new Size(75, 23);
            btnAjoutHorsForfait.TabIndex = 13;
            btnAjoutHorsForfait.Text = "Ajouter";
            btnAjoutHorsForfait.UseVisualStyleBackColor = true;
            // 
            // btnModifHorsForfait
            // 
            btnModifHorsForfait.Location = new Point(93, 413);
            btnModifHorsForfait.Name = "btnModifHorsForfait";
            btnModifHorsForfait.Size = new Size(75, 23);
            btnModifHorsForfait.TabIndex = 14;
            btnModifHorsForfait.Text = "Modifier";
            btnModifHorsForfait.UseVisualStyleBackColor = true;
            // 
            // btnSupprHorsForfait
            // 
            btnSupprHorsForfait.Location = new Point(174, 413);
            btnSupprHorsForfait.Name = "btnSupprHorsForfait";
            btnSupprHorsForfait.Size = new Size(75, 23);
            btnSupprHorsForfait.TabIndex = 15;
            btnSupprHorsForfait.Text = "Supprimer";
            btnSupprHorsForfait.UseVisualStyleBackColor = true;
            // 
            // FM3AjoutModif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSupprHorsForfait);
            Controls.Add(btnModifHorsForfait);
            Controls.Add(btnAjoutHorsForfait);
            Controls.Add(btnSupprForfait);
            Controls.Add(btnModifForfait);
            Controls.Add(btnAjoutForfait);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(matricule);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datePicker);
            Controls.Add(name);
            Name = "FM3AjoutModif";
            Text = "FM3AjoutModif";
            Load += FM3AjoutModif_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsLigneForfait).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsLigneHorsForfait).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private DateTimePicker datePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label matricule;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label5;
        private Button btnAjoutForfait;
        private Button btnModifForfait;
        private Button btnSupprForfait;
        private Button btnAjoutHorsForfait;
        private Button btnModifHorsForfait;
        private Button btnSupprHorsForfait;
        private BindingSource bsLigneForfait;
        private BindingSource bsLigneHorsForfait;
    }
}