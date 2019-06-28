using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ipedf.App.SAP_WCF
{
    public class Sap_PurchasePlan
    {
        /// <summary>
        /// 采购凭证号
        /// </summary>
        public string EBELN { get; set; }
        /// <summary>
        /// 采购凭证项目编号
        /// </summary>
        public string EBELP { get; set; }
        /// <summary>
        /// 供应商账户
        /// </summary>
        public string LIFNR { get; set; }
        /// <summary>
        /// 库存地点描述
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 物料号
        /// </summary>
        public string MATNR { get; set; }
        /// <summary>
        /// 物料描述
        /// </summary>
        public string TXZ01 { get; set; }
        /// <summary>
        /// 院区
        /// </summary>
        public string WERKS { get; set; }
        /// <summary>
        /// 库存地点
        /// </summary>
        public string LGORT { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string MENGE { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        public string MEINS { get; set; }
        /// <summary>
        /// 竞价
        /// </summary>
        public string NETPR { get; set; }

        /// <summary>
        /// 交货日期
        /// </summary>
        public string EINDT { get; set; }

        /// <summary>
        /// 采购订单日期
        /// </summary>
        public string BEDAT { get; set; }

        /// <summary>
        /// 计量单位描述
        /// </summary>
        public string MSEHT { get; set; }

        /// <summary>
        /// 工厂描述
        /// </summary>
        public string WERKST { get; set; }

        /// <summary>
        /// 备注字段
        /// </summary>
        public string COMMENTS { get; set; }

        /// <summary>
        /// 预留字段
        /// </summary>
        public string FREEUSE { get; set; }
        /// <summary>
        /// 生产厂商
        /// </summary>
        public string PRODUCTFACTORY { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string SPEC { get; set; }
    }
}