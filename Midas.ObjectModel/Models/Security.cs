using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Midas.ObjectModel.Models
{
    public class Security
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SecurityID { get; set; }

        public string SecurityCode { get; set; }

        public virtual ICollection<SecurityMetaData> MetaData { get; set; } 

        public virtual ICollection<SecurityMarketData> MarketData { get; set; } 
    }

    public class SecurityMarketData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SecurityMarketDataID { get; set; }

        public int SecurityID { get; set; }

        public Security Security { get; set; }

        public int SecurityMarketDataTypeID { get; set; }

        public SecurityMarketDataType MarketDataType { get; set; }

        public string MarketDataTypeName { get { return MarketDataType.SecurityMarketTypeDataCode; } }

        public string Value { get; set; }

        public DateTime EffectiveStartTime { get; set; }

        public DateTime? EffectiveEndTime { get; set; }
    }

    public class SecurityMarketDataType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SecurityMarketDataTypeID { get; set; }

        public string SecurityMarketTypeDataCode { get; set; }

        public string SecurityMarketDataDescription { get; set; }

        public string ObjectType { get; set; }
    }

    public class SecurityMetaData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SecurityMetaDataID { get; set; }

        public int SecurityID { get; set; }

        public int SecurityMetaDataTypeID { get; set; }

        public SecurityMetaDataType MetaDataType { get; set; }

        public string Value { get; set; }

        public DateTime EffectiveStartTime { get; set; }

        public DateTime? EffectiveEndTime { get; set; }
    }

    public class SecurityMetaDataType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SecurityMetaDataTypeID { get; set; }

        public string SecurityMetaDataCode { get; set; }

        public string SecurityMetaDataDescription { get; set; }

        public string ObjectType { get; set; }
    }
}
