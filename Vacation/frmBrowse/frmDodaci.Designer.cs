namespace Vacation.frmBrowse
{
    partial class frmDodaci
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodaci));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojDana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaPrava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovi = new System.Windows.Forms.ToolStripButton();
            this.btnUredi = new System.Windows.Forms.ToolStripButton();
            this.btnDeaktiviraj = new System.Windows.Forms.ToolStripButton();
            this.btnDeaktivirajSve = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZatvori = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaci na godišnji";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.BrojDana,
            this.GodinaPrava});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // BrojDana
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BrojDana.DefaultCellStyle = dataGridViewCellStyle2;
            this.BrojDana.HeaderText = "Broj dana";
            this.BrojDana.Name = "BrojDana";
            this.BrojDana.ReadOnly = true;
            // 
            // GodinaPrava
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GodinaPrava.DefaultCellStyle = dataGridViewCellStyle3;
            this.GodinaPrava.HeaderText = "Godina prava";
            this.GodinaPrava.Name = "GodinaPrava";
            this.GodinaPrava.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovi,
            this.btnUredi,
            this.btnZatvori,
            this.toolStripSeparator2,
            this.btnDeaktivirajSve,
            this.btnDeaktiviraj});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 50);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovi
            // 
            this.btnNovi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovi.Image = ((System.Drawing.Image)(resources.GetObject("btnNovi.Image")));
            this.btnNovi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovi.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(39, 47);
            this.btnNovi.Text = "Novi";
            this.btnNovi.Click += new System.EventHandler(this.NoviClick);
            // 
            // btnUredi
            // 
            this.btnUredi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUredi.Image = ((System.Drawing.Image)(resources.GetObject("btnUredi.Image")));
            this.btnUredi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUredi.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(39, 47);
            this.btnUredi.Text = "Uredi";
            this.btnUredi.Click += new System.EventHandler(this.UrediClick);
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDeaktiviraj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeaktiviraj.Image = ((System.Drawing.Image)(resources.GetObject("btnDeaktiviraj.Image")));
            this.btnDeaktiviraj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeaktiviraj.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(39, 47);
            this.btnDeaktiviraj.Text = "Obriši";
            this.btnDeaktiviraj.Click += new System.EventHandler(this.DeaktivirajClick);
            // 
            // btnDeaktivirajSve
            // 
            this.btnDeaktivirajSve.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDeaktivirajSve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeaktivirajSve.Image = ((System.Drawing.Image)(resources.GetObject("btnDeaktivirajSve.Image")));
            this.btnDeaktivirajSve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeaktivirajSve.Name = "btnDeaktivirajSve";
            this.btnDeaktivirajSve.Size = new System.Drawing.Size(39, 47);
            this.btnDeaktivirajSve.Text = "Obriši sve";
            this.btnDeaktivirajSve.Click += new System.EventHandler(this.DeaktivirajSveClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnZatvori.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZatvori.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvori.Image")));
            this.btnZatvori.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(39, 47);
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmDodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDodaci";
            this.Text = "Dodaci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dodaci_FormClosed);
            this.Load += new System.EventHandler(this.frmTipoviGodisnjih_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojDana;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaPrava;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovi;
        private System.Windows.Forms.ToolStripButton btnUredi;
        private System.Windows.Forms.ToolStripButton btnDeaktiviraj;
        private System.Windows.Forms.ToolStripButton btnDeaktivirajSve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnZatvori;
    }
}