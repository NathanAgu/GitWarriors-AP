namespace GitWarriors_AP.Models
{
    partial class FUpdatePassword
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
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtConfPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Mot de passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 56);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirmation";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(117, 24);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtConfPassword
            // 
            txtConfPassword.Location = new Point(117, 53);
            txtConfPassword.Name = "txtConfPassword";
            txtConfPassword.Size = new Size(100, 23);
            txtConfPassword.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(117, 82);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 4;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FUpdatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 134);
            Controls.Add(button1);
            Controls.Add(txtConfPassword);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FUpdatePassword";
            Text = "FUpdatePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtConfPassword;
        private Button button1;
    }
}