
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Stock.Design.CustomModel;
using Stock.Design.Forms.Functions;
using YSQ.core.Historical;

namespace Stock.Design.Forms.Controls
{
    public partial class PositionsForm : Form
    {
        private readonly dynamic _security;
        public PositionsForm(dynamic security)
        {
            InitializeComponent();
            _security = security;

            DTP_StartDate.Value = DateTime.Today.AddMonths(-3);
            DTP_EndDate.Value = DateTime.Today;

            Text = string.Format("History positions for security : {0} ({1})", security.Name, security.Symbol);

            GetHistory();
        }

        private void GetHistory()
        {
            DateTime startDate = DTP_StartDate.Value;
            DateTime endDate = DTP_EndDate.Value;

            var historical_price_service = new HistoricalPriceService();

            Func<List<HistoricalPrice>> functionHisto = () => historical_price_service.Get(_security.Symbol, startDate, endDate, Period.Daily);
            var getObject= FormLoader.ExecuteWaitAction(this, functionHisto);
            if (getObject == null) return;

            Series serieOpen = Chart_History.Series[0];
            serieOpen.Points.Clear();
            Series serieCLose = Chart_History.Series[1];
            serieCLose.Points.Clear();

            var getListPriceSorted = (getObject as List<HistoricalPrice>).OrderBy(pr => pr.Date).ToList();
            foreach (HistoricalPrice price in getListPriceSorted)
            {
                serieOpen.Points.AddXY(price.Date,price.Open);
                serieCLose.Points.AddXY(price.Date,price.Price);
            }

            var bindingList = new SortableBindingList<HistoricalPrice>(getObject as List<HistoricalPrice>);
            var source = new BindingSource(bindingList, null);
            DGV_History.DataSource = source;
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void BTN_Reload_Click(object sender, EventArgs e)
        {
            GetHistory();
        }
    }
}
