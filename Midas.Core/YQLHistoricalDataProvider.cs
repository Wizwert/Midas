using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Midas.ObjectModel;

namespace Midas.Core
{
    public class YQLHistoricalDataProvider
    {
        private const string BaseUrl = "https://query.yahooapis.com/v1/public/yql?q={0}&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

//        public static List<string> GetQuotes(IEnumerable<string> quotes)
//        {
//            var queryBase = "select%20*%20from%20yyahoo.finance.historicaldata%20where%20symbol%20in%20({0})";
//
//            var symbolList = "%22" + quotes.Aggregate((current, next) => current + "%22%2C%22" + next) + "%22";
//
//            var query = string.Format(queryBase, symbolList);
//
//            string url = string.Format(BaseUrl, query);
//
//            XDocument doc = XDocument.Load(url);
//
//            var securities = new List<string>();
//
//            foreach (var descendant in doc.Descendants("quote"))
//            {
//                var symbol = descendant.Attribute("symbol").Value;
//
//                var marketData = new SecurityMarketData(descendant);
//
//                var security = new Security(symbol, marketData);
//
//                securities.Add(security);
//            }
//
//            return securities;
//        }
    }
}
