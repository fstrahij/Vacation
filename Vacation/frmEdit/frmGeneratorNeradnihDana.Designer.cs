namespace Vacation
{
    partial class GeneratorNeradnihDanaForm
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
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Odabir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.btnDodajTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.groupBoxAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Controls.Add(this.checkBoxAll);
            this.groupBoxAll.Controls.Add(this.dataGridView1);
            this.groupBoxAll.Location = new System.Drawing.Point(51, 117);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(694, 321);
            this.groupBoxAll.TabIndex = 0;
            this.groupBoxAll.TabStop = false;
            this.groupBoxAll.Text = "Odabir neradnih dana";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(86, 36);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAll.TabIndex = 1;
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.Click += new System.EventHandler(this.CheckBoxAllClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Odabir,
            this.Id,
            this.TipId,
            this.Naziv,
            this.Datum,
            this.Tip});
            this.dataGridView1.Location = new System.Drawing.Point(26, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // Odabir
            // 
            this.Odabir.FalseValue = "";
            this.Odabir.HeaderText = "";
            this.Odabir.Name = "Odabir";
            this.Odabir.TrueValue = "";
            this.Odabir.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // TipId
            // 
            this.TipId.HeaderText = "TipId";
            this.TipId.Name = "TipId";
            this.TipId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 340;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGeneriraj);
            this.groupBox2.Controls.Add(this.btnDodajTemplate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtGodina);
            this.groupBox2.Location = new System.Drawing.Point(51, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odabir godine";
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Location = new System.Drawing.Point(430, 29);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(93, 23);
            this.btnGeneriraj.TabIndex = 1;
            this.btnGeneriraj.Text = "Generiraj";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            this.btnGeneriraj.Click += new System.EventHandler(this.GenerirajNeradneDaneClick);
            // 
            // btnDodajTemplate
            // 
            this.btnDodajTemplate.Location = new System.Drawing.Point(301, 29);
            this.btnDodajTemplate.Name = "btnDodajTemplate";
            this.btnDodajTemplate.Size = new System.Drawing.Size(104, 23);
            this.btnDodajTemplate.TabIndex = 2;
            this.btnDodajTemplate.Text = "Dodaj template";
            this.btnDodajTemplate.UseVisualStyleBackColor = true;
            this.btnDodajTemplate.Click += new System.EventHandler(this.DodajTemplateClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Godina:";
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(154, 32);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(124, 20);
            this.txtGodina.TabIndex = 0;
            // 
            // GeneratorNeradnihDanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxAll);
            this.Name = "GeneratorNeradnihDanaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAll.ResumeLayout(false);
            this.groupBoxAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajTemplate;
        private System.Windows.Forms.Button btnGeneriraj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odabir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
    }
}

