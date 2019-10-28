namespace Vacation.frmBrowse
{
    partial class frmGodisnji
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeaktiviraj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnDeaktivirajSve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxZaposlenici = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposlenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposlenikGodisnjiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnoDana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeaktiviraj);
            this.groupBox2.Controls.Add(this.btnUredi);
            this.groupBox2.Controls.Add(this.btnNovi);
            this.groupBox2.Controls.Add(this.btnDeaktivirajSve);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(304, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 416);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Godišnji";
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.Location = new System.Drawing.Point(558, 29);
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(77, 23);
            this.btnDeaktiviraj.TabIndex = 12;
            this.btnDeaktiviraj.Text = "Deaktiviraj Sve";
            this.btnDeaktiviraj.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(119, 29);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(88, 23);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
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
            this.btnDeaktivirajSve.Location = new System.Drawing.Point(641, 29);
            this.btnDeaktivirajSve.Name = "btnDeaktivirajSve";
            this.btnDeaktivirajSve.Size = new System.Drawing.Size(88, 23);
            this.btnDeaktivirajSve.TabIndex = 9;
            this.btnDeaktivirajSve.Text = "Deaktiviraj Sve";
            this.btnDeaktivirajSve.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ZaposlenikId,
            this.ZaposlenikGodisnjiId,
            this.Adresa,
            this.Oib,
            this.Spol,
            this.DatumOd,
            this.DatumDo,
            this.UkupnoDana,
            this.Godina});
            this.dataGridView1.Location = new System.Drawing.Point(25, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(704, 310);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxZaposlenici);
            this.groupBox1.Location = new System.Drawing.Point(35, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 79);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir zaposlenika";
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
            // ZaposlenikGodisnjiId
            // 
            this.ZaposlenikGodisnjiId.HeaderText = "ZaposlenikGodisnjiId";
            this.ZaposlenikGodisnjiId.Name = "ZaposlenikGodisnjiId";
            this.ZaposlenikGodisnjiId.ReadOnly = true;
            this.ZaposlenikGodisnjiId.Visible = false;
            // 
            // Adresa
            // 
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Oib
            // 
            this.Oib.HeaderText = "Oib";
            this.Oib.Name = "Oib";
            this.Oib.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            this.Spol.Width = 70;
            // 
            // DatumOd
            // 
            this.DatumOd.HeaderText = "DatumOd";
            this.DatumOd.Name = "DatumOd";
            this.DatumOd.ReadOnly = true;
            // 
            // DatumDo
            // 
            this.DatumDo.HeaderText = "DatumDo";
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.ReadOnly = true;
            // 
            // UkupnoDana
            // 
            this.UkupnoDana.HeaderText = "Ukupno Dana";
            this.UkupnoDana.Name = "UkupnoDana";
            this.UkupnoDana.ReadOnly = true;
            // 
            // Godina
            // 
            this.Godina.HeaderText = "Godina";
            this.Godina.Name = "Godina";
            this.Godina.ReadOnly = true;
            // 
            // frmGodisnji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGodisnji";
            this.Text = "frmGodisnji";
            this.Load += new System.EventHandler(this.frmGodisnji_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeaktiviraj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnDeaktivirajSve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxZaposlenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposlenikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposlenikGodisnjiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnoDana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
    }
}