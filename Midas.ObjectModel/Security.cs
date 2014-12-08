using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midas.ObjectModel
{
    public class Security
    {
        private readonly string _securityName;
        private readonly string _symbol;
        private readonly string _currency;
        private readonly string _marketcap;
        private readonly decimal? _priceToEarningsRatio;
        private readonly decimal? _dividendYield;
        private readonly decimal? _priceChangePercent52Week;

        public Security(string securityName, string symbol, string currency, string marketcap, decimal? priceToEarningsRatio, decimal? dividendYield, decimal? priceChangePercent52Week)
        {
            _securityName = securityName;
            _symbol = symbol;
            _currency = currency;
            _marketcap = marketcap;
            _priceToEarningsRatio = priceToEarningsRatio;
            _dividendYield = dividendYield;
            _priceChangePercent52Week = priceChangePercent52Week;
        }

        public string SecurityName
        {
            get { return _securityName; }
        }

        public string Symbol
        {
            get { return _symbol; }
        }

        public string Currency
        {
            get { return _currency; }
        }

        public string Marketcap
        {
            get { return _marketcap; }
        }

        public decimal? PriceToEarningsRatio
        {
            get { return _priceToEarningsRatio; }
        }

        public decimal? DividendYield
        {
            get { return _dividendYield; }
        }

        public decimal? PriceChangePercent52Week
        {
            get { return _priceChangePercent52Week; }
        }
    }
}
