using System;
using System.Collections.Generic;
using System.Linq;
using YSQ.core.Extensions;
using YSQ.core.Properties;
using YSQ.core.Quotes;

namespace YSQ.core.MarketData
{
    public class MarketDataFunctions
    {
        public static IEnumerable<Security> GetAllSecuritiesByType(CustomEnum.MarketDataType enumerationMarketData)
        {
            var listSecurities = new List<Security>();
            string[] splitTickers;

            switch (enumerationMarketData)
            {
                case CustomEnum.MarketDataType.Stock:
                    splitTickers = Resources.GetAllStocksDetail.Split(',');
                    break;

                case CustomEnum.MarketDataType.ETF:
                    splitTickers = Resources.GetAllEtfs.Split(',');
                    break;

                case CustomEnum.MarketDataType.Index:
                    splitTickers = Resources.GetAllIndex.Split(',');
                    break;

                default: throw new Exception(string.Format("Market Data request for type {0} not defined", enumerationMarketData));
            }

            var getTickersSplittedByN = splitTickers.Skip(1).Select((x, i) => new { Index = i, Value = x })
                                            .GroupBy(x => x.Index / 200)
                                            .Select(x => x.Select(v=>v.Value).Where(y => !string.IsNullOrEmpty(y)).ToArray())
                                            .ToList();

            foreach (var ls in getTickersSplittedByN)
            {
                var quoteService = new QuoteService();
                var quotes = quoteService.Quote(ls).ConvertToSecurities(QuoteReturnParameter.StockExchange,
                    QuoteReturnParameter.Symbol, QuoteReturnParameter.Name, QuoteReturnParameter.VolumeAverageDaily,
                    QuoteReturnParameter.Open, QuoteReturnParameter.PreviousClose, QuoteReturnParameter.LatestTradePrice,
                    QuoteReturnParameter.Change, QuoteReturnParameter.ChangeAsPercent, QuoteReturnParameter.Bid,
                    QuoteReturnParameter.Ask,
                    QuoteReturnParameter.LatestTradeDate, QuoteReturnParameter.LatestTradeTime,
                    QuoteReturnParameter.LowForTodays,
                    QuoteReturnParameter.TodaysHigh, QuoteReturnParameter.LowLimit, QuoteReturnParameter.HighLimit,
                    QuoteReturnParameter.MarketCap, QuoteReturnParameter.BookValue, QuoteReturnParameter.PriceBook,
                    QuoteReturnParameter.EBITDA, QuoteReturnParameter.PriceSales, QuoteReturnParameter.ShortRatio)
                    .ToList();
                listSecurities.AddRange(quotes);
            }
            return listSecurities;

        }
    }
}
