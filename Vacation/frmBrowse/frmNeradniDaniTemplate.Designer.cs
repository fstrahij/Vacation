namespace Vacation
{
    partial class TemplateEditorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeaktiviraj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnDeaktivirajSve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeaktiviraj);
            this.groupBox1.Controls.Add(this.btnUredi);
            this.groupBox1.Controls.Add(this.btnNovi);
            this.groupBox1.Controls.Add(this.btnDeaktivirajSve);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 484);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neradni dani template";
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.Location = new System.Drawing.Point(712, 25);
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(77, 23);
            this.btnDeaktiviraj.TabIndex = 7;
            this.btnDeaktiviraj.Text = "Deaktiviraj Sve";
            this.btnDeaktiviraj.UseVisualStyleBackColor = true;
            this.btnDeaktiviraj.Click += new System.EventHandler(this.DeaktivirajClick);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(154, 25);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(88, 23);
            this.btnUredi.TabIndex = 6;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.UrediClick);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(45, 25);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(88, 23);
            this.btnNovi.TabIndex = 5;
            this.btnNovi.Text = "Novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.NoviClick);
            // 
            // btnDeaktivirajSve
            // 
            this.btnDeaktivirajSve.Location = new System.Drawing.Point(810, 25);
            this.btnDeaktivirajSve.Name = "btnDeaktivirajSve";
            this.btnDeaktivirajSve.Size = new System.Drawing.Size(88, 23);
            this.btnDeaktivirajSve.TabIndex = 4;
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
            this.TipId,
            this.Naziv,
            this.Dan,
            this.Mjesec,
            this.Tip});
            this.dataGridView1.Location = new System.Drawing.Point(45, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(853, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // TipId
            // 
            this.TipId.HeaderText = "TipID";
            this.TipId.Name = "TipId";
            this.TipId.ReadOnly = true;
            this.TipId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 440;
            // 
            // Dan
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dan.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dan.HeaderText = "Dan";
            this.Dan.Name = "Dan";
            this.Dan.ReadOnly = true;
            // 
            // Mjesec
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Mjesec.DefaultCellStyle = dataGridViewCellStyle2;
            this.Mjesec.HeaderText = "Mjesec";
            this.Mjesec.Name = "Mjesec";
            this.Mjesec.ReadOnly = true;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(843, 550);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 21;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // TemplateEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 585);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.groupBox1);
            this.Name = "TemplateEditorForm";
            this.Text = "Predlošci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TemplateEditorForm_FormClosed);
            this.Load += new System.EventHandler(this.TemplateEditorForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeaktiviraj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnDeaktivirajSve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
    }
}