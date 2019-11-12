namespace Vacation.frmBrowse
{
    partial class frmZaposlenikDodaci
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.txtSpol = new System.Windows.Forms.TextBox();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxZaposlenici = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeaktiviraj = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnDeaktivirajSve = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposlenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodaciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojDana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaPrava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(960, 471);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 25;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
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
            // txtAdresa
            // 
            this.txtAdresa.Enabled = false;
            this.txtAdresa.Location = new System.Drawing.Point(82, 40);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(206, 20);
            this.txtAdresa.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSpol);
            this.groupBox3.Controls.Add(this.txtOib);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtAdresa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(20, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 180);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o zaposleniku";
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
            // comboBoxZaposlenici
            // 
            this.comboBoxZaposlenici.FormattingEnabled = true;
            this.comboBoxZaposlenici.Location = new System.Drawing.Point(29, 31);
            this.comboBoxZaposlenici.Name = "comboBoxZaposlenici";
            this.comboBoxZaposlenici.Size = new System.Drawing.Size(175, 21);
            this.comboBoxZaposlenici.TabIndex = 0;
            this.comboBoxZaposlenici.SelectionChangeCommitted += new System.EventHandler(this.ZaposlenikSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxZaposlenici);
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 80);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir zaposlenika";
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.Location = new System.Drawing.Point(515, 31);
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(77, 23);
            this.btnDeaktiviraj.TabIndex = 12;
            this.btnDeaktiviraj.Text = "Deaktiviraj Sve";
            this.btnDeaktiviraj.UseVisualStyleBackColor = true;
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(31, 31);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(88, 23);
            this.btnNovi.TabIndex = 10;
            this.btnNovi.Text = "Novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.NoviClick);
            // 
            // btnDeaktivirajSve
            // 
            this.btnDeaktivirajSve.Location = new System.Drawing.Point(598, 31);
            this.btnDeaktivirajSve.Name = "btnDeaktivirajSve";
            this.btnDeaktivirajSve.Size = new System.Drawing.Size(88, 23);
            this.btnDeaktivirajSve.TabIndex = 9;
            this.btnDeaktivirajSve.Text = "Deaktiviraj Sve";
            this.btnDeaktivirajSve.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnDeaktiviraj);
            this.groupBox2.Controls.Add(this.btnNovi);
            this.groupBox2.Controls.Add(this.btnDeaktivirajSve);
            this.groupBox2.Location = new System.Drawing.Point(349, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 405);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Godišnji";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ZaposlenikId,
            this.DodaciId,
            this.Naziv,
            this.BrojDana,
            this.GodinaPrava});
            this.dataGridView1.Location = new System.Drawing.Point(31, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(655, 308);
            this.dataGridView1.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ZaposlenikId
            // 
            this.ZaposlenikId.HeaderText = "ZaposlenikId";
            this.ZaposlenikId.Name = "ZaposlenikId";
            this.ZaposlenikId.ReadOnly = true;
            this.ZaposlenikId.Visible = false;
            // 
            // DodaciId
            // 
            this.DodaciId.HeaderText = "DodaciId";
            this.DodaciId.Name = "DodaciId";
            this.DodaciId.ReadOnly = true;
            this.DodaciId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 200;
            // 
            // BrojDana
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BrojDana.DefaultCellStyle = dataGridViewCellStyle5;
            this.BrojDana.HeaderText = "Broj dana";
            this.BrojDana.Name = "BrojDana";
            this.BrojDana.ReadOnly = true;
            // 
            // GodinaPrava
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GodinaPrava.DefaultCellStyle = dataGridViewCellStyle6;
            this.GodinaPrava.HeaderText = "Godina prava";
            this.GodinaPrava.Name = "GodinaPrava";
            this.GodinaPrava.ReadOnly = true;
            // 
            // frmZaposlenikDodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 570);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmZaposlenikDodaci";
            this.Text = "Zaposlenik-dodaci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmZaposlenikDodaci_FormClosed);
            this.Load += new System.EventHandler(this.frmZaposlenikDodaci_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.TextBox txtSpol;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxZaposlenici;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeaktiviraj;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnDeaktivirajSve;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposlenikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodaciId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojDana;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaPrava;
    }
}