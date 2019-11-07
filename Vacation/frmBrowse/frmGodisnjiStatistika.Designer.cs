namespace Vacation.frmBrowse
{
    partial class frmGodisnjiStatistika
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
            this.chartGodisnji = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGodisnji)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGodisnji
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGodisnji.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGodisnji.Legends.Add(legend1);
            this.chartGodisnji.Location = new System.Drawing.Point(53, 111);
            this.chartGodisnji.Name = "chartGodisnji";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Mjesec";
            series1.XValueMember = "Siječanj";
            series1.YValueMembers = "200";
            this.chartGodisnji.Series.Add(series1);
            this.chartGodisnji.Size = new System.Drawing.Size(980, 468);
            this.chartGodisnji.TabIndex = 0;
            this.chartGodisnji.Text = "chartGodisnji";
            title1.Name = "Mjesečni prikaz godišnjih po godinama";
            this.chartGodisnji.Titles.Add(title1);
            // 
            // frmGodisnjiStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 591);
            this.Controls.Add(this.chartGodisnji);
            this.Name = "frmGodisnjiStatistika";
            this.Text = "GodisnjiStatistika";
            this.Load += new System.EventHandler(this.GodisnjiStatistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGodisnji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGodisnji;
    }
}