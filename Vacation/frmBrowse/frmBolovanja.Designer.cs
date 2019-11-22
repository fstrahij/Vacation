namespace Vacation.frmBrowse
{
    partial class frmBolovanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBolovanja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnZatvori = new System.Windows.Forms.ToolStripButton();
            this.btnDeaktivirajSve = new System.Windows.Forms.ToolStripButton();
            this.btnDeaktiviraj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUredi = new System.Windows.Forms.ToolStripButton();
            this.btnNovi = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSpol = new System.Windows.Forms.TextBox();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxZaposlenici = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojDana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnoBrojDana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
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
            this.toolStrip1.Size = new System.Drawing.Size(1101, 42);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(350, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 405);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bolovanja";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DatumOd,
            this.DatumDo,
            this.BrojDana,
            this.Opis,
            this.UkupnoBrojDana});
            this.dataGridView1.Location = new System.Drawing.Point(25, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(669, 355);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtSpol
            // 
            this.txtSpol.Enabled = false;
            this.txtSpol.Location = new System.Drawing.Point(82, 123);
            this.txtSpol.Name = "txtSpol";
            this.txtSpol.Size = new System.Drawing.Size(206, 22);
            this.txtSpol.TabIndex = 17;
            // 
            // txtOib
            // 
            this.txtOib.Enabled = false;
            this.txtOib.Location = new System.Drawing.Point(82, 81);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(206, 22);
            this.txtOib.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "OIB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Enabled = false;
            this.txtAdresa.Location = new System.Drawing.Point(82, 40);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(206, 22);
            this.txtAdresa.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Spol";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSpol);
            this.groupBox3.Controls.Add(this.txtOib);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtAdresa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(20, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 180);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o zaposleniku";
            // 
            // comboBoxZaposlenici
            // 
            this.comboBoxZaposlenici.FormattingEnabled = true;
            this.comboBoxZaposlenici.Location = new System.Drawing.Point(29, 31);
            this.comboBoxZaposlenici.Name = "comboBoxZaposlenici";
            this.comboBoxZaposlenici.Size = new System.Drawing.Size(175, 24);
            this.comboBoxZaposlenici.TabIndex = 0;
            this.comboBoxZaposlenici.SelectionChangeCommitted += new System.EventHandler(this.ZaposlenikSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxZaposlenici);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(20, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 80);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir zaposlenika";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DatumOd
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DatumOd.DefaultCellStyle = dataGridViewCellStyle1;
            this.DatumOd.HeaderText = "Datum od";
            this.DatumOd.Name = "DatumOd";
            this.DatumOd.ReadOnly = true;
            this.DatumOd.Width = 120;
            // 
            // DatumDo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DatumDo.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatumDo.HeaderText = "Datum do";
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.ReadOnly = true;
            this.DatumDo.Width = 120;
            // 
            // BrojDana
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BrojDana.DefaultCellStyle = dataGridViewCellStyle3;
            this.BrojDana.HeaderText = "Broj Dana";
            this.BrojDana.Name = "BrojDana";
            this.BrojDana.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.FillWeight = 200F;
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 200;
            // 
            // UkupnoBrojDana
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UkupnoBrojDana.DefaultCellStyle = dataGridViewCellStyle4;
            this.UkupnoBrojDana.HeaderText = "Ukupno broj dana";
            this.UkupnoBrojDana.Name = "UkupnoBrojDana";
            this.UkupnoBrojDana.ReadOnly = true;
            // 
            // frmBolovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 624);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBolovanja";
            this.Text = "Bolovanja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBolovanja_FormClosed);
            this.Load += new System.EventHandler(this.frmBolovanja_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnZatvori;
        private System.Windows.Forms.ToolStripButton btnDeaktivirajSve;
        private System.Windows.Forms.ToolStripButton btnDeaktiviraj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUredi;
        private System.Windows.Forms.ToolStripButton btnNovi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSpol;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxZaposlenici;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojDana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnoBrojDana;
    }
}