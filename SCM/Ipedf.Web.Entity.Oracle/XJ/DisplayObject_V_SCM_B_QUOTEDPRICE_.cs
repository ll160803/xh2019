using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Web.Entity
{
	public partial class DisplayObject_V_SCM_B_QUOTEDPRICE
	{
        System.String _QUOTED_PRICE_MSEHT = string.Empty;
        [DataMember]
        public System.String QUOTED_PRICE_MSEHT { get { return _QUOTED_PRICE_MSEHT; } set { _QUOTED_PRICE_MSEHT = value; } }

        System.String _SUPPLY_AMOUNT_MSEHT = string.Empty;
        [DataMember]
        public System.String SUPPLY_AMOUNT_MSEHT { get { return _SUPPLY_AMOUNT_MSEHT; } set { _SUPPLY_AMOUNT_MSEHT = value; } }
	}
}
