namespace GitWarriors_AP
{
    partial class FMenu
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
            menuStrip1 = new MenuStrip();
            m1ToolStripMenuItem = new ToolStripMenuItem();
            m2ToolStripMenuItem = new ToolStripMenuItem();
            m3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { m1ToolStripMenuItem, m2ToolStripMenuItem, m3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // m1ToolStripMenuItem
            // 
            m1ToolStripMenuItem.Name = "m1ToolStripMenuItem";
            m1ToolStripMenuItem.Size = new Size(36, 20);
            m1ToolStripMenuItem.Text = "M1";
            // 
            // m2ToolStripMenuItem
            // 
            m2ToolStripMenuItem.Name = "m2ToolStripMenuItem";
            m2ToolStripMenuItem.Size = new Size(36, 20);
            m2ToolStripMenuItem.Text = "M2";
            // 
            // m3ToolStripMenuItem
            // 
            m3ToolStripMenuItem.Name = "m3ToolStripMenuItem";
            m3ToolStripMenuItem.Size = new Size(36, 20);
            m3ToolStripMenuItem.Text = "M3";
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMenu";
            Text = "FMenu";
            Load += FMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem m1ToolStripMenuItem;
        private ToolStripMenuItem m2ToolStripMenuItem;
        private ToolStripMenuItem m3ToolStripMenuItem;
    }
}