using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midas.Core;
using Midas.ObjectModel.Models;

namespace Midas.UI.Wpf
{
    public class SecuritiesListViewModel
    {
        private readonly ObservableCollection<Security> _securities = new ObservableCollection<Security>();

        public ObservableCollection<Security> Securities { get { return _securities; } }

        public SecuritiesListViewModel()
        {
            LoadSecurities(Securities);
        }

        private void LoadSecurities(ObservableCollection<Security> securities)
        {
            Securities.Clear();

            using(var context = new MidasContext())
            {
                foreach(var security in context.Securities.Include("MarketData").Include("MarketData.MarketDataType"))
                {
                    Securities.Add(security);
                }
            }
        }

        public void RefreshSecurities()
        {
            YQLDataProvider.UpdateQuotes(DummyDataProvider.GetDummySecurities());
            LoadSecurities(Securities);
        }
    }
}
