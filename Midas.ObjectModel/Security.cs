using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midas.ObjectModel
{
    public class Security
    {
        private readonly string _symbol;

        private readonly SecurityMarketData _marketData;

        public Security(string symbol) : this(symbol, null)
        {
            
        }

        public Security(string symbol, SecurityMarketData marketData)
        {
            _symbol = symbol;
            _marketData = marketData;
        }

        public string Symbol
        {
            get { return _symbol; }
        }

        public SecurityMarketData MarketData
        {
            get { return _marketData; }
        }
    }
}
