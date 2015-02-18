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
        public static IList<String> GetDummySecurities()
        {
            return new List<String>
                             {
                                 "AAPL",
                                 "MSFT",
                                 "XOM",
                                 "BRK.B",
                                 "BRK.A",
                                 "GOOGL",
                                 "GOOG",
                                 "JNJ",
                                 "PTR",
                                 "WFC",
                                 "WFCNP",
                                 "WFCnullL",
                                 "WMT",
                                 "BABA",
                                 "NVS",
                                 "GE",
                                 "RHHBY",
                                 "NVSEF",
                                 "CHLKF",
                                 "CHL",
                             };
        } 
    }
}
