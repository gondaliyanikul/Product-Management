namespace DbTest
{
    partial class CompareSell
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
            this.sellChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startDateTxt = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateTxt = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sellChart
            // 
            chartArea1.Name = "ChartArea1";
            this.sellChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.sellChart.Legends.Add(legend1);
            this.sellChart.Location = new System.Drawing.Point(12, 113);
            this.sellChart.Name = "sellChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Total_Amount";
            this.sellChart.Series.Add(series1);
            this.sellChart.Size = new System.Drawing.Size(1346, 556);
            this.sellChart.TabIndex = 0;
            this.sellChart.Text = "sellChart";
            // 
            // startDateTxt
            // 
            this.startDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTxt.Location = new System.Drawing.Point(263, 81);
            this.startDateTxt.Name = "startDateTxt";
            this.startDateTxt.Size = new System.Drawing.Size(200, 26);
            this.startDateTxt.TabIndex = 0;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(121, 86);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(136, 20);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Select Start Date ";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(806, 86);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(130, 20);
            this.endDateLabel.TabIndex = 4;
            this.endDateLabel.Text = "Select End Date ";
            // 
            // endDateTxt
            // 
            this.endDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTxt.Location = new System.Drawing.Point(948, 81);
            this.endDateTxt.Name = "endDateTxt";
            this.endDateTxt.Size = new System.Drawing.Size(200, 26);
            this.endDateTxt.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(1239, 67);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(119, 37);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameLabel.Location = new System.Drawing.Point(0, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(1370, 50);
            this.companyNameLabel.TabIndex = 6;
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompareSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 681);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.endDateTxt);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDateTxt);
            this.Controls.Add(this.sellChart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompareSell";
            this.Text = "CompareSell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompareSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sellChart;
        private System.Windows.Forms.DateTimePicker startDateTxt;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label companyNameLabel;
    }
}