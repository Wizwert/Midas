using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using Midas.ObjectModel.Models;

namespace Midas.Core
{
    public class YQLDataProvider
    {
        private const string BaseUrl = "https://query.yahooapis.com/v1/public/yql?q={0}&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

        public static void UpdateQuotes(IEnumerable<string> quotes)
        {
            var queryBase = "select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20({0})";

            var symbolList = "%22" + quotes.Aggregate((current, next) => current + "%22%2C%22" + next) + "%22";

            var query = string.Format(queryBase, symbolList);

            string url = string.Format(BaseUrl, query);

            XDocument doc = XDocument.Load(url);

            using(var midasContext = new MidasContext())
            {
                foreach (var descendant in doc.Descendants("quote"))
                {
                    var symbol = descendant.Attribute("symbol").Value;

                    var security = midasContext.Securities.SingleOrDefault(x => x.SecurityCode.Equals(symbol, StringComparison.OrdinalIgnoreCase));

                    if(security == null)
                    {
                        security = new Security
                                   {
                                       MarketData = new List<SecurityMarketData>(),
                                       MetaData = new List<SecurityMetaData>(),
                                       SecurityCode = symbol
                                   };

                        midasContext.Securities.Add(security);
                        midasContext.SaveChanges();
                    }

                    foreach (var attribute in descendant.Descendants())
                    {
                        var marketDataTypeName = attribute.Name.LocalName;

                        var marketDataType = midasContext.MarketDataTypes.SingleOrDefault(x => x.SecurityMarketTypeDataCode.Equals(marketDataTypeName, StringComparison.OrdinalIgnoreCase));
                        if(marketDataType == null)
                        {
                            marketDataType = new SecurityMarketDataType
                                             {
                                                 ObjectType = typeof(string).ToString(),
                                                 SecurityMarketTypeDataCode = marketDataTypeName,
                                                 SecurityMarketDataDescription = null,
                                             };

                            midasContext.MarketDataTypes.Add(marketDataType);
                            midasContext.SaveChanges();
                        }

                        var marketData = new SecurityMarketData
                                         {
                                             MarketDataType = marketDataType,
                                             EffectiveEndTime = null,
                                             EffectiveStartTime = DateTime.Now.Date,
                                             SecurityID = security.SecurityID,
                                             Security = security,
                                             Value = attribute.Value
                                         };

                        security.MarketData.Add(marketData);
                    }
                }

                midasContext.SaveChanges();
            }
        }
    }
}
