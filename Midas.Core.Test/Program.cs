using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midas.Core.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            YQLDataProvider.GetQuotes(DummyDataProvider.GetDummySecurities());
        }
    }
}
