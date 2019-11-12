namespace Vacation.frmEdit
{
    partial class frmZaposlenikDodaciEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGodinaPrava = new System.Windows.Forms.TextBox();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDodatak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGodinaPrava);
            this.groupBox1.Controls.Add(this.txtBrojDana);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxDodatak);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(20, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predložak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Godina prava";
            // 
            // txtGodinaPrava
            // 
            this.txtGodinaPrava.Enabled = false;
            this.txtGodinaPrava.Location = new System.Drawing.Point(124, 152);
            this.txtGodinaPrava.Name = "txtGodinaPrava";
            this.txtGodinaPrava.Size = new System.Drawing.Size(121, 20);
            this.txtGodinaPrava.TabIndex = 11;
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.Enabled = false;
            this.txtBrojDana.Location = new System.Drawing.Point(124, 110);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.Size = new System.Drawing.Size(121, 20);
            this.txtBrojDana.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Broj dana";
            // 
            // comboBoxDodatak
            // 
            this.comboBoxDodatak.FormattingEnabled = true;
            this.comboBoxDodatak.Location = new System.Drawing.Point(124, 69);
            this.comboBoxDodatak.Name = "comboBoxDodatak";
            this.comboBoxDodatak.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDodatak.TabIndex = 8;
            this.comboBoxDodatak.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDodatak_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dodatak";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SpremiClick);
            // 
            // frmZaposlenikDodaciEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmZaposlenikDodaciEditor";
            this.Text = "frmZaposlenikDodaciEditor";
            this.Load += new System.EventHandler(this.frmZaposlenikDodaciEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDodatak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGodinaPrava;
        private System.Windows.Forms.TextBox txtBrojDana;
        private System.Windows.Forms.Label label2;
    }
}