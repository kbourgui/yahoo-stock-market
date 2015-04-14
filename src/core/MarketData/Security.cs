
using System.ComponentModel;


namespace YSQ.core.MarketData
{
    public class Security
    {
        [DisplayName(@"Market Place")]
        public string StockExchange { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }

        [DisplayName(@"Daily Traded Qty")]
        public string AverageDailyVolume { get; set; }
        [DisplayName(@"Last Open")]
        public string Open { get; set; }
        [DisplayName(@"Close")]
        public string PreviousClose { get; set; }
        [DisplayName(@"Last Trade Px")]
        public string LastTradePriceOnly { get; set; }
        public string Change { get; set; }
        [DisplayName(@"Rate Change")]
        public string ChangeinPercent { get; set; }
        [DisplayName(@"Last Bid Px")]
        public string Bid { get; set; }
        [DisplayName(@"Last Ask Px")]
        public string Ask { get; set; }
        [DisplayName(@"Last Trade Date")]
        public string LastTradeDate { get; set; }
        [DisplayName(@"Last Trade Time")]
        public string LastTradeTime { get; set; }

        [Browsable(false)]
        public string LastTradeWithTime { get; set; }

        [DisplayName(@"Daily Min")]
        public string DaysLow { get; set; }
        [DisplayName(@"Daily Max")]
        public string DaysHigh { get; set; }
        [DisplayName(@"Yearly Min")]
        public string YearLow { get; set; }
        [DisplayName(@"Yearly Max")]
        public string YearHigh { get; set; }

        [DisplayName(@"Last Markt Cap")]
        public string MarketCapitalization { get; set; }

        [DisplayName(@"Book Value")]
        public string BookValue { get; set; }
        [DisplayName(@"Price Book")]
        public string PriceBook { get; set; }

        [Browsable(false)]
        [DisplayName(@"ActualTrade Date")]
        public string TradeDate { get; set; }
        [Browsable(false)]
        [DisplayName(@"Bid Px RT")]
        public string BidRealtime { get; set; }
        [Browsable(false)]
        [DisplayName(@"Ask Px RT")]
        public string AskRealtime { get; set; }
        [Browsable(false)]
        [DisplayName(@"Limit Max")]
        public string HighLimit { get; set; }
        [Browsable(false)]
        [DisplayName(@"Limit Min")]
        public string LowLimit { get; set; }
        [Browsable(false)]
        [DisplayName(@"Fx Rate RT")]
        public string ChangeRealtime { get; set; }
        [Browsable(false)]
        public string MarketCapRealtime { get; set; }




        [Browsable(false)]
        public string Change_PercentChange { get; set; }

        [Browsable(false)]
        public string Commission { get; set; }

        [Browsable(false)]
        public string AfterHoursChangeRealtime { get; set; }
        [Browsable(false)]
        public string DividendShare { get; set; }



        [Browsable(false)]
        public string EarningsShare { get; set; }

        [Browsable(false)]
        public string ErrorIndicationreturnedforsymbolchangedinvalid { get; set; }
        [Browsable(false)]
        public string EpsEstimateCurrentYear { get; set; }
        [Browsable(false)]
        public string EpsEstimateNextYear { get; set; }
        [Browsable(false)]
        public string EpsEstimateNextQuarter { get; set; }


        [Browsable(false)]
        public string HoldingsGainPercent { get; set; }
        [Browsable(false)]
        public string AnnualizedGain { get; set; }
        [Browsable(false)]
        public string HoldingsGain { get; set; }
        [Browsable(false)]
        public string HoldingsGainPercentRealtime { get; set; }
        [Browsable(false)]
        public string HoldingsGainRealtime { get; set; }
        [Browsable(false)]
        public string MoreInfo { get; set; }
        [Browsable(false)]
        public string OrderBookRealtime { get; set; }

        public string Ebitda { get; set; }

        [Browsable(false)]
        public string ChangeFromYearLow { get; set; }
        [Browsable(false)]
        public string PercentChangeFromYearLow { get; set; }
        [Browsable(false)]
        public string LastTradeRealtimeWithTime { get; set; }
        [Browsable(false)]
        public string ChangePercentRealtime { get; set; }
        [Browsable(false)]
        public string ChangeFromYearHigh { get; set; }
        [Browsable(false)]
        public string PercebtChangeFromYearHigh { get; set; }




        [Browsable(false)]
        public string DaysRange { get; set; }
        [Browsable(false)]
        public string DaysRangeRealtime { get; set; }
        [Browsable(false)]
        public string FiftydayMovingAverage { get; set; }
        [Browsable(false)]
        public string TwoHundreddayMovingAverage { get; set; }
        [Browsable(false)]
        public string ChangeFromTwoHundreddayMovingAverage { get; set; }
        [Browsable(false)]
        public string PercentChangeFromTwoHundreddayMovingAverage { get; set; }
        [Browsable(false)]
        public string ChangeFromFiftydayMovingAverage { get; set; }
        [Browsable(false)]
        public string PercentChangeFromFiftydayMovingAverage { get; set; }

        [Browsable(false)]
        public string Notes { get; set; }

        [Browsable(false)]
        public string PricePaid { get; set; }

        public string PriceSales { get; set; }

        [Browsable(false)]
        public string ExDividendDate { get; set; }
        [Browsable(false)]
        public string PeRatio { get; set; }
        [Browsable(false)]
        public string DividendPayDate { get; set; }
        [Browsable(false)]
        public string PeRatioRealtime { get; set; }
        [Browsable(false)]
        public string PegRatio { get; set; }
        [Browsable(false)]
        public string PriceEpsEstimateCurrentYear { get; set; }
        [Browsable(false)]
        public string PriceEpsEstimateNextYear { get; set; }

        [Browsable(false)]
        public string SharesOwned { get; set; }
        public string ShortRatio { get; set; }

        [Browsable(false)]
        public string TickerTrend { get; set; }
        [Browsable(false)]
        public string OneyrTargetPrice { get; set; }
        public long? Volume { get; set; }
        [Browsable(false)]
        public string HoldingsValue { get; set; }
        [Browsable(false)]
        public string HoldingsValueRealtime { get; set; }
        [Browsable(false)]
        public string YearRange { get; set; }
        [Browsable(false)]
        public string DaysValueChange { get; set; }
        [Browsable(false)]
        public string DaysValueChangeRealtime { get; set; }

        [Browsable(false)]
        public string DividendYield { get; set; }
        [Browsable(false)]
        public string PercentChange { get; set; }
    }
}
