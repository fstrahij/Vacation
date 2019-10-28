namespace Vacation.frmEdit
{
    partial class frmGodisnjiEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxZaposlenici = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.txtRaspoloziviBrojDana = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxZaposlenici);
            this.groupBox1.Location = new System.Drawing.Point(57, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 79);
            this.groupBox1.TabIndex = 18;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDatumDo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpDatumOd);
            this.groupBox2.Controls.Add(this.txtRaspoloziviBrojDana);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBrojDana);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSpremi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(350, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 318);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odabir godišnjeg";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Enabled = false;
            this.dtpDatumDo.Location = new System.Drawing.Point(157, 135);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumDo.TabIndex = 9;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum Do";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Enabled = false;
            this.dtpDatumOd.Location = new System.Drawing.Point(157, 95);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumOd.TabIndex = 7;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // txtRaspoloziviBrojDana
            // 
            this.txtRaspoloziviBrojDana.Enabled = false;
            this.txtRaspoloziviBrojDana.Location = new System.Drawing.Point(157, 55);
            this.txtRaspoloziviBrojDana.Name = "txtRaspoloziviBrojDana";
            this.txtRaspoloziviBrojDana.Size = new System.Drawing.Size(121, 20);
            this.txtRaspoloziviBrojDana.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raspoloživi broj dana";
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.Enabled = false;
            this.txtBrojDana.Location = new System.Drawing.Point(157, 174);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.Size = new System.Drawing.Size(121, 20);
            this.txtBrojDana.TabIndex = 4;
            this.txtBrojDana.TextChanged += new System.EventHandler(this.txtBrojDana_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj dana";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(129, 236);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.SpremiClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum Od";
            // 
            // frmGodisnjiEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmGodisnjiEditor";
            this.Text = "frmGodisnjiEditor";
            this.Load += new System.EventHandler(this.frmGodisnjiEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxZaposlenici;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBrojDana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaspoloziviBrojDana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label label4;
    }
}