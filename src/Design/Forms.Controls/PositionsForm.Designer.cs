namespace Stock.Design.Forms.Controls
{
    partial class PositionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DGV_History = new System.Windows.Forms.DataGridView();
            this.DTP_StartDate = new System.Windows.Forms.DateTimePicker();
            this.DTP_EndDate = new System.Windows.Forms.DateTimePicker();
            this.LBL_StartDate = new System.Windows.Forms.Label();
            this.LBL_EndDate = new System.Windows.Forms.Label();
            this.BTN_Reload = new System.Windows.Forms.Button();
            this.Chart_History = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_History)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_History
            // 
            this.DGV_History.AllowUserToAddRows = false;
            this.DGV_History.AllowUserToDeleteRows = false;
            this.DGV_History.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_History.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_History.EnableHeadersVisualStyles = false;
            this.DGV_History.Location = new System.Drawing.Point(7, 52);
            this.DGV_History.Name = "DGV_History";
            this.DGV_History.ReadOnly = true;
            this.DGV_History.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_History.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_History.RowHeadersWidth = 20;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_History.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_History.RowTemplate.ReadOnly = true;
            this.DGV_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_History.Size = new System.Drawing.Size(374, 448);
            this.DGV_History.TabIndex = 10;
            // 
            // DTP_StartDate
            // 
            this.DTP_StartDate.Location = new System.Drawing.Point(14, 26);
            this.DTP_StartDate.Name = "DTP_StartDate";
            this.DTP_StartDate.Size = new System.Drawing.Size(193, 20);
            this.DTP_StartDate.TabIndex = 11;
            // 
            // DTP_EndDate
            // 
            this.DTP_EndDate.Location = new System.Drawing.Point(300, 26);
            this.DTP_EndDate.Name = "DTP_EndDate";
            this.DTP_EndDate.Size = new System.Drawing.Size(200, 20);
            this.DTP_EndDate.TabIndex = 12;
            // 
            // LBL_StartDate
            // 
            this.LBL_StartDate.AutoSize = true;
            this.LBL_StartDate.Location = new System.Drawing.Point(11, 9);
            this.LBL_StartDate.Name = "LBL_StartDate";
            this.LBL_StartDate.Size = new System.Drawing.Size(55, 13);
            this.LBL_StartDate.TabIndex = 13;
            this.LBL_StartDate.Text = "Start Date";
            // 
            // LBL_EndDate
            // 
            this.LBL_EndDate.AutoSize = true;
            this.LBL_EndDate.Location = new System.Drawing.Point(297, 10);
            this.LBL_EndDate.Name = "LBL_EndDate";
            this.LBL_EndDate.Size = new System.Drawing.Size(52, 13);
            this.LBL_EndDate.TabIndex = 14;
            this.LBL_EndDate.Text = "End Date";
            // 
            // BTN_Reload
            // 
            this.BTN_Reload.Image = global::Stock.Design.Properties.Resources.Rafraichir;
            this.BTN_Reload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Reload.Location = new System.Drawing.Point(538, 12);
            this.BTN_Reload.Name = "BTN_Reload";
            this.BTN_Reload.Size = new System.Drawing.Size(78, 34);
            this.BTN_Reload.TabIndex = 15;
            this.BTN_Reload.Text = "Reload";
            this.BTN_Reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Reload.UseVisualStyleBackColor = true;
            this.BTN_Reload.Click += new System.EventHandler(this.BTN_Reload_Click);
            // 
            // Chart_History
            // 
            this.Chart_History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart_History.BackColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.Interval = 0D;
            chartArea1.AxisY.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.Chart_History.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_History.Legends.Add(legend1);
            this.Chart_History.Location = new System.Drawing.Point(400, 52);
            this.Chart_History.Name = "Chart_History";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Lime;
            series1.Name = "Open";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.Name = "Close";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Chart_History.Series.Add(series1);
            this.Chart_History.Series.Add(series2);
            this.Chart_History.Size = new System.Drawing.Size(717, 447);
            this.Chart_History.TabIndex = 16;
            this.Chart_History.Text = "chart1";
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 506);
            this.Controls.Add(this.Chart_History);
            this.Controls.Add(this.BTN_Reload);
            this.Controls.Add(this.LBL_EndDate);
            this.Controls.Add(this.LBL_StartDate);
            this.Controls.Add(this.DTP_EndDate);
            this.Controls.Add(this.DTP_StartDate);
            this.Controls.Add(this.DGV_History);
            this.Name = "PositionsForm";
            this.Text = "History Positions";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_History)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_History;
        private System.Windows.Forms.DateTimePicker DTP_StartDate;
        private System.Windows.Forms.DateTimePicker DTP_EndDate;
        private System.Windows.Forms.Label LBL_StartDate;
        private System.Windows.Forms.Label LBL_EndDate;
        private System.Windows.Forms.Button BTN_Reload;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_History;
    }
}