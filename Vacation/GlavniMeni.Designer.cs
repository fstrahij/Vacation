namespace Vacation
{
    partial class GlavniMeni
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godišnjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neradniDaniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templejtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniciToolStripMenuItem,
            this.godišnjiToolStripMenuItem,
            this.neradniDaniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // godišnjiToolStripMenuItem
            // 
            this.godišnjiToolStripMenuItem.Name = "godišnjiToolStripMenuItem";
            this.godišnjiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.godišnjiToolStripMenuItem.Text = "Godišnji";
            // 
            // neradniDaniToolStripMenuItem
            // 
            this.neradniDaniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.templejtiToolStripMenuItem,
            this.tipoviToolStripMenuItem});
            this.neradniDaniToolStripMenuItem.Name = "neradniDaniToolStripMenuItem";
            this.neradniDaniToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.neradniDaniToolStripMenuItem.Text = "Neradni Dani";
            // 
            // noviToolStripMenuItem
            // 
            this.noviToolStripMenuItem.Name = "noviToolStripMenuItem";
            this.noviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noviToolStripMenuItem.Text = "Novi";
            this.noviToolStripMenuItem.Click += new System.EventHandler(this.noviToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // templejtiToolStripMenuItem
            // 
            this.templejtiToolStripMenuItem.Name = "templejtiToolStripMenuItem";
            this.templejtiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.templejtiToolStripMenuItem.Text = "Templejti";
            this.templejtiToolStripMenuItem.Click += new System.EventHandler(this.templejtiToolStripMenuItem_Click);
            // 
            // tipoviToolStripMenuItem
            // 
            this.tipoviToolStripMenuItem.Name = "tipoviToolStripMenuItem";
            this.tipoviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoviToolStripMenuItem.Text = "Tipovi";
            this.tipoviToolStripMenuItem.Click += new System.EventHandler(this.tipoviToolStripMenuItem_Click);
            // 
            // GlavniMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavniMeni";
            this.Text = "GlavniMeni";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem godišnjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neradniDaniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templejtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoviToolStripMenuItem;
    }
}