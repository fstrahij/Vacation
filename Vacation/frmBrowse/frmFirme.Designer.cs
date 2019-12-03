namespace Vacation.frmBrowse
{
    partial class frmFirme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirme));
            this.txtSpol = new System.Windows.Forms.TextBox();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZbrojGodina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZbrojMjesec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZbrojDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovi = new System.Windows.Forms.ToolStripButton();
            this.btnUredi = new System.Windows.Forms.ToolStripButton();
            this.btnZatvori = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeaktivirajSve = new System.Windows.Forms.ToolStripButton();
            this.btnDeaktiviraj = new System.Windows.Forms.ToolStripButton();
            this.txtAdresa = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSpol
            // 
            this.txtSpol.Enabled = false;
            this.txtSpol.Location = new System.Drawing.Point(58, 270);
            this.txtSpol.Name = "txtSpol";
            this.txtSpol.Size = new System.Drawing.Size(120, 22);
            this.txtSpol.TabIndex = 17;
            // 
            // txtOib
            // 
            this.txtOib.Enabled = false;
            this.txtOib.Location = new System.Drawing.Point(58, 228);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(120, 22);
            this.txtOib.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "OIB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Spol";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAdresa);
            this.groupBox3.Controls.Add(this.txtPrezime);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtIme);
            this.groupBox3.Controls.Add(this.txtSpol);
            this.groupBox3.Controls.Add(this.txtOib);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(20, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 378);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o zaposleniku";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Enabled = false;
            this.txtPrezime.Location = new System.Drawing.Point(58, 83);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(120, 22);
            this.txtPrezime.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Enabled = false;
            this.txtIme.Location = new System.Drawing.Point(58, 42);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(120, 22);
            this.txtIme.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.DatumOd,
            this.DatumDo,
            this.Godina,
            this.Mjesec,
            this.Dan,
            this.ZbrojGodina,
            this.ZbrojMjesec,
            this.ZbrojDan});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 361);
            this.dataGridView1.TabIndex = 8;
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
            // DatumOd
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DatumOd.DefaultCellStyle = dataGridViewCellStyle20;
            this.DatumOd.HeaderText = "Datum od";
            this.DatumOd.Name = "DatumOd";
            this.DatumOd.ReadOnly = true;
            // 
            // DatumDo
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DatumDo.DefaultCellStyle = dataGridViewCellStyle21;
            this.DatumDo.HeaderText = "Datum do";
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.ReadOnly = true;
            // 
            // Godina
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Godina.DefaultCellStyle = dataGridViewCellStyle22;
            this.Godina.HeaderText = "Godina";
            this.Godina.Name = "Godina";
            this.Godina.ReadOnly = true;
            // 
            // Mjesec
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Mjesec.DefaultCellStyle = dataGridViewCellStyle23;
            this.Mjesec.HeaderText = "Mjesec";
            this.Mjesec.Name = "Mjesec";
            this.Mjesec.ReadOnly = true;
            // 
            // Dan
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dan.DefaultCellStyle = dataGridViewCellStyle24;
            this.Dan.HeaderText = "Dan";
            this.Dan.Name = "Dan";
            this.Dan.ReadOnly = true;
            // 
            // ZbrojGodina
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ZbrojGodina.DefaultCellStyle = dataGridViewCellStyle25;
            this.ZbrojGodina.HeaderText = "Zbroj godina";
            this.ZbrojGodina.Name = "ZbrojGodina";
            this.ZbrojGodina.ReadOnly = true;
            // 
            // ZbrojMjesec
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ZbrojMjesec.DefaultCellStyle = dataGridViewCellStyle26;
            this.ZbrojMjesec.HeaderText = "Zbroj mjeseci";
            this.ZbrojMjesec.Name = "ZbrojMjesec";
            this.ZbrojMjesec.ReadOnly = true;
            // 
            // ZbrojDan
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ZbrojDan.DefaultCellStyle = dataGridViewCellStyle27;
            this.ZbrojDan.HeaderText = "Zbroj dana";
            this.ZbrojDan.Name = "ZbrojDan";
            this.ZbrojDan.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(238, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 391);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zaposlenja";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 361);
            this.panel1.TabIndex = 9;
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
            this.toolStrip1.Size = new System.Drawing.Size(1033, 50);
            this.toolStrip1.TabIndex = 24;
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
            // btnZatvori
            // 
            this.btnZatvori.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnZatvori.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZatvori.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvori.Image")));
            this.btnZatvori.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(39, 47);
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.Click += new System.EventHandler(this.ZatvoriClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
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
            // txtAdresa
            // 
            this.txtAdresa.Enabled = false;
            this.txtAdresa.Location = new System.Drawing.Point(58, 126);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(120, 96);
            this.txtAdresa.TabIndex = 25;
            this.txtAdresa.Text = "";
            // 
            // frmFirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1033, 468);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFirme";
            this.Text = "Zaposlenja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFirme_FormClosed);
            this.Load += new System.EventHandler(this.frmFirme_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpol;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZbrojGodina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZbrojMjesec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZbrojDan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovi;
        private System.Windows.Forms.ToolStripButton btnUredi;
        private System.Windows.Forms.ToolStripButton btnDeaktiviraj;
        private System.Windows.Forms.ToolStripButton btnDeaktivirajSve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnZatvori;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtAdresa;
    }
}