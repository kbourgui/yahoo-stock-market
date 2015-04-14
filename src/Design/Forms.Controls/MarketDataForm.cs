using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Stock.Design.CustomModel;
using Stock.Design.Forms.Functions;
using YSQ.core;
using YSQ.core.DataTypeConverter;
using YSQ.core.Extensions;
using YSQ.core.MarketData;
using YSQ.core.Quotes;


namespace Stock.Design.Forms.Controls
{
    public partial class MarketDataForm : Form
    {
        public MarketDataForm()
        {
            InitializeComponent();
            DoubleBufferedDataGridView(true);
        }

        protected override void OnResize(EventArgs ea)
        {
            base.OnResize(ea);
            Splitter_Main.Width = ClientSize.Width - Splitter_Shortcurts.Width;
        }

        private void OnButton_Click(object sender, EventArgs e)
        {
            if (!(sender is Button)) return;

            DGV_MarketData.DataSource = null;
            DGV_MarketData.Refresh();

            CustomEnum.MarketDataType getMarketDataType;
            Button getClickedBtn = sender as Button;

            if (getClickedBtn == BTN_Stocks) getMarketDataType = CustomEnum.MarketDataType.Stock;
            else if (getClickedBtn == BTN_Etf) getMarketDataType = CustomEnum.MarketDataType.ETF;
            else if (getClickedBtn == BTN_Index) getMarketDataType = CustomEnum.MarketDataType.Index;
            else throw new Exception(string.Format("No functon defined for button {0}.",getClickedBtn.Name));


            Func<List<Security>> functionGetSecurities = () => MarketDataFunctions.GetAllSecuritiesByType(getMarketDataType).ToList();  //.Where(sec => !string.IsNullOrEmpty(sec.Name)
            var getObject = FormLoader.ExecuteWaitAction(this, functionGetSecurities);
            if (getObject == null) return;

            var bindingList = new SortableBindingList<Security>(getObject as List<Security>);
            var source = new BindingSource(bindingList, null);

            DGV_MarketData.DataSource = source;
        }

        private void DGV_MarketData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var getRow = DGV_MarketData.Rows[e.RowIndex].DataBoundItem;
            if (getRow != null)
            {
                var getBindingSecurity = getRow as Security;
                if (getBindingSecurity != null)
                {
                   FormLoader.LoadForm(new PositionsForm(getBindingSecurity), this, false);
                }
            }
        }

        private void DGV_MarketData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var getRow = DGV_MarketData.Rows[e.RowIndex].DataBoundItem;
            if (getRow != null)
            {
                double outDbl=0;
                var getBindingSecurity = getRow as Security;
                if (getBindingSecurity != null && DGV_MarketData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null &&
                    NumberFormat.TryGetDouble(DGV_MarketData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out outDbl))
                {
                    if (DGV_MarketData.Columns[e.ColumnIndex].HeaderText == @"Last Bid Px")
                    {
                        e.CellStyle.ForeColor = Color.Yellow;
                        e.CellStyle.SelectionForeColor = Color.Yellow;
                    }
                    else if (outDbl > 0)
                    {
                        e.CellStyle.ForeColor = Color.Lime;
                        e.CellStyle.SelectionForeColor = Color.Lime;
                    }
                    else if (outDbl == 0)
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.SelectionForeColor = Color.White;
                    }
                    else if (outDbl < 0)
                    {
                        e.CellStyle.ForeColor = Color.OrangeRed;
                        e.CellStyle.SelectionForeColor = Color.OrangeRed;
                    }
                }
            }
        }

        public void DoubleBufferedDataGridView(bool setting)
        {
            Type dgvType = DGV_MarketData .GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(DGV_MarketData, setting, null);
        }

        private void DGV_MarketData_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex <0) return;
            var getRow = DGV_MarketData.Rows[e.RowIndex].DataBoundItem;

            if (getRow as Security == null) return;
            
            e.ToolTipText = @"Double Click to get security price history for : " +
                            (getRow as Security).Symbol +
                            (DGV_MarketData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null
                                ? Environment.NewLine +
                                  DGV_MarketData.Columns[e.ColumnIndex].Name + " : " + DGV_MarketData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value
                                : "");

               
        }

    }
}
