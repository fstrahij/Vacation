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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistika));
            this.chartGodisnji = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbGodina = new System.Windows.Forms.GroupBox();
            this.comboBoxGodina = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartGodisnji)).BeginInit();
            this.gbGodina.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartGodisnji
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGodisnji.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGodisnji.Legends.Add(legend1);
            this.chartGodisnji.Location = new System.Drawing.Point(30, 31);
            this.chartGodisnji.Name = "chartGodisnji";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Mjesec";
            series1.XValueMember = "Siječanj";
            series1.YValueMembers = "200";
            this.chartGodisnji.Series.Add(series1);
            this.chartGodisnji.Size = new System.Drawing.Size(894, 516);
            this.chartGodisnji.TabIndex = 0;
            this.chartGodisnji.Text = "chartGodisnji";
            title1.Name = "Mjesečni prikaz godišnjih po godinama";
            this.chartGodisnji.Titles.Add(title1);
            // 
            // gbGodina
            // 
            this.gbGodina.Controls.Add(this.comboBoxGodina);
            this.gbGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbGodina.Location = new System.Drawing.Point(20, 80);
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
            this.comboBoxGodina.Size = new System.Drawing.Size(175, 24);
            this.comboBoxGodina.TabIndex = 0;
            this.comboBoxGodina.SelectedIndexChanged += new System.EventHandler(this.comboBoxGodina_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartGodisnji);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(301, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 574);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistički pregled godišnjih u odabranoj godini";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1310, 42);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(39, 39);
            this.toolStripButton1.Text = "Zatvori";
            this.toolStripButton1.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 747);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGodina);
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStatistika_FormClosed);
            this.Load += new System.EventHandler(this.GodisnjiStatistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGodisnji)).EndInit();
            this.gbGodina.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGodisnji;
        private System.Windows.Forms.GroupBox gbGodina;
        private System.Windows.Forms.ComboBox comboBoxGodina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}