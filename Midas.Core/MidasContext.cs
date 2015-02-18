using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midas.ObjectModel.Models;

namespace Midas.Core
{
    public class MidasContext : DbContext
    {
        public MidasContext() : base("Midas")
        {
            
        }
        public DbSet<Security> Securities { get; set; }
        public DbSet<SecurityMarketDataType> MarketDataTypes { get; set; }
        public DbSet<SecurityMetaDataType> MetaDataTypes { get; set; }
    }
}
