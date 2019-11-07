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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGodisnji = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGodisnji)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGodisnji
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGodisnji.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGodisnji.Legends.Add(legend2);
            this.chartGodisnji.Location = new System.Drawing.Point(64, 179);
            this.chartGodisnji.Name = "chartGodisnji";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGodisnji.Series.Add(series2);
            this.chartGodisnji.Size = new System.Drawing.Size(889, 336);
            this.chartGodisnji.TabIndex = 0;
            this.chartGodisnji.Text = "chartGodisnji";
            // 
            // GodisnjiStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 591);
            this.Controls.Add(this.chartGodisnji);
            this.Name = "GodisnjiStatistika";
            this.Text = "GodisnjiStatistika";
            this.Load += new System.EventHandler(this.GodisnjiStatistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGodisnji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGodisnji;
    }
}