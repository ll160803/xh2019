using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.Serialization;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.ComponentModel.DataAnnotations;//所添加的自定义验证引用
using System.ComponentModel;//所添加的自定义验证引用

namespace Ipedf.Web.Entity
{
    [Serializable]
    [DataContract]
    public partial class EntityObject_SCM_B_SENDINFO : EntityBase
    {
        #region Attribute Block

        //平台自动生成代码
        //WERKS
        System.String _WERKS;
        [DataMember]
        public System.String WERKS { get { return _WERKS; } set { _WERKS = value; } }
        System.String _MEINS;
        [DataMember]
        public System.String MEINS { get { return _MEINS; } set { _MEINS = value; } }
        System.String _COMMENTS;
        [DataMember]
        public System.String COMMENTS { get { return _COMMENTS; } set { _COMMENTS = value; } }
        System.DateTime _MODIFY_TIME;
        [DataMember]
        public System.DateTime MODIFY_TIME { get { return _MODIFY_TIME; } set { _MODIFY_TIME = value; } }
        System.String _DATA_ORGANISE_ID;
        [DataMember]
        public System.String DATA_ORGANISE_ID { get { return _DATA_ORGANISE_ID; } set { _DATA_ORGANISE_ID = value; } }
        System.String _ID;
        [DataMember]
        public System.String ID { get { return _ID; } set { _ID = value; } }
        System.String _CREATE_USER_ID;
        [DataMember]
        public System.String CREATE_USER_ID { get { return _CREATE_USER_ID; } set { _CREATE_USER_ID = value; } }
        System.String _LINK_PERSON;
        [DataMember]
        [Required(ErrorMessage = "联系人不能为空")]
        public System.String LINK_PERSON { get { return _LINK_PERSON; } set { _LINK_PERSON = value; } }
        System.String _MODIFY_USER_ID;
        [DataMember]
        public System.String MODIFY_USER_ID { get { return _MODIFY_USER_ID; } set { _MODIFY_USER_ID = value; } }
        System.String _SEND_DEPART;
        [DataMember]
        [Required(ErrorMessage = "送货科室不能为空")]
        public System.String SEND_DEPART { get { return _SEND_DEPART; } set { _SEND_DEPART = value; } }
        System.Decimal _STATE;
        [DataMember]
        public System.Decimal STATE { get { return _STATE; } set { _STATE = value; } }
        System.Decimal _MONEY;
        [DataMember]
        [Required(ErrorMessage = "金额不能为空")]
        public System.Decimal MONEY { get { return _MONEY; } set { _MONEY = value; } }

        System.Decimal _PRICE;
        [DataMember]
        [Required(ErrorMessage = "单价不能为空")]
        public System.Decimal PRICE { get { return _PRICE; } set { _PRICE = value; } }
        System.String _NAME;
        [DataMember]
        public System.String NAME { get { return _NAME; } set { _NAME = value; } }
        System.String _CREATE_DEPART_ID;
        [DataMember]
        public System.String CREATE_DEPART_ID { get { return _CREATE_DEPART_ID; } set { _CREATE_DEPART_ID = value; } }
        System.String _CODE;
        [DataMember]
        public System.String CODE { get { return _CODE; } set { _CODE = value; } }
        System.String _MSEHT;
        [DataMember]
        public System.String MSEHT { get { return _MSEHT; } set { _MSEHT = value; } }
        System.String _TXZ01;
        [DataMember]
        public System.String TXZ01 { get { return _TXZ01; } set { _TXZ01 = value; } }
        System.String _GYSACCOUNT;
        [DataMember]
        public System.String GYSACCOUNT { get { return _GYSACCOUNT; } set { _GYSACCOUNT = value; } }
        System.DateTime _CREATE_TIME;
        [DataMember]
        public System.DateTime CREATE_TIME { get { return _CREATE_TIME; } set { _CREATE_TIME = value; } }
        System.String _GYSNAME;
        [DataMember]
        public System.String GYSNAME { get { return _GYSNAME; } set { _GYSNAME = value; } }
        System.String _MATNR;
        [DataMember]
        [Required(ErrorMessage = "物料不能为空")]
        public System.String MATNR { get { return _MATNR; } set { _MATNR = value; } }
        System.Decimal _AMOUNT;
        [DataMember]
        [Required(ErrorMessage = "送货数量不能为空")]
        public System.Decimal AMOUNT { get { return _AMOUNT; } set { _AMOUNT = value; } }
        System.String _LINK_TELEPHONE;
        [DataMember]
        [Required(ErrorMessage = "联系方式不能为空")]
        public System.String LINK_TELEPHONE { get { return _LINK_TELEPHONE; } set { _LINK_TELEPHONE = value; } }
        System.String _MODIFY_DEPART_ID;
        [DataMember]
        public System.String MODIFY_DEPART_ID { get { return _MODIFY_DEPART_ID; } set { _MODIFY_DEPART_ID = value; } }
   
        System.String _MATER_CODE;
        [DataMember]
        [Required(ErrorMessage = "商品条码不能为空")]
        public System.String MATER_CODE { get { return _MATER_CODE; } set { _MATER_CODE = value; } }

        #endregion
    }
}
