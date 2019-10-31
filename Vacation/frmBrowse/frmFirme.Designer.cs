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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSpol = new System.Windows.Forms.TextBox();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.comboBoxZaposlenici = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeaktiviraj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnDeaktivirajSve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSpol
            // 
            this.txtSpol.Enabled = false;
            this.txtSpol.Location = new System.Drawing.Point(82, 123);
            this.txtSpol.Name = "txtSpol";
            this.txtSpol.Size = new System.Drawing.Size(206, 20);
            this.txtSpol.TabIndex = 17;
            // 
            // txtOib
            // 
            this.txtOib.Enabled = false;
            this.txtOib.Location = new System.Drawing.Point(82, 81);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(206, 20);
            this.txtOib.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "OIB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
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
            this.groupBox3.Location = new System.Drawing.Point(20, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 181);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o zaposleniku";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Enabled = false;
            this.txtAdresa.Location = new System.Drawing.Point(82, 40);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(206, 20);
            this.txtAdresa.TabIndex = 12;
            // 
            // comboBoxZaposlenici
            // 
            this.comboBoxZaposlenici.FormattingEnabled = true;
            this.comboBoxZaposlenici.Location = new System.Drawing.Point(29, 31);
            this.comboBoxZaposlenici.Name = "comboBoxZaposlenici";
            this.comboBoxZaposlenici.Size = new System.Drawing.Size(175, 21);
            this.comboBoxZaposlenici.TabIndex = 0;
            this.comboBoxZaposlenici.SelectedIndexChanged += new System.EventHandler(this.ZaposlenikSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxZaposlenici);
            this.groupBox1.Location = new System.Drawing.Point(20, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 79);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir zaposlenika";
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.Location = new System.Drawing.Point(727, 29);
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(77, 23);
            this.btnDeaktiviraj.TabIndex = 12;
            this.btnDeaktiviraj.Text = "Deaktiviraj Sve";
            this.btnDeaktiviraj.UseVisualStyleBackColor = true;
            this.btnDeaktiviraj.Click += new System.EventHandler(this.DeaktivirajClick);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(119, 29);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(88, 23);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.UrediClick);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(25, 29);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(88, 23);
            this.btnNovi.TabIndex = 10;
            this.btnNovi.Text = "Novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.NoviClick);
            // 
            // btnDeaktivirajSve
            // 
            this.btnDeaktivirajSve.Location = new System.Drawing.Point(810, 29);
            this.btnDeaktivirajSve.Name = "btnDeaktivirajSve";
            this.btnDeaktivirajSve.Size = new System.Drawing.Size(88, 23);
            this.btnDeaktivirajSve.TabIndex = 9;
            this.btnDeaktivirajSve.Text = "Deaktiviraj Sve";
            this.btnDeaktivirajSve.UseVisualStyleBackColor = true;
            this.btnDeaktivirajSve.Click += new System.EventHandler(this.DeaktivirajSveClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(25, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(873, 310);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeaktiviraj);
            this.groupBox2.Controls.Add(this.btnUredi);
            this.groupBox2.Controls.Add(this.btnNovi);
            this.groupBox2.Controls.Add(this.btnDeaktivirajSve);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(351, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 416);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firme";
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
            this.DatumOd.HeaderText = "DatumOd";
            this.DatumOd.Name = "DatumOd";
            this.DatumOd.ReadOnly = true;
            this.DatumOd.Width = 120;
            // 
            // DatumDo
            // 
            this.DatumDo.HeaderText = "DatumDo";
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.ReadOnly = true;
            this.DatumDo.Width = 120;
            // 
            // Godina
            // 
            this.Godina.HeaderText = "Godina";
            this.Godina.Name = "Godina";
            this.Godina.ReadOnly = true;
            this.Godina.Width = 80;
            // 
            // Mjesec
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Mjesec.DefaultCellStyle = dataGridViewCellStyle3;
            this.Mjesec.HeaderText = "Mjesec";
            this.Mjesec.Name = "Mjesec";
            this.Mjesec.ReadOnly = true;
            this.Mjesec.Width = 80;
            // 
            // Dan
            // 
            this.Dan.HeaderText = "Dan";
            this.Dan.Name = "Dan";
            this.Dan.ReadOnly = true;
            this.Dan.Width = 80;
            // 
            // ZbrojGodina
            // 
            this.ZbrojGodina.HeaderText = "ZbrojGodina";
            this.ZbrojGodina.Name = "ZbrojGodina";
            this.ZbrojGodina.ReadOnly = true;
            this.ZbrojGodina.Width = 80;
            // 
            // ZbrojMjesec
            // 
            this.ZbrojMjesec.HeaderText = "ZbrojMjesec";
            this.ZbrojMjesec.Name = "ZbrojMjesec";
            this.ZbrojMjesec.ReadOnly = true;
            this.ZbrojMjesec.Width = 80;
            // 
            // ZbrojDan
            // 
            this.ZbrojDan.HeaderText = "ZbrojDan";
            this.ZbrojDan.Name = "ZbrojDan";
            this.ZbrojDan.ReadOnly = true;
            this.ZbrojDan.Width = 80;
            // 
            // frmFirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFirme";
            this.Text = "Firme";
            this.Load += new System.EventHandler(this.frmFirme_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpol;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.ComboBox comboBoxZaposlenici;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeaktiviraj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnDeaktivirajSve;
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
    }
}