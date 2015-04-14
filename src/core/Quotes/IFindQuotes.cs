using System.Collections.Generic;
using YSQ.core.MarketData;

namespace YSQ.core.Quotes
{
    public interface IFindQuotes
    {
        IEnumerable<dynamic> Return(params QuoteReturnParameter[] return_parameters);

        IEnumerable<Security> ConvertToSecurities(params QuoteReturnParameter[] return_parameters);
    }
}