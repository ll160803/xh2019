using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.Serialization;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{


    [Serializable]
    [DataContract]
    [DataObject("V_SCM_D_SUPPLIERPLAN")]
    public partial class EntityObject_V_SCM_D_SUPPLIERPLAN : EntityBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.String _FPHM;
        [DataMember]
        public System.String FPHM { get { return _FPHM; } set { _FPHM = value; } }
        System.String _WERKS;
        [DataMember]
        public System.String WERKS { get { return _WERKS; } set { _WERKS = value; } }
        System.String _FPBM;
        [DataMember]
        public System.String FPBM { get { return _FPBM; } set { _FPBM = value; } }
        System.String _TXZ01;
        [DataMember]
        public System.String TXZ01 { get { return _TXZ01; } set { _TXZ01 = value; } }
        System.Decimal _FPJR;
        [DataMember]
        public System.Decimal FPJR { get { return _FPJR; } set { _FPJR = value; } }
        System.String _LGORT;
        [DataMember]
        public System.String LGORT { get { return _LGORT; } set { _LGORT = value; } }
        System.String _ID;
        [DataMember]
        public System.String ID { get { return _ID; } set { _ID = value; } }
        System.DateTime? _HSDAT;
        [DataMember]
        public System.DateTime? HSDAT { get { return _HSDAT; } set { _HSDAT = value; } }
        System.Decimal _PKG_NUMBER;
        [DataMember]
        public System.Decimal PKG_NUMBER { get { return _PKG_NUMBER; } set { _PKG_NUMBER = value; } }
        System.String _EBELN;
        [DataMember]
        public System.String EBELN { get { return _EBELN; } set { _EBELN = value; } }
        System.String _MEINS;
        [DataMember]
        public System.String MEINS { get { return _MEINS; } set { _MEINS = value; } }
        System.Decimal _ORDER_MENGE;
        [DataMember]
        public System.Decimal ORDER_MENGE { get { return _ORDER_MENGE; } set { _ORDER_MENGE = value; } }
        System.String _STATUS;
        [DataMember]
        public System.String STATUS { get { return _STATUS; } set { _STATUS = value; } }
        System.DateTime _FPRQ;
        [DataMember]
        public System.DateTime FPRQ { get { return _FPRQ; } set { _FPRQ = value; } }
        System.String _NETPR;
        [DataMember]
        public System.String NETPR { get { return _NETPR; } set { _NETPR = value; } }
        System.String _FREEUSE3;
        [DataMember]
        public System.String FREEUSE3 { get { return _FREEUSE3; } set { _FREEUSE3 = value; } }
        System.String _FACTORY;
        [DataMember]
        public System.String FACTORY { get { return _FACTORY; } set { _FACTORY = value; } }
        System.String _CODE;
        [DataMember]
        public System.String CODE { get { return _CODE; } set { _CODE = value; } }
        System.String _GYJH;
        [DataMember]
        public System.String GYJH { get { return _GYJH; } set { _GYJH = value; } }
        System.String _WERKST;
        [DataMember]
        public System.String WERKST { get { return _WERKST; } set { _WERKST = value; } }
        System.String _FREEUSE1;
        [DataMember]
        public System.String FREEUSE1 { get { return _FREEUSE1; } set { _FREEUSE1 = value; } }
        System.Decimal _MENGE;
        [DataMember]
        public System.Decimal MENGE { get { return _MENGE; } set { _MENGE = value; } }
        System.String _CHARG;
        [DataMember]
        public System.String CHARG { get { return _CHARG; } set { _CHARG = value; } }
        System.String _MSEHT;
        [DataMember]
        public System.String MSEHT { get { return _MSEHT; } set { _MSEHT = value; } }
        System.String _MATNR;
        [DataMember]
        public System.String MATNR { get { return _MATNR; } set { _MATNR = value; } }
        System.String _GYSACCOUNT;
        [DataMember]
        public System.String GYSACCOUNT { get { return _GYSACCOUNT; } set { _GYSACCOUNT = value; } }
        System.String _UNINFORMED_STATE;
        [DataMember]
        public System.String UNINFORMED_STATE { get { return _UNINFORMED_STATE; } set { _UNINFORMED_STATE = value; } }
        System.DateTime _CREATE_TIME;
        [DataMember]
        public System.DateTime CREATE_TIME { get { return _CREATE_TIME; } set { _CREATE_TIME = value; } }
        System.String _NAME;
        [DataMember]
        public System.String NAME { get { return _NAME; } set { _NAME = value; } }
        System.String _GYSNAME;
        [DataMember]
        public System.String GYSNAME { get { return _GYSNAME; } set { _GYSNAME = value; } }
        System.Decimal _PKG_AMOUNT;
        [DataMember]
        public System.Decimal PKG_AMOUNT { get { return _PKG_AMOUNT; } set { _PKG_AMOUNT = value; } }
        System.String _SPEC;
        [DataMember]
        public System.String SPEC { get { return _SPEC; } set { _SPEC = value; } }
        System.String _FREEUSE2;
        [DataMember]
        public System.String FREEUSE2 { get { return _FREEUSE2; } set { _FREEUSE2 = value; } }
        System.String _COMMENTS;
        [DataMember]
        public System.String COMMENTS { get { return _COMMENTS; } set { _COMMENTS = value; } }
        System.String _BEDAT;
        [DataMember]
        public System.String BEDAT { get { return _BEDAT; } set { _BEDAT = value; } }
        System.DateTime _VFDAT;
        [DataMember]
        public System.DateTime VFDAT { get { return _VFDAT; } set { _VFDAT = value; } }
        System.String _INFORMED_STATE;
        [DataMember]
        public System.String INFORMED_STATE { get { return _INFORMED_STATE; } set { _INFORMED_STATE = value; } }
        System.String _EEIND;
        [DataMember]
        public System.String EEIND { get { return _EEIND; } set { _EEIND = value; } }

        #endregion
    }

}
