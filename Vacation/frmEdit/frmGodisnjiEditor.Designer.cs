﻿namespace Vacation.frmEdit
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNoviGodisnji = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStariGodisnji = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNeiskoristenoNovi = new System.Windows.Forms.TextBox();
            this.txtNeiskoristenoStari = new System.Windows.Forms.TextBox();
            this.txtUkupnoNovi = new System.Windows.Forms.TextBox();
            this.txtUkupnoStari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUkupnoNovi);
            this.groupBox2.Controls.Add(this.txtUkupnoStari);
            this.groupBox2.Controls.Add(this.txtNeiskoristenoNovi);
            this.groupBox2.Controls.Add(this.txtNeiskoristenoStari);
            this.groupBox2.Controls.Add(this.txtNoviGodisnji);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtStariGodisnji);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpDatumDo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpDatumOd);
            this.groupBox2.Controls.Add(this.txtBrojDana);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSpremi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(56, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 387);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odabir godišnjeg";
            // 
            // txtNoviGodisnji
            // 
            this.txtNoviGodisnji.Enabled = false;
            this.txtNoviGodisnji.Location = new System.Drawing.Point(387, 93);
            this.txtNoviGodisnji.Name = "txtNoviGodisnji";
            this.txtNoviGodisnji.Size = new System.Drawing.Size(44, 20);
            this.txtNoviGodisnji.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Novi Godišnji Broj dana";
            // 
            // txtStariGodisnji
            // 
            this.txtStariGodisnji.Enabled = false;
            this.txtStariGodisnji.Location = new System.Drawing.Point(387, 131);
            this.txtStariGodisnji.Name = "txtStariGodisnji";
            this.txtStariGodisnji.Size = new System.Drawing.Size(44, 20);
            this.txtStariGodisnji.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stari Godišnji Broj dana";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(320, 241);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumDo.TabIndex = 9;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum Do";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(320, 201);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumOd.TabIndex = 7;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.Enabled = false;
            this.txtBrojDana.Location = new System.Drawing.Point(320, 280);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.Size = new System.Drawing.Size(121, 20);
            this.txtBrojDana.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj dana";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(292, 327);
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
            this.label1.Location = new System.Drawing.Point(264, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum Od";
            // 
            // txtNeiskoristenoNovi
            // 
            this.txtNeiskoristenoNovi.Enabled = false;
            this.txtNeiskoristenoNovi.Location = new System.Drawing.Point(276, 93);
            this.txtNeiskoristenoNovi.Name = "txtNeiskoristenoNovi";
            this.txtNeiskoristenoNovi.Size = new System.Drawing.Size(44, 20);
            this.txtNeiskoristenoNovi.TabIndex = 15;
            // 
            // txtNeiskoristenoStari
            // 
            this.txtNeiskoristenoStari.Enabled = false;
            this.txtNeiskoristenoStari.Location = new System.Drawing.Point(276, 131);
            this.txtNeiskoristenoStari.Name = "txtNeiskoristenoStari";
            this.txtNeiskoristenoStari.Size = new System.Drawing.Size(44, 20);
            this.txtNeiskoristenoStari.TabIndex = 14;
            // 
            // txtUkupnoNovi
            // 
            this.txtUkupnoNovi.Enabled = false;
            this.txtUkupnoNovi.Location = new System.Drawing.Point(181, 93);
            this.txtUkupnoNovi.Name = "txtUkupnoNovi";
            this.txtUkupnoNovi.Size = new System.Drawing.Size(44, 20);
            this.txtUkupnoNovi.TabIndex = 17;
            // 
            // txtUkupnoStari
            // 
            this.txtUkupnoStari.Enabled = false;
            this.txtUkupnoStari.Location = new System.Drawing.Point(181, 131);
            this.txtUkupnoStari.Name = "txtUkupnoStari";
            this.txtUkupnoStari.Size = new System.Drawing.Size(44, 20);
            this.txtUkupnoStari.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "UKUPNO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "NEISKORIŠTENO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "PREOSTALO";
            // 
            // frmGodisnjiEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmGodisnjiEditor";
            this.Text = "frmGodisnjiEditor";
            this.Load += new System.EventHandler(this.frmGodisnjiEditor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBrojDana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoviGodisnji;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStariGodisnji;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUkupnoNovi;
        private System.Windows.Forms.TextBox txtUkupnoStari;
        private System.Windows.Forms.TextBox txtNeiskoristenoNovi;
        private System.Windows.Forms.TextBox txtNeiskoristenoStari;
    }
}