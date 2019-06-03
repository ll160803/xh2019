using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.Serialization;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Collections.Generic;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataContract]
	public partial class DisplayObject_SCM_B_QUERYPRICE_I:DisplayObject_SCM_B_QUERYPRICE
	{
        System.Decimal _ALLCOUNT;
        [DataMember]
        public System.Decimal ALLCOUNT { get { return _ALLCOUNT; } set { _ALLCOUNT = value; } }

        System.Decimal _ACTCOUNT;
        [DataMember]
        public System.Decimal ACTCOUNT { get { return _ACTCOUNT; } set { _ACTCOUNT = value; } }

        System.String _PRODUCT_NAME;

        [DataMember]
        public System.String PRODUCT_NAME { get { return _PRODUCT_NAME; } set { _PRODUCT_NAME = value; } }

        System.String _END_DATES;
        [DataMember]
        public System.String END_DATES { get { return _END_DATES; } set { _END_DATES = value; } }

        System.String _QUERY_DATES;
        [DataMember]
        public System.String QUERY_DATES { get { return _QUERY_DATES; } set { _QUERY_DATES = value; } }

        System.String _ZEINR;
        [DataMember]
        public System.String ZEINR { get { return _ZEINR; } set { _ZEINR = value; } }

	}

    public partial class EntityObject_SCM_B_QUERYPRICE_U : EntityObject_SCM_B_QUERYPRICE
    {
        System.String _PRODUCT_NAME;
        [DataMember]
        public System.String PRODUCT_NAME { get { return _PRODUCT_NAME; } set { _PRODUCT_NAME = value; } }

        System.String _END_DATES;
        [DataMember]
        public System.String END_DATES { get { return _END_DATES; } set { _END_DATES = value; } }

        [DataMember]
        public List<EntityObject_SCM_B_QUERYPRICE_D> QueryPriceDetailList = new List<EntityObject_SCM_B_QUERYPRICE_D>();
    }

    public partial class DisplayObject_SCM_B_QUERYPRICE_E : DisplayObject_SCM_B_QUERYPRICE
    {
        System.String _PRODUCT_NAME;
        [DataMember]
        public System.String PRODUCT_NAME { get { return _PRODUCT_NAME; } set { _PRODUCT_NAME = value; } }

        System.String _END_DATES;
        [DataMember]
        public System.String END_DATES { get { return _END_DATES; } set { _END_DATES = value; } }

        System.String _QUERY_DATES;
        [DataMember]
        public System.String QUERY_DATES { get { return _QUERY_DATES; } set { _QUERY_DATES = value; } }
    }

    public partial class DisplayObject_SCM_B_QUERYPRICE_Q
    {
        [DataMember]
        public List<DisplayObject_SCM_B_QUERYPRICE_D> QueryPriceDetailList = new List<DisplayObject_SCM_B_QUERYPRICE_D>();
    }

    public class ResultQueryPriceEntity 
    {
        System.String _ID;
        [DataMember]
        public System.String ID { get { return _ID; } set { _ID = value; } }


        System.String _QUERY_STATE;
        [DataMember]
        public System.String QUERY_STATE { get { return _QUERY_STATE; } set { _QUERY_STATE = value; } }
    }

}
