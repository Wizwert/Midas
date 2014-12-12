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
                                 new Security("AAPL"),
                                 new Security("MSFT"),
                                 new Security("XOM"),
                                 new Security("BRK.B"),
                                 new Security("BRK.A"),
                                 new Security("GOOGL"),
                                 new Security("GOOG"),
                                 new Security("JNJ"),
                                 new Security("PTR"),
                                 new Security("WFC"),
                                 new Security("WFCNP"),
                                 new Security("WFCnullL"),
                                 new Security("WMT"),
                                 new Security("BABA"),
                                 new Security("NVS"),
                                 new Security("GE"),
                                 new Security("RHHBY"),
                                 new Security("NVSEF"),
                                 new Security("CHLKF"),
                                 new Security("CHL"),
                             };
        } 
    }
}
