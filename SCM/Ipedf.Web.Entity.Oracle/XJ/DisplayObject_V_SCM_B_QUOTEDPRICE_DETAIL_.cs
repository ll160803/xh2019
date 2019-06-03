using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Web.Entity
{
	public partial class DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL
	{
        System.Decimal _QUOTED_PRICE_MIN = ConstLibrary.Template.UndefineDecimal;
        [DataMember]
        public System.Decimal QUOTED_PRICE_MIN { get { return _QUOTED_PRICE_MIN; } set { _QUOTED_PRICE_MIN = value; } }

        System.String _QUOTED_PRICE_MSEHT = string.Empty;
		[DataMember]
		public System.String QUOTED_PRICE_MSEHT{get{ return  _QUOTED_PRICE_MSEHT;}set{ _QUOTED_PRICE_MSEHT = value;}}

        System.String _SUPPLY_AMOUNT_MSEHT = string.Empty;
		[DataMember]
        public System.String SUPPLY_AMOUNT_MSEHT { get { return _SUPPLY_AMOUNT_MSEHT; } set { _SUPPLY_AMOUNT_MSEHT = value; } }

        System.String _PRICE_MSEHT = string.Empty;
		[DataMember]
        public System.String PRICE_MSEHT { get { return _PRICE_MSEHT; } set { _PRICE_MSEHT = value; } }

        System.String _CREATE_TIMES = string.Empty;
        [DataMember]
        public System.String CREATE_TIMES { get { return _CREATE_TIMES; } set { _CREATE_TIMES = value; } }

        System.Int16 _IS_TRUE = 0;
        [DataMember]
        public System.Int16 IS_TRUE { get { return _IS_TRUE; } set { _IS_TRUE = value; } }
	}
}
