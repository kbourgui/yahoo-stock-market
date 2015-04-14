namespace Stock.Design.Forms.Controls
{
    partial class MarketDataForm
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
            this.Splitter_Shortcurts = new System.Windows.Forms.Splitter();
            this.Splitter_Main = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Stocks = new System.Windows.Forms.Button();
            this.DGV_MarketData = new System.Windows.Forms.DataGridView();
            this.BTN_Etf = new System.Windows.Forms.Button();
            this.BTN_Index = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MarketData)).BeginInit();
            this.SuspendLayout();
            // 
            // Splitter_Shortcurts
            // 
            this.Splitter_Shortcurts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Splitter_Shortcurts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Splitter_Shortcurts.Cursor = System.Windows.Forms.Cursors.Default;
            this.Splitter_Shortcurts.Location = new System.Drawing.Point(0, 0);
            this.Splitter_Shortcurts.Name = "Splitter_Shortcurts";
            this.Splitter_Shortcurts.Size = new System.Drawing.Size(145, 609);
            this.Splitter_Shortcurts.TabIndex = 4;
            this.Splitter_Shortcurts.TabStop = false;
            // 
            // Splitter_Main
            // 
            this.Splitter_Main.BackColor = System.Drawing.SystemColors.Control;
            this.Splitter_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Splitter_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.Splitter_Main.Location = new System.Drawing.Point(145, 0);
            this.Splitter_Main.Name = "Splitter_Main";
            this.Splitter_Main.Size = new System.Drawing.Size(671, 609);
            this.Splitter_Main.TabIndex = 6;
            this.Splitter_Main.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Instrument Type";
            // 
            // BTN_Stocks
            // 
            this.BTN_Stocks.Location = new System.Drawing.Point(31, 87);
            this.BTN_Stocks.Name = "BTN_Stocks";
            this.BTN_Stocks.Size = new System.Drawing.Size(87, 28);
            this.BTN_Stocks.TabIndex = 8;
            this.BTN_Stocks.Text = "Stocks";
            this.BTN_Stocks.UseVisualStyleBackColor = true;
            this.BTN_Stocks.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // DGV_MarketData
            // 
            this.DGV_MarketData.AllowUserToAddRows = false;
            this.DGV_MarketData.AllowUserToDeleteRows = false;
            this.DGV_MarketData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_MarketData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_MarketData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_MarketData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MarketData.EnableHeadersVisualStyles = false;
            this.DGV_MarketData.Location = new System.Drawing.Point(154, 13);
            this.DGV_MarketData.Name = "DGV_MarketData";
            this.DGV_MarketData.ReadOnly = true;
            this.DGV_MarketData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_MarketData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_MarketData.RowHeadersWidth = 20;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_MarketData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_MarketData.RowTemplate.ReadOnly = true;
            this.DGV_MarketData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_MarketData.Size = new System.Drawing.Size(655, 585);
            this.DGV_MarketData.TabIndex = 9;
            this.DGV_MarketData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_MarketData_CellFormatting);
            this.DGV_MarketData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_MarketData_CellMouseDoubleClick);
            this.DGV_MarketData.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.DGV_MarketData_CellToolTipTextNeeded);
            // 
            // BTN_Etf
            // 
            this.BTN_Etf.Location = new System.Drawing.Point(31, 131);
            this.BTN_Etf.Name = "BTN_Etf";
            this.BTN_Etf.Size = new System.Drawing.Size(87, 28);
            this.BTN_Etf.TabIndex = 10;
            this.BTN_Etf.Text = "ETF";
            this.BTN_Etf.UseVisualStyleBackColor = true;
            this.BTN_Etf.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // BTN_Index
            // 
            this.BTN_Index.Location = new System.Drawing.Point(31, 176);
            this.BTN_Index.Name = "BTN_Index";
            this.BTN_Index.Size = new System.Drawing.Size(87, 28);
            this.BTN_Index.TabIndex = 11;
            this.BTN_Index.Text = "Index";
            this.BTN_Index.UseVisualStyleBackColor = true;
            this.BTN_Index.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // MarketDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 609);
            this.Controls.Add(this.BTN_Index);
            this.Controls.Add(this.BTN_Etf);
            this.Controls.Add(this.DGV_MarketData);
            this.Controls.Add(this.BTN_Stocks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Splitter_Main);
            this.Controls.Add(this.Splitter_Shortcurts);
            this.Name = "MarketDataForm";
            this.Text = "Instrument Watch";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MarketData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter Splitter_Shortcurts;
        private System.Windows.Forms.Splitter Splitter_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Stocks;
        private System.Windows.Forms.DataGridView DGV_MarketData;
        private System.Windows.Forms.Button BTN_Etf;
        private System.Windows.Forms.Button BTN_Index;
    }
}