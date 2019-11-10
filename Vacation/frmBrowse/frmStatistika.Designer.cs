namespace Vacation.frmBrowse
{
    partial class frmStatistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartGodisnji = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbGodina = new System.Windows.Forms.GroupBox();
            this.comboBoxGodina = new System.Windows.Forms.ComboBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartGodisnji)).BeginInit();
            this.gbGodina.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartGodisnji
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGodisnji.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGodisnji.Legends.Add(legend3);
            this.chartGodisnji.Location = new System.Drawing.Point(30, 31);
            this.chartGodisnji.Name = "chartGodisnji";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Mjesec";
            series3.XValueMember = "Siječanj";
            series3.YValueMembers = "200";
            this.chartGodisnji.Series.Add(series3);
            this.chartGodisnji.Size = new System.Drawing.Size(894, 516);
            this.chartGodisnji.TabIndex = 0;
            this.chartGodisnji.Text = "chartGodisnji";
            title3.Name = "Mjesečni prikaz godišnjih po godinama";
            this.chartGodisnji.Titles.Add(title3);
            // 
            // gbGodina
            // 
            this.gbGodina.Controls.Add(this.comboBoxGodina);
            this.gbGodina.Location = new System.Drawing.Point(20, 60);
            this.gbGodina.Name = "gbGodina";
            this.gbGodina.Size = new System.Drawing.Size(230, 80);
            this.gbGodina.TabIndex = 16;
            this.gbGodina.TabStop = false;
            this.gbGodina.Text = "Odabir godine";
            // 
            // comboBoxGodina
            // 
            this.comboBoxGodina.FormattingEnabled = true;
            this.comboBoxGodina.Location = new System.Drawing.Point(29, 31);
            this.comboBoxGodina.Name = "comboBoxGodina";
            this.comboBoxGodina.Size = new System.Drawing.Size(175, 21);
            this.comboBoxGodina.TabIndex = 0;
            this.comboBoxGodina.SelectedIndexChanged += new System.EventHandler(this.comboBoxGodina_SelectedIndexChanged);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(1150, 640);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 22;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartGodisnji);
            this.groupBox1.Location = new System.Drawing.Point(301, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 574);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistički pregled godišnjih u odabranoj godini";
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 747);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.gbGodina);
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStatistika_FormClosed);
            this.Load += new System.EventHandler(this.GodisnjiStatistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGodisnji)).EndInit();
            this.gbGodina.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGodisnji;
        private System.Windows.Forms.GroupBox gbGodina;
        private System.Windows.Forms.ComboBox comboBoxGodina;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}