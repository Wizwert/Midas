using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using Midas.ObjectModel;

namespace Midas.Core
{
    public class YQLDataProvider
    {
        private const string BaseUrl = "https://query.yahooapis.com/v1/public/yql?q={0}&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

        public static void GetQuotes(IEnumerable<Security> quotes)
        {
            var queryBase = "select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20({0})";

            string symbolList = "%22" + quotes.Select(x => x.Symbol).Aggregate((current, next) => current + "%22%2C%22" + next) + "%22";

            var query = string.Format(queryBase, symbolList);

            string url = string.Format(BaseUrl, query);

            XDocument doc = XDocument.Load(url);

            foreach(var descendant in doc.Descendants("quote"))
            {
                var symbol = descendant.Attribute("symbol").Value;
                var security = new Security(symbol);
            }
        }
    }
}
