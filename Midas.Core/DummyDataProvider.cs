using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midas.ObjectModel;

namespace Midas.Core
{
    public class DummyDataProvider
    {
        public static IList<Security> GetDummySecurities()
        {
            return new List<Security>
                             {
                                 new Security("Apple Inc.", "AAPL", "$", "672.02B", 17.69m, 1.63m, 41.75m),
                                 new Security("Microsoft Corporation", "MSFT", "$", "399.78B", 18.90m, 2.56m, 27.42m),
                                 new Security("Exxon Mobil Corporation", "XOM", "$", "394.92B", 11.58m, 2.94m, -0.33m),
                                 new Security("Berkshire Hathaway Inc.", "BRK.B", "$", "373.74B", 0.01m, null, null),
                                 new Security("Berkshire Hathaway Inc.", "BRK.A", "$", "373.55B", 18.20m, null, 30.43m),
                                 new Security("Google Inc", "GOOGL", "$", "358.90B", 27.01m, null, -0.21m),
                                 new Security("Google Inc", "GOOG", "$", "357.24B", 26.85m, null, null),
                                 new Security("Johnson & Johnson", "JNJ", "$", "303.40B", 18.00m, 2.58m, 16.72m),
                                 new Security("PetroChina Company Limited (ADR)", "PTR", "$", "286.63B", 8.63m, 4.73m, -3.92m),
                                 new Security("Wells Fargo & Co", "WFC", "$", "285.94B", 13.51m, 2.54m, 27.24m),
                                 new Security("Wells Fargo & Co", "WFCNP", "$", "285.48B", 0.15m, null, null),
                                 new Security("Wells Fargo & Co", "WFCnullL", "$", "285.47B", 296.50m, null, null),
                                 new Security("Wal-Mart Stores, Inc.", "WMT", "$", "273.01B", 17.66m, 2.28m, 5.89m),
                                 new Security("Alibaba Group Holding Ltd", "BABA", "$", "269.02B", null, null, null),
                                 new Security("Novartis AG (ADR)", "NVS", "$", "261.53B", 23.11m, 2.88m, 22.92m),
                                 new Security("General Electric Company", "GE", "$", "260.85B", 17.53m, 3.38m, -1.66m),
                                 new Security("Roche Holding Ltd. (ADR)", "RHHBY", "$", "260.14B", 23.62m, 2.94m, 10.25m),
                                 new Security("NOVARTIS AG BASL", "NVSEF", "$", "259.20B", null, null, null),
                                 new Security("CHINA MOBILE HONG KO", "CHLKF", "$", "252.49B", 12.51m, null, null),
                                 new Security("China Mobile Ltd. (ADR)", "CHL", "$", "250.66B", 13.04m, 3.31m, 12.12m)
                             };
        } 
    }
}
