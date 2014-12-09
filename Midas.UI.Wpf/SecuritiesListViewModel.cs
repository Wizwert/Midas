using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midas.Core;
using Midas.ObjectModel;

namespace Midas.UI.Wpf
{
    public class SecuritiesListViewModel
    {
        private readonly ObservableCollection<Security> _securities = new ObservableCollection<Security>();

        public ObservableCollection<Security> Securities { get { return _securities; } }

        public SecuritiesListViewModel()
        {
            SetUpFakeData();
        }

        private void SetUpFakeData()
        {
            foreach(var security in DummyDataProvider.GetDummySecurities())
            {
                Securities.Add(security);
            }
        }
    }
}
