namespace Vacation
{
    partial class TipoviNeradnihDanaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoviNeradnihDanaForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovi = new System.Windows.Forms.ToolStripButton();
            this.btnUredi = new System.Windows.Forms.ToolStripButton();
            this.btnDeaktiviraj = new System.Windows.Forms.ToolStripButton();
            this.btnDeaktivirajSve = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZatvori = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(20, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipovi neradnih dana";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovi,
            this.btnUredi,
            this.toolStripSeparator1,
            this.btnDeaktiviraj,
            this.btnDeaktivirajSve,
            this.toolStripSeparator2,
            this.btnZatvori});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 42);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovi
            // 
            this.btnNovi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovi.Image = ((System.Drawing.Image)(resources.GetObject("btnNovi.Image")));
            this.btnNovi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovi.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(39, 39);
            this.btnNovi.Text = "Novi";
            this.btnNovi.Click += new System.EventHandler(this.NoviClick);
            // 
            // btnUredi
            // 
            this.btnUredi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUredi.Image = ((System.Drawing.Image)(resources.GetObject("btnUredi.Image")));
            this.btnUredi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUredi.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(39, 39);
            this.btnUredi.Text = "Uredi";
            this.btnUredi.Click += new System.EventHandler(this.UrediClick);
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeaktiviraj.Image = ((System.Drawing.Image)(resources.GetObject("btnDeaktiviraj.Image")));
            this.btnDeaktiviraj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeaktiviraj.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(39, 39);
            this.btnDeaktiviraj.Text = "Obriši";
            this.btnDeaktiviraj.Click += new System.EventHandler(this.DeaktivirajClick);
            // 
            // btnDeaktivirajSve
            // 
            this.btnDeaktivirajSve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeaktivirajSve.Image = ((System.Drawing.Image)(resources.GetObject("btnDeaktivirajSve.Image")));
            this.btnDeaktivirajSve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeaktivirajSve.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnDeaktivirajSve.Name = "btnDeaktivirajSve";
            this.btnDeaktivirajSve.Size = new System.Drawing.Size(39, 39);
            this.btnDeaktivirajSve.Text = "Obriši sve";
            this.btnDeaktivirajSve.Click += new System.EventHandler(this.DeaktivirajSveClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // btnZatvori
            // 
            this.btnZatvori.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZatvori.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvori.Image")));
            this.btnZatvori.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(40, 1, 0, 2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(39, 39);
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // TipoviNeradnihDanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TipoviNeradnihDanaForm";
            this.Text = "Tipovi neradnih dana";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TipoviNeradnihDanaForm_FormClosed);
            this.Load += new System.EventHandler(this.TipoviNeradnihDanaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovi;
        private System.Windows.Forms.ToolStripButton btnUredi;
        private System.Windows.Forms.ToolStripButton btnDeaktiviraj;
        private System.Windows.Forms.ToolStripButton btnDeaktivirajSve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnZatvori;
    }
}